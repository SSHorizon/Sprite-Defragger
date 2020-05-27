using SSHorizon.SpriteDefragger.TrainerCards;
using System.Collections.Generic;
using System.Drawing;

namespace SSHorizon.SpriteDefragger
{
    public class Solver
    {
        public static Rectangle SolvedDimensionsTrainerCard = new Rectangle(0, 0, 100, 80);
        public static Rectangle SolvedDimensionsBackSprites = new Rectangle(0, 0, 668, 80);

        public static Bitmap DefragTrainerCardSprites(Game game, Bitmap originalImage, bool fillBackground = false)
        {
            var originals = GetOriginalRectangles(game);
            var solved = GetSolvedRectangles(game);
            Brush brush = new SolidBrush(Color.FromArgb(0,0,0));
            Bitmap bitmap = new Bitmap(SolvedDimensionsTrainerCard.Width, SolvedDimensionsTrainerCard.Height);
            originalImage = FlattenImage(originalImage);
            return CopyPaste(bitmap, originalImage, originals, solved, fillBackground, brush);
        }

        public static Bitmap FragmentTrainerCardSprites(Game game, Bitmap solvedImage)
        {
            Rectangle dimensions = GetUnsolvedDimensions(game);
            var originals = GetOriginalRectangles(game);
            var solved = GetSolvedRectangles(game);
            Brush brush = new SolidBrush(Color.FromArgb(152, 152, 240));
            Bitmap bitmap2 = new Bitmap(dimensions.Width, dimensions.Height);
            bitmap2 = CopyPaste(bitmap2, solvedImage, solved, originals, true, brush);
            return UnflattenImage(bitmap2, game);
        }

        public static Bitmap DefragBackSprites(Game game, Bitmap originalImage, bool fillBackground = false)
        {
            var originals = BackSprites.Originals();
            var solved = BackSprites.Solved();
            Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0));
            Bitmap bitmap = new Bitmap(SolvedDimensionsBackSprites.Width, SolvedDimensionsBackSprites.Height);
            originalImage = FlattenImage(originalImage);
            return CopyPaste(bitmap, originalImage, originals, solved, fillBackground, brush);
        }

        public static Bitmap FragmentBackSprites(Game game, Bitmap solvedImage)
        {
            Rectangle dimensions = new Rectangle(0, 0 , 6400, 8);
            var originals = BackSprites.Originals();
            var solved = BackSprites.Solved();
            Brush brush = new SolidBrush(Color.FromArgb(152, 152, 240));
            Bitmap bitmap2 = new Bitmap(dimensions.Width, dimensions.Height);
            return CopyPaste(bitmap2, solvedImage, solved, originals, true, brush);
        }

        public static Bitmap FlattenImage(Bitmap img)
        {
            var layers = img.Height / 8;
            Bitmap flattened = new Bitmap(img.Width * layers, 8);
            var from = new List<Rectangle>();
            var to = new List<Rectangle>();
            for (var i = 0; i < layers; i++)
            {
                from.Add(new Rectangle(0, i * 8, img.Width, 8));
                to.Add(new Rectangle(i * img.Width, 0, 0, 0));
            }
            return CopyPaste(flattened, img, from, to);
        }

        public static Bitmap UnflattenImage(Bitmap img, Game game)
        {
            var dimensions = GetUnsolvedDimensions(game);
            int layers = dimensions.Height / 8;
            Bitmap unflattened = new Bitmap(dimensions.Width, dimensions.Height);
            List<Rectangle> from = new List<Rectangle>();
            List<Rectangle> to = new List<Rectangle>();
            for (int i = 0; i < layers; i++)
            {
                from.Add(new Rectangle(i * dimensions.Width, 0, dimensions.Width, 8));
                to.Add(new Rectangle(0, i * 8, 0, 0));
            }
            return CopyPaste(unflattened, img, from, to);
        }

        public static List<Rectangle> GetOriginalRectangles(Game game)
        {
            switch (game)
            {
                case Game.Pt: return PtTrainerCard.Originals();
                case Game.Hgss: return HgssTrainerCard.Originals();
                case Game.Dp: return DpTrainerCard.Originals();
                default: return null;
            }
        }

        public static List<Rectangle> GetSolvedRectangles(Game game)
        {
            switch (game)
            {
                case Game.Pt: return PtTrainerCard.Solved();
                case Game.Hgss: return HgssTrainerCard.Solved();
                case Game.Dp: return DpTrainerCard.Solved();
                default: return null;
            }
        }

        public static Rectangle GetUnsolvedDimensions(Game game)
        {
            switch (game)
            {
                case Game.Dp:
                case Game.Pt: return new Rectangle(0, 0, 768, 8);
                case Game.Hgss: return new Rectangle(0, 0, 1024, 8);
                default: return new Rectangle();
            }
        }

        private static Bitmap CopyPaste(Bitmap outImage, Bitmap inImage, List<Rectangle> from, List<Rectangle> to, bool fillBackground = false, Brush brush = null)
        {
            using (Graphics outGraphic = Graphics.FromImage(outImage))
            {
                if (fillBackground && brush != null)
                    outGraphic.FillRectangle(brush, new Rectangle(0, 0, outImage.Width, outImage.Height));
                for (int i = 0; i < from.Count; i++)
                {
                    Rectangle oldRect = from[i];
                    Rectangle newRect = to[i];
                    using (Bitmap nb = new Bitmap(oldRect.Width, oldRect.Height))
                    using (Graphics g = Graphics.FromImage(nb))
                    {
                        g.DrawImage(inImage, -oldRect.X, -oldRect.Y);
                        outGraphic.DrawImage(nb, newRect.X, newRect.Y);
                    }
                }
                return outImage;
            }
        }
    }
}
