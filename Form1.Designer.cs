﻿using System;
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
            finalColorSelect = new Button();
            initialColorSelect = new Button();
            DarkMode = new CheckBox();
            checkBox1 = new CheckBox();
            userControl11 = new UserControl1(pictureBox1);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(12, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(977, 432);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_2Click;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(15, 4);
            userControl11.Margin = new Padding(3, 4, 3, 4);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(741, 113);
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
            // DarkMode
            // 
            DarkMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DarkMode.AutoSize = true;
            DarkMode.Location = new Point(762, 14);
            DarkMode.Margin = new Padding(3, 2, 3, 2);
            DarkMode.Name = "DarkMode";
            DarkMode.Size = new Size(84, 19);
            DarkMode.TabIndex = 166;
            DarkMode.Text = "Dark Mode";
            DarkMode.UseVisualStyleBackColor = true;
            DarkMode.CheckStateChanged += DarkMode_CheckStateChanged;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(15, 4);
            userControl11.Margin = new Padding(3, 4, 3, 4);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(741, 113);
            userControl11.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(872, 14);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 167;
            checkBox1.Text = "Go FullScreen";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 567);
            Controls.Add(checkBox1);
            Controls.Add(DarkMode);
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
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private UserControl1 userControl11;
        private Button finalColorSelect;
        private Button initialColorSelect;
        private CheckBox DarkMode;
        private CheckBox checkBox1;
    }
}
