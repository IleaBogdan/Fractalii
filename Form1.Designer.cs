using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;

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
            finalColorSelect = new Button();
            initialColorSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(977, 432);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(12, 1);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(741, 116);
            userControl11.TabIndex = 1;
            // 
            // finalColorSelect
            // 
            finalColorSelect.Location = new Point(872, 37);
            finalColorSelect.Margin = new Padding(3, 2, 3, 2);
            finalColorSelect.Name = "finalColorSelect";
            finalColorSelect.Size = new Size(108, 61);
            finalColorSelect.TabIndex = 165;
            finalColorSelect.Text = "Select final color";
            finalColorSelect.UseVisualStyleBackColor = true;
            finalColorSelect.Click += finalColorSelect_Click;
            // 
            // initialColorSelect
            // 
            initialColorSelect.Location = new Point(759, 37);
            initialColorSelect.Margin = new Padding(3, 2, 3, 2);
            initialColorSelect.Name = "initialColorSelect";
            initialColorSelect.Size = new Size(108, 61);
            initialColorSelect.TabIndex = 164;
            initialColorSelect.Text = "Select initial color";
            initialColorSelect.UseVisualStyleBackColor = true;
            initialColorSelect.Click += initialColorSelect_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 567);
            Controls.Add(finalColorSelect);
            Controls.Add(initialColorSelect);
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
        private Button finalColorSelect;
        private Button initialColorSelect;
    }
}
