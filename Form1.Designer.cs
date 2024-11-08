using System;
using System.Diagnostics;
using System.Drawing.Text;

namespace Fractalii
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            userControl11 = new UserControl1();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(977, 449);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(12, 1);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(977, 116);
            userControl11.TabIndex = 1;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 567);
            Controls.Add(userControl11);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractal Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private UserControl1 userControl11;
    }
}
