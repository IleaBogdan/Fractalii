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

        public void debbug()
        {
            if (Debugger.IsAttached)
            {

                // tab1 (treeFractal) default button code:
                Button default_button = new Button();
                tabPage1.Controls.Add(default_button);
                // 
                // default_button
                // 
                default_button.Location = new Point(525, 50);
                default_button.Name = "default_button";
                default_button.Size = new Size(85, 23);
                default_button.TabIndex = 13;
                default_button.Text = "Default";
                default_button.UseVisualStyleBackColor = true;
                //default_button.Click += default_button_Click_treeFractal;


                // tab2 (triangleFractal) default button code:

            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            picture_kochline = new PictureBox();
            tabPage1 = new TabPage();
            userControl11 = new TreeFractal.UserControlTree();
            pictureBox_treeFractal = new PictureBox();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_kochline).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_treeFractal).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(picture_kochline);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(991, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Koch-Line Fractal";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // picture_kochline
            // 
            picture_kochline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picture_kochline.Location = new Point(6, 81);
            picture_kochline.Name = "picture_kochline";
            picture_kochline.Size = new Size(976, 451);
            picture_kochline.TabIndex = 0;
            picture_kochline.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(userControl11);
            tabPage1.Controls.Add(pictureBox_treeFractal);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(991, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tree Fractal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(988, 90);
            userControl11.TabIndex = 2;
            // 
            // pictureBox_treeFractal
            // 
            pictureBox_treeFractal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_treeFractal.Location = new Point(15, 98);
            pictureBox_treeFractal.Margin = new Padding(3, 2, 3, 2);
            pictureBox_treeFractal.Name = "pictureBox_treeFractal";
            pictureBox_treeFractal.Size = new Size(976, 443);
            pictureBox_treeFractal.TabIndex = 1;
            pictureBox_treeFractal.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.HotTrack = true;
            tabControl1.ItemSize = new Size(120, 20);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(999, 565);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 102;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 567);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractal Page";
            Load += Form1_Load;
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_kochline).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_treeFractal).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private PictureBox picture_kochline;
        private TabPage tabPage1;
        private PictureBox pictureBox_treeFractal;
        private TabControl tabControl1;
        private TreeFractal.UserControlTree userControl11;
    }
}
