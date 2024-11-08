﻿using System.Diagnostics;
using System.Windows.Forms;

namespace Fractalii
{
    partial class UserControl1
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
        public void debug()
        {
            if (Debugger.IsAttached)
            {

                // tab1 (treeFractal) default button code:
                Button default_button1 = new Button();
                tabPage1.Controls.Add(default_button1);
                // 
                // default_button
                // 
                default_button1.Location = new Point(430, 40);
                default_button1.Name = "default_button";
                default_button1.Size = new Size(85, 23);
                default_button1.TabIndex = 13;
                default_button1.Text = "Default";
                default_button1.UseVisualStyleBackColor = true;
                default_button1.Click += default_button_Click_treeFractal;


                // tab1 (kochLineFractal) default button code:
                Button default_button2 = new Button();
                tabPage2.Controls.Add(default_button2);
                // 
                // default_button
                // 
                default_button2.Location = new Point(430, 40);
                default_button2.Name = "default_button";
                default_button2.Size = new Size(85, 23);
                default_button2.TabIndex = 13;
                default_button2.Text = "Default";
                default_button2.UseVisualStyleBackColor = true;
                default_button2.Click += default_button_Click_KochLine;

            }
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox_angle_left_tab1 = new TextBox();
            textBox_angle_right_tab1 = new TextBox();
            textBox_reduction_right_tab1 = new TextBox();
            textBox_size_tab1 = new TextBox();
            textBox_reduction_left_tab1 = new TextBox();
            textBox_levels_tab1 = new TextBox();
            textBox_width_tab1 = new TextBox();
            finalColorSelect_treeFractal_tab1 = new Button();
            initialColorSelect_treeFractal_tab1 = new Button();
            label_angle_left_tab1 = new Label();
            label_procent_reduction_right_tab1 = new Label();
            label_angle_right_tab1 = new Label();
            label_reduction_right_tab1 = new Label();
            label_size_tab1 = new Label();
            label_procent_reduction_left_tab1 = new Label();
            button1 = new Button();
            label_reduction_left_tab1 = new Label();
            label_levels_tab1 = new Label();
            label_width_max_tab1 = new Label();
            label5 = new Label();
            label_width_tab1 = new Label();
            button2 = new Button();
            tabPage2 = new TabPage();
            width_KochLine = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            levels_KochLine = new TextBox();
            label1 = new Label();
            label4 = new Label();
            size_KochLine = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.ItemSize = new Size(90, 20);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(15, 4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(963, 98);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox_angle_left_tab1);
            tabPage1.Controls.Add(textBox_angle_right_tab1);
            tabPage1.Controls.Add(textBox_reduction_right_tab1);
            tabPage1.Controls.Add(textBox_size_tab1);
            tabPage1.Controls.Add(textBox_reduction_left_tab1);
            tabPage1.Controls.Add(textBox_levels_tab1);
            tabPage1.Controls.Add(textBox_width_tab1);
            tabPage1.Controls.Add(finalColorSelect_treeFractal_tab1);
            tabPage1.Controls.Add(initialColorSelect_treeFractal_tab1);
            tabPage1.Controls.Add(label_angle_left_tab1);
            tabPage1.Controls.Add(label_procent_reduction_right_tab1);
            tabPage1.Controls.Add(label_angle_right_tab1);
            tabPage1.Controls.Add(label_reduction_right_tab1);
            tabPage1.Controls.Add(label_size_tab1);
            tabPage1.Controls.Add(label_procent_reduction_left_tab1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label_reduction_left_tab1);
            tabPage1.Controls.Add(label_levels_tab1);
            tabPage1.Controls.Add(label_width_max_tab1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label_width_tab1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(955, 70);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tree";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_angle_left_tab1
            // 
            textBox_angle_left_tab1.Location = new Point(73, 10);
            textBox_angle_left_tab1.Margin = new Padding(3, 2, 3, 2);
            textBox_angle_left_tab1.Name = "textBox_angle_left_tab1";
            textBox_angle_left_tab1.Size = new Size(69, 23);
            textBox_angle_left_tab1.TabIndex = 146;
            // 
            // textBox_angle_right_tab1
            // 
            textBox_angle_right_tab1.Location = new Point(226, 10);
            textBox_angle_right_tab1.Margin = new Padding(3, 2, 3, 2);
            textBox_angle_right_tab1.Name = "textBox_angle_right_tab1";
            textBox_angle_right_tab1.Size = new Size(69, 23);
            textBox_angle_right_tab1.TabIndex = 147;
            // 
            // textBox_reduction_right_tab1
            // 
            textBox_reduction_right_tab1.Location = new Point(246, 40);
            textBox_reduction_right_tab1.Name = "textBox_reduction_right_tab1";
            textBox_reduction_right_tab1.Size = new Size(21, 23);
            textBox_reduction_right_tab1.TabIndex = 151;
            // 
            // textBox_size_tab1
            // 
            textBox_size_tab1.Location = new Point(337, 10);
            textBox_size_tab1.Margin = new Padding(3, 2, 3, 2);
            textBox_size_tab1.Name = "textBox_size_tab1";
            textBox_size_tab1.Size = new Size(68, 23);
            textBox_size_tab1.TabIndex = 148;
            // 
            // textBox_reduction_left_tab1
            // 
            textBox_reduction_left_tab1.Location = new Point(93, 40);
            textBox_reduction_left_tab1.Name = "textBox_reduction_left_tab1";
            textBox_reduction_left_tab1.Size = new Size(26, 23);
            textBox_reduction_left_tab1.TabIndex = 150;
            // 
            // textBox_levels_tab1
            // 
            textBox_levels_tab1.Location = new Point(456, 10);
            textBox_levels_tab1.Name = "textBox_levels_tab1";
            textBox_levels_tab1.Size = new Size(38, 23);
            textBox_levels_tab1.TabIndex = 149;
            // 
            // textBox_width_tab1
            // 
            textBox_width_tab1.Location = new Point(363, 40);
            textBox_width_tab1.Name = "textBox_width_tab1";
            textBox_width_tab1.Size = new Size(26, 23);
            textBox_width_tab1.TabIndex = 152;
            // 
            // finalColorSelect_treeFractal_tab1
            // 
            finalColorSelect_treeFractal_tab1.Location = new Point(649, 2);
            finalColorSelect_treeFractal_tab1.Margin = new Padding(3, 2, 3, 2);
            finalColorSelect_treeFractal_tab1.Name = "finalColorSelect_treeFractal_tab1";
            finalColorSelect_treeFractal_tab1.Size = new Size(108, 61);
            finalColorSelect_treeFractal_tab1.TabIndex = 165;
            finalColorSelect_treeFractal_tab1.Text = "Select final color";
            finalColorSelect_treeFractal_tab1.UseVisualStyleBackColor = true;
            finalColorSelect_treeFractal_tab1.Click += finalColorSelect_Click;
            // 
            // initialColorSelect_treeFractal_tab1
            // 
            initialColorSelect_treeFractal_tab1.Location = new Point(536, 2);
            initialColorSelect_treeFractal_tab1.Margin = new Padding(3, 2, 3, 2);
            initialColorSelect_treeFractal_tab1.Name = "initialColorSelect_treeFractal_tab1";
            initialColorSelect_treeFractal_tab1.Size = new Size(108, 61);
            initialColorSelect_treeFractal_tab1.TabIndex = 164;
            initialColorSelect_treeFractal_tab1.Text = "Select initial color";
            initialColorSelect_treeFractal_tab1.UseVisualStyleBackColor = true;
            initialColorSelect_treeFractal_tab1.Click += initialColorSelect_Click;
            // 
            // label_angle_left_tab1
            // 
            label_angle_left_tab1.AutoSize = true;
            label_angle_left_tab1.Location = new Point(6, 13);
            label_angle_left_tab1.Name = "label_angle_left_tab1";
            label_angle_left_tab1.Size = new Size(61, 15);
            label_angle_left_tab1.TabIndex = 156;
            label_angle_left_tab1.Text = "Angle left:";
            // 
            // label_procent_reduction_right_tab1
            // 
            label_procent_reduction_right_tab1.AutoSize = true;
            label_procent_reduction_right_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_right_tab1.Location = new Point(278, 43);
            label_procent_reduction_right_tab1.Name = "label_procent_reduction_right_tab1";
            label_procent_reduction_right_tab1.Size = new Size(17, 15);
            label_procent_reduction_right_tab1.TabIndex = 163;
            label_procent_reduction_right_tab1.Text = "%";
            // 
            // label_angle_right_tab1
            // 
            label_angle_right_tab1.AutoSize = true;
            label_angle_right_tab1.Location = new Point(151, 13);
            label_angle_right_tab1.Name = "label_angle_right_tab1";
            label_angle_right_tab1.Size = new Size(69, 15);
            label_angle_right_tab1.TabIndex = 158;
            label_angle_right_tab1.Text = "Angle right:";
            // 
            // label_reduction_right_tab1
            // 
            label_reduction_right_tab1.AutoSize = true;
            label_reduction_right_tab1.Location = new Point(151, 43);
            label_reduction_right_tab1.Name = "label_reduction_right_tab1";
            label_reduction_right_tab1.Size = new Size(89, 15);
            label_reduction_right_tab1.TabIndex = 162;
            label_reduction_right_tab1.Text = "Right Redution:";
            // 
            // label_size_tab1
            // 
            label_size_tab1.AutoSize = true;
            label_size_tab1.Location = new Point(301, 13);
            label_size_tab1.Name = "label_size_tab1";
            label_size_tab1.Size = new Size(30, 15);
            label_size_tab1.TabIndex = 159;
            label_size_tab1.Text = "Size:";
            // 
            // label_procent_reduction_left_tab1
            // 
            label_procent_reduction_left_tab1.AutoSize = true;
            label_procent_reduction_left_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_left_tab1.Location = new Point(125, 43);
            label_procent_reduction_left_tab1.Name = "label_procent_reduction_left_tab1";
            label_procent_reduction_left_tab1.Size = new Size(17, 15);
            label_procent_reduction_left_tab1.TabIndex = 161;
            label_procent_reduction_left_tab1.Text = "%";
            // 
            // button1
            // 
            button1.Location = new Point(763, 10);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(85, 46);
            button1.TabIndex = 166;
            button1.Text = "Generate recursively";
            button1.UseVisualStyleBackColor = true;
            button1.Click += genearte_treeFractal_recursive;
            // 
            // label_reduction_left_tab1
            // 
            label_reduction_left_tab1.AutoSize = true;
            label_reduction_left_tab1.Location = new Point(6, 43);
            label_reduction_left_tab1.Name = "label_reduction_left_tab1";
            label_reduction_left_tab1.Size = new Size(81, 15);
            label_reduction_left_tab1.TabIndex = 160;
            label_reduction_left_tab1.Text = "Left Redution:";
            // 
            // label_levels_tab1
            // 
            label_levels_tab1.AutoSize = true;
            label_levels_tab1.Location = new Point(411, 13);
            label_levels_tab1.Name = "label_levels_tab1";
            label_levels_tab1.Size = new Size(39, 15);
            label_levels_tab1.TabIndex = 157;
            label_levels_tab1.Text = "Levels";
            // 
            // label_width_max_tab1
            // 
            label_width_max_tab1.AutoSize = true;
            label_width_max_tab1.BackColor = SystemColors.ButtonHighlight;
            label_width_max_tab1.Location = new Point(395, 43);
            label_width_max_tab1.Name = "label_width_max_tab1";
            label_width_max_tab1.Size = new Size(24, 15);
            label_width_max_tab1.TabIndex = 155;
            label_width_max_tab1.Text = "<7 ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(500, 13);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 154;
            label5.Text = "<15 ";
            // 
            // label_width_tab1
            // 
            label_width_tab1.AutoSize = true;
            label_width_tab1.Location = new Point(315, 43);
            label_width_tab1.Name = "label_width_tab1";
            label_width_tab1.Size = new Size(42, 15);
            label_width_tab1.TabIndex = 153;
            label_width_tab1.Text = "Width:";
            // 
            // button2
            // 
            button2.Location = new Point(854, 10);
            button2.Name = "button2";
            button2.Size = new Size(90, 46);
            button2.TabIndex = 167;
            button2.Text = "Generate iteratively";
            button2.UseVisualStyleBackColor = true;
            button2.Click += generate_treeFractal_iterative;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(size_KochLine);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(width_KochLine);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(levels_KochLine);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(955, 70);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Koch-Line";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // width_KochLine
            // 
            width_KochLine.Location = new Point(190, 9);
            width_KochLine.Name = "width_KochLine";
            width_KochLine.Size = new Size(40, 23);
            width_KochLine.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 12);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 12);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "<15";
            // 
            // button3
            // 
            button3.Location = new Point(849, 6);
            button3.Name = "button3";
            button3.Size = new Size(100, 55);
            button3.TabIndex = 2;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += generate_kochLineFractal;
            // 
            // levels_KochLine
            // 
            levels_KochLine.Location = new Point(66, 9);
            levels_KochLine.Name = "levels_KochLine";
            levels_KochLine.Size = new Size(38, 23);
            levels_KochLine.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Levels:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 12);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Size:";
            // 
            // size_KochLine
            // 
            size_KochLine.Location = new Point(281, 9);
            size_KochLine.Name = "size_KochLine";
            size_KochLine.Size = new Size(36, 23);
            size_KochLine.TabIndex = 7;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UserControl1";
            Size = new Size(973, 110);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox_angle_left_tab1;
        private TextBox textBox_angle_right_tab1;
        private TextBox textBox_reduction_right_tab1;
        private TextBox textBox_size_tab1;
        private TextBox textBox_reduction_left_tab1;
        private TextBox textBox_levels_tab1;
        private TextBox textBox_width_tab1;
        private Button finalColorSelect_treeFractal_tab1;
        private Button initialColorSelect_treeFractal_tab1;
        private Label label_angle_left_tab1;
        private Label label_procent_reduction_right_tab1;
        private Label label_angle_right_tab1;
        private Label label_reduction_right_tab1;
        private Label label_size_tab1;
        private Label label_procent_reduction_left_tab1;
        private Button button1;
        private Label label_reduction_left_tab1;
        private Label label_levels_tab1;
        private Label label_width_max_tab1;
        private Label label5;
        private Label label_width_tab1;
        private Button button2;
        private TabPage tabPage2;
        private Label label1;
        private TextBox levels_KochLine;
        private Button button3;
        private Label label2;
        private TextBox width_KochLine;
        private Label label3;
        private TextBox size_KochLine;
        private Label label4;
    }
}