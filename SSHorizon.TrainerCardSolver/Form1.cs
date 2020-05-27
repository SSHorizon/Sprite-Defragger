using System;
using System.Drawing;
using System.Windows.Forms;
using SSHorizon.SpriteDefragger;

namespace SSHorizon.TrainerCardSolver
{
    public partial class Form1 : Form
    {
        private Game _game;

        private const string FileFilter = "Portable Network Graphic (*.png)|*.png|" + "BitMaP (*.bmp)|*.bmp|" + "JPEG (*.jpg)|*.jpg;*.jpeg|" + "Tagged Image File Format (*.tiff)|*.tiff;*.tif|" + "Graphic Interchange Format (*.gif)|*.gif|" + "Icon (*.ico)|*.ico;*.icon";

        private bool _isTrainerCard;

        public Form1()
        {
            InitializeComponent();
            gameSelect.Items.Add(
                new GameItem
                {
                    Text = "--- Select ---",
                    Value = Game.Default
                }
            );
            gameSelect.Items.Add(
                new GameItem
                {
                    Text = "Diamond/Pearl",
                    Value = Game.Dp
                }
            );
            gameSelect.Items.Add(
                new GameItem
                {
                    Text = "Platinum",
                    Value = Game.Pt
                }
            );
            gameSelect.Items.Add(
                new GameItem
                {
                    Text = "Heart Gold/Soul Silver",
                    Value = Game.Hgss
                }
            );
            _isTrainerCard = true;
        }

        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                Filter = FileFilter
            };
            if (o.ShowDialog() != DialogResult.OK)
                return;

            Image img = Image.FromFile(o.FileName);
            Rectangle solved = Solver.SolvedDimensionsTrainerCard;

            if (img.Width == solved.Width && img.Height == solved.Height)
            {
                unformat.Show();
                format.Hide();
                save.Show();
                pictureBox1.Image = img;
                pictureBox1.Show();
            }
            else
            {
                format.Show();
                unformat.Hide();
                save.Show();
                pictureBox1.Image = img;
                pictureBox1.Show();
            }
        }

        private void game_SelectedIndexChanged(object sender, EventArgs e)
        {
            format.Hide();
            unformat.Hide();
            pictureBox1.Hide();
            save.Hide();
            Game gameName = ((GameItem)gameSelect.SelectedItem).Value;
            if (gameName == Game.Default)
            {
                import.Hide();
                pictureBox1.Image = null;
            }
            else
            {
                import.Show();
                _game = gameName;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog o = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = ".png",
                Filter = FileFilter,
                OverwritePrompt = true
            };

            if (o.ShowDialog() == DialogResult.OK)
            {
                if (o.FilterIndex == 2)
                    pictureBox1.Image.Save(o.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                else if (o.FilterIndex == 1)
                    pictureBox1.Image.Save(o.FileName, System.Drawing.Imaging.ImageFormat.Png);
                else if (o.FilterIndex == 3)
                    pictureBox1.Image.Save(o.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (o.FilterIndex == 4)
                    pictureBox1.Image.Save(o.FileName, System.Drawing.Imaging.ImageFormat.Tiff);
                else if (o.FilterIndex == 5)
                    pictureBox1.Image.Save(o.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                else if (o.FilterIndex == 6)
                    pictureBox1.Image.Save(o.FileName, System.Drawing.Imaging.ImageFormat.Icon);
            }
            o.Dispose();
        }

        private void format_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image.Width % 8 != 0 || pictureBox1.Image.Height % 8 != 0)
            {
                MessageBox.Show("Image does not match expected dimensions. Width and Height of image should be multiples of 8.");
                return;
            }
            format.Hide();
            unformat.Show();
            pictureBox1.Image = _isTrainerCard
                ? Solver.DefragTrainerCardSprites(_game, (Bitmap) pictureBox1.Image, true)
                : Solver.DefragBackSprites(_game, (Bitmap) pictureBox1.Image, true);
        }

        private void unformat_Click(object sender, EventArgs e)
        {
            if (_isTrainerCard)
            {
                if (pictureBox1.Image.Width != Solver.SolvedDimensionsTrainerCard.Width || pictureBox1.Image.Height != Solver.SolvedDimensionsTrainerCard.Height)
                {
                    MessageBox.Show("Image does not match expected dimensions of " + Solver.SolvedDimensionsTrainerCard.Width + " by " + Solver.SolvedDimensionsTrainerCard.Height);
                    return;
                }
                pictureBox1.Image = Solver.FragmentTrainerCardSprites(_game, (Bitmap)pictureBox1.Image);
            }
            else
            {
                if (pictureBox1.Image.Width != Solver.SolvedDimensionsBackSprites.Width || pictureBox1.Image.Height != Solver.SolvedDimensionsBackSprites.Height)
                {
                    MessageBox.Show("Image does not match expected dimensions of " + Solver.SolvedDimensionsBackSprites.Width + " by " + Solver.SolvedDimensionsBackSprites.Height);
                    return;
                }
                pictureBox1.Image = Solver.FragmentBackSprites(_game, (Bitmap)pictureBox1.Image);
            }
            format.Show();
            unformat.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _isTrainerCard = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _isTrainerCard = false;
        }
    }
}
