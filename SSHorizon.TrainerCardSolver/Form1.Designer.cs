using System;

namespace SSHorizon.TrainerCardSolver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.import = new System.Windows.Forms.Button();
            this.gameSelect = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.format = new System.Windows.Forms.Button();
            this.unformat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(12, 80);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 0;
            this.import.Text = "Open";
            this.import.UseVisualStyleBackColor = true;
            this.import.Visible = false;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // gameSelect
            // 
            this.gameSelect.FormattingEnabled = true;
            this.gameSelect.Location = new System.Drawing.Point(12, 53);
            this.gameSelect.Name = "gameSelect";
            this.gameSelect.Size = new System.Drawing.Size(121, 21);
            this.gameSelect.TabIndex = 2;
            this.gameSelect.Text = "--- Select ---";
            this.gameSelect.SelectedIndexChanged += new System.EventHandler(this.game_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 167);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // format
            // 
            this.format.Location = new System.Drawing.Point(12, 109);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(75, 23);
            this.format.TabIndex = 4;
            this.format.Text = "Defrag";
            this.format.UseVisualStyleBackColor = true;
            this.format.Visible = false;
            this.format.Click += new System.EventHandler(this.format_Click);
            // 
            // unformat
            // 
            this.unformat.Location = new System.Drawing.Point(12, 138);
            this.unformat.Name = "unformat";
            this.unformat.Size = new System.Drawing.Size(75, 23);
            this.unformat.TabIndex = 7;
            this.unformat.Text = "Fragment";
            this.unformat.UseVisualStyleBackColor = true;
            this.unformat.Visible = false;
            this.unformat.Click += new System.EventHandler(this.unformat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select game";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Trainer Card";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(100, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "Back Sprite";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(195, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 248);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.format);
            this.Controls.Add(this.unformat);
            this.Controls.Add(this.gameSelect);
            this.Controls.Add(this.import);
            this.Name = "Form1";
            this.Text = "Trainer Card Defragger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button import;
        private System.Windows.Forms.ComboBox gameSelect;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button format;
        private System.Windows.Forms.Button unformat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

