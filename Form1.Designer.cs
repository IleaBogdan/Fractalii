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
                default_button.Click += default_button_Click_treeFractal;


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
            pictureBox_treeFractal = new PictureBox();
            textBox_angle_left_tab1 = new TextBox();
            label_angle_left_tab1 = new Label();
            label_angle_right_tab1 = new Label();
            textBox_angle_right_tab1 = new TextBox();
            label_size_tab1 = new Label();
            textBox_size_tab1 = new TextBox();
            button1 = new Button();
            label_levels_tab1 = new Label();
            textBox_levels_tab1 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            label_width_tab1 = new Label();
            textBox_width_tab1 = new TextBox();
            label_width_max_tab1 = new Label();
            label_reduction_left_tab1 = new Label();
            textBox_reduction_left_tab1 = new TextBox();
            label_procent_reduction_left_tab1 = new Label();
            label_procent_reduction_right_tab1 = new Label();
            textBox_reduction_right_tab1 = new TextBox();
            label_reduction_right_tab1 = new Label();
            initialColorSelect_treeFractal_tab1 = new Button();
            finalColorSelect_treeFractal_tab1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox_treeFractal).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_treeFractal
            // 
            pictureBox_treeFractal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_treeFractal.Location = new Point(6, 81);
            pictureBox_treeFractal.Margin = new Padding(3, 2, 3, 2);
            pictureBox_treeFractal.Name = "pictureBox_treeFractal";
            pictureBox_treeFractal.Size = new Size(976, 451);
            pictureBox_treeFractal.TabIndex = 1;
            pictureBox_treeFractal.TabStop = false;
            // 
            // textBox_angle_left_tab1
            // 
            textBox_angle_left_tab1.Location = new Point(73, 18);
            textBox_angle_left_tab1.Margin = new Padding(3, 2, 3, 2);
            textBox_angle_left_tab1.Name = "textBox_angle_left_tab1";
            textBox_angle_left_tab1.Size = new Size(100, 23);
            textBox_angle_left_tab1.TabIndex = 2;
            // 
            // label_angle_left_tab1
            // 
            label_angle_left_tab1.AutoSize = true;
            label_angle_left_tab1.Location = new Point(6, 21);
            label_angle_left_tab1.Name = "label_angle_left_tab1";
            label_angle_left_tab1.Size = new Size(61, 15);
            label_angle_left_tab1.TabIndex = 32;
            label_angle_left_tab1.Text = "Angle left:";
            // 
            // label_angle_right_tab1
            // 
            label_angle_right_tab1.AutoSize = true;
            label_angle_right_tab1.Location = new Point(179, 21);
            label_angle_right_tab1.Name = "label_angle_right_tab1";
            label_angle_right_tab1.Size = new Size(69, 15);
            label_angle_right_tab1.TabIndex = 34;
            label_angle_right_tab1.Text = "Angle right:";
            // 
            // textBox_angle_right_tab1
            // 
            textBox_angle_right_tab1.Location = new Point(254, 18);
            textBox_angle_right_tab1.Margin = new Padding(3, 2, 3, 2);
            textBox_angle_right_tab1.Name = "textBox_angle_right_tab1";
            textBox_angle_right_tab1.Size = new Size(100, 23);
            textBox_angle_right_tab1.TabIndex = 4;
            // 
            // label_size_tab1
            // 
            label_size_tab1.AutoSize = true;
            label_size_tab1.Location = new Point(360, 21);
            label_size_tab1.Name = "label_size_tab1";
            label_size_tab1.Size = new Size(30, 15);
            label_size_tab1.TabIndex = 35;
            label_size_tab1.Text = "Size:";
            // 
            // textBox_size_tab1
            // 
            textBox_size_tab1.Location = new Point(396, 18);
            textBox_size_tab1.Margin = new Padding(3, 2, 3, 2);
            textBox_size_tab1.Name = "textBox_size_tab1";
            textBox_size_tab1.Size = new Size(99, 23);
            textBox_size_tab1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(822, 18);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(80, 40);
            button1.TabIndex = 100;
            button1.Text = "Generate recursively";
            button1.UseVisualStyleBackColor = true;
            button1.Click += genearte_treeFractal_recursive;
            // 
            // label_levels_tab1
            // 
            label_levels_tab1.AutoSize = true;
            label_levels_tab1.Location = new Point(501, 21);
            label_levels_tab1.Name = "label_levels_tab1";
            label_levels_tab1.Size = new Size(39, 15);
            label_levels_tab1.TabIndex = 34;
            label_levels_tab1.Text = "Levels";
            // 
            // textBox_levels_tab1
            // 
            textBox_levels_tab1.Location = new Point(546, 18);
            textBox_levels_tab1.Name = "textBox_levels_tab1";
            textBox_levels_tab1.Size = new Size(63, 23);
            textBox_levels_tab1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(570, 21);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 30;
            label5.Text = "<15 ";
            // 
            // button2
            // 
            button2.Location = new Point(907, 18);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 101;
            button2.Text = "Generate iteratively";
            button2.UseVisualStyleBackColor = true;
            button2.Click += generate_treeFractal_iterative;
            // 
            // label_width_tab1
            // 
            label_width_tab1.AutoSize = true;
            label_width_tab1.Location = new Point(360, 54);
            label_width_tab1.Name = "label_width_tab1";
            label_width_tab1.Size = new Size(42, 15);
            label_width_tab1.TabIndex = 13;
            label_width_tab1.Text = "Width:";
            // 
            // textBox_width_tab1
            // 
            textBox_width_tab1.Location = new Point(408, 51);
            textBox_width_tab1.Name = "textBox_width_tab1";
            textBox_width_tab1.Size = new Size(87, 23);
            textBox_width_tab1.TabIndex = 11;
            // 
            // label_width_max_tab1
            // 
            label_width_max_tab1.AutoSize = true;
            label_width_max_tab1.BackColor = SystemColors.ButtonHighlight;
            label_width_max_tab1.Location = new Point(460, 54);
            label_width_max_tab1.Name = "label_width_max_tab1";
            label_width_max_tab1.Size = new Size(24, 15);
            label_width_max_tab1.TabIndex = 31;
            label_width_max_tab1.Text = "<7 ";
            // 
            // label_reduction_left_tab1
            // 
            label_reduction_left_tab1.AutoSize = true;
            label_reduction_left_tab1.Location = new Point(6, 51);
            label_reduction_left_tab1.Name = "label_reduction_left_tab1";
            label_reduction_left_tab1.Size = new Size(81, 15);
            label_reduction_left_tab1.TabIndex = 36;
            label_reduction_left_tab1.Text = "Left Redution:";
            // 
            // textBox_reduction_left_tab1
            // 
            textBox_reduction_left_tab1.Location = new Point(93, 48);
            textBox_reduction_left_tab1.Name = "textBox_reduction_left_tab1";
            textBox_reduction_left_tab1.Size = new Size(80, 23);
            textBox_reduction_left_tab1.TabIndex = 9;
            // 
            // label_procent_reduction_left_tab1
            // 
            label_procent_reduction_left_tab1.AutoSize = true;
            label_procent_reduction_left_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_left_tab1.Location = new Point(149, 54);
            label_procent_reduction_left_tab1.Name = "label_procent_reduction_left_tab1";
            label_procent_reduction_left_tab1.Size = new Size(17, 15);
            label_procent_reduction_left_tab1.TabIndex = 38;
            label_procent_reduction_left_tab1.Text = "%";
            // 
            // label_procent_reduction_right_tab1
            // 
            label_procent_reduction_right_tab1.AutoSize = true;
            label_procent_reduction_right_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_right_tab1.Location = new Point(330, 54);
            label_procent_reduction_right_tab1.Name = "label_procent_reduction_right_tab1";
            label_procent_reduction_right_tab1.Size = new Size(17, 15);
            label_procent_reduction_right_tab1.TabIndex = 41;
            label_procent_reduction_right_tab1.Text = "%";
            // 
            // textBox_reduction_right_tab1
            // 
            textBox_reduction_right_tab1.Location = new Point(274, 48);
            textBox_reduction_right_tab1.Name = "textBox_reduction_right_tab1";
            textBox_reduction_right_tab1.Size = new Size(80, 23);
            textBox_reduction_right_tab1.TabIndex = 10;
            // 
            // label_reduction_right_tab1
            // 
            label_reduction_right_tab1.AutoSize = true;
            label_reduction_right_tab1.Location = new Point(179, 51);
            label_reduction_right_tab1.Name = "label_reduction_right_tab1";
            label_reduction_right_tab1.Size = new Size(89, 15);
            label_reduction_right_tab1.TabIndex = 39;
            label_reduction_right_tab1.Text = "Right Redution:";
            // 
            // initialColorSelect_treeFractal_tab1
            // 
            initialColorSelect_treeFractal_tab1.Location = new Point(626, 18);
            initialColorSelect_treeFractal_tab1.Margin = new Padding(3, 2, 3, 2);
            initialColorSelect_treeFractal_tab1.Name = "initialColorSelect_treeFractal_tab1";
            initialColorSelect_treeFractal_tab1.Size = new Size(88, 53);
            initialColorSelect_treeFractal_tab1.TabIndex = 42;
            initialColorSelect_treeFractal_tab1.Text = "Select initial color";
            initialColorSelect_treeFractal_tab1.UseVisualStyleBackColor = true;
            initialColorSelect_treeFractal_tab1.Click += initialColorSelect_Click;
            // 
            // finalColorSelect_treeFractal_tab1
            // 
            finalColorSelect_treeFractal_tab1.Location = new Point(718, 18);
            finalColorSelect_treeFractal_tab1.Margin = new Padding(3, 2, 3, 2);
            finalColorSelect_treeFractal_tab1.Name = "finalColorSelect_treeFractal_tab1";
            finalColorSelect_treeFractal_tab1.Size = new Size(88, 53);
            finalColorSelect_treeFractal_tab1.TabIndex = 43;
            finalColorSelect_treeFractal_tab1.Text = "Select final color";
            finalColorSelect_treeFractal_tab1.UseVisualStyleBackColor = true;
            finalColorSelect_treeFractal_tab1.Click += finalColorSelect_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(0, 1);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(999, 565);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 102;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox_angle_left_tab1);
            tabPage1.Controls.Add(finalColorSelect_treeFractal_tab1);
            tabPage1.Controls.Add(pictureBox_treeFractal);
            tabPage1.Controls.Add(initialColorSelect_treeFractal_tab1);
            tabPage1.Controls.Add(label_angle_left_tab1);
            tabPage1.Controls.Add(label_procent_reduction_right_tab1);
            tabPage1.Controls.Add(textBox_angle_right_tab1);
            tabPage1.Controls.Add(textBox_reduction_right_tab1);
            tabPage1.Controls.Add(label_angle_right_tab1);
            tabPage1.Controls.Add(label_reduction_right_tab1);
            tabPage1.Controls.Add(label_size_tab1);
            tabPage1.Controls.Add(label_procent_reduction_left_tab1);
            tabPage1.Controls.Add(textBox_size_tab1);
            tabPage1.Controls.Add(textBox_reduction_left_tab1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label_reduction_left_tab1);
            tabPage1.Controls.Add(label_levels_tab1);
            tabPage1.Controls.Add(label_width_max_tab1);
            tabPage1.Controls.Add(textBox_levels_tab1);
            tabPage1.Controls.Add(textBox_width_tab1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label_width_tab1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(991, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tree Fractal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(991, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Triangle Fractal";
            tabPage2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox_treeFractal).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox_treeFractal;
        private TextBox textBox_angle_left_tab1;
        private Label label_angle_left_tab1;
        private Label label_angle_right_tab1;
        private TextBox textBox_angle_right_tab1;
        private Label label_size_tab1;
        private TextBox textBox_size_tab1;
        private Button button1;
        private Label label_levels_tab1;
        private TextBox textBox_levels_tab1;
        private Label label5;
        private Button button2;
        private Label label_width_tab1;
        private TextBox textBox_width_tab1;
        private Label label_width_max_tab1;
        private Label label_reduction_left_tab1;
        private TextBox textBox_reduction_left_tab1;
        private Label label_procent_reduction_left_tab1;
        private Label label_procent_reduction_right_tab1;
        private TextBox textBox_reduction_right_tab1;
        private Label label_reduction_right_tab1;
        private Button initialColorSelect_treeFractal_tab1;
        private Button finalColorSelect_treeFractal_tab1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
