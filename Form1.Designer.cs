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
            DarkMode = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(14, 164);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1117, 576);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_2Click;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(17, 5);
            userControl11.Margin = new Padding(3, 5, 3, 5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(847, 151);
            userControl11.TabIndex = 1;
            // 
            // finalColorSelect
            // 
            finalColorSelect.Location = new Point(997, 49);
            finalColorSelect.Name = "finalColorSelect";
            finalColorSelect.Size = new Size(123, 81);
            finalColorSelect.TabIndex = 165;
            finalColorSelect.Text = "Select final color";
            finalColorSelect.UseVisualStyleBackColor = true;
            finalColorSelect.Click += finalColorSelect_Click;
            // 
            // initialColorSelect
            // 
            initialColorSelect.Location = new Point(867, 49);
            initialColorSelect.Name = "initialColorSelect";
            initialColorSelect.Size = new Size(123, 81);
            initialColorSelect.TabIndex = 164;
            initialColorSelect.Text = "Select initial color";
            initialColorSelect.UseVisualStyleBackColor = true;
            initialColorSelect.Click += initialColorSelect_Click;
            // 
            // DarkMode
            // 
            DarkMode.AutoSize = true;
            DarkMode.Location = new Point(941, 19);
            DarkMode.Name = "DarkMode";
            DarkMode.Size = new Size(105, 24);
            DarkMode.TabIndex = 166;
            DarkMode.Text = "Dark Mode";
            DarkMode.UseVisualStyleBackColor = true;
            DarkMode.CheckStateChanged += DarkMode_CheckStateChanged;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 756);
            Controls.Add(DarkMode);
            Controls.Add(finalColorSelect);
            Controls.Add(initialColorSelect);
            Controls.Add(userControl11);
            Controls.Add(pictureBox1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractal Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private UserControl1 userControl11;
        private Button finalColorSelect;
        private Button initialColorSelect;
        private CheckBox DarkMode;
    }
}
