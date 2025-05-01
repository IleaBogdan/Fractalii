using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        /*public void debug()
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


                // tab2 (kochLineFractal) default button code:
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


                // tab3 default button code:
                Button default_button3 = new Button();
                tabPage3.Controls.Add(default_button3);
                // 
                // default_button
                // 
                default_button3.Location = new Point(430, 40);
                default_button3.Name = "default_button";
                default_button3.Size = new Size(85, 23);
                default_button3.TabIndex = 13;
                default_button3.Text = "Default";
                default_button3.UseVisualStyleBackColor = true;
                default_button3.Click += default_button_Click_KochSnow;

            }
        }*/
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox_angle_left_tab1 = new System.Windows.Forms.TextBox();
            textBox_angle_right_tab1 = new System.Windows.Forms.TextBox();
            textBox_reduction_right_tab1 = new System.Windows.Forms.TextBox();
            textBox_size_tab1 = new System.Windows.Forms.TextBox();
            textBox_reduction_left_tab1 = new System.Windows.Forms.TextBox();
            textBox_levels_tab1 = new System.Windows.Forms.TextBox();
            textBox_width_tab1 = new System.Windows.Forms.TextBox();
            label_angle_left_tab1 = new Label();
            label_procent_reduction_right_tab1 = new Label();
            label_angle_right_tab1 = new Label();
            label_reduction_right_tab1 = new Label();
            label_size_tab1 = new Label();
            label_procent_reduction_left_tab1 = new Label();
            button1 = new System.Windows.Forms.Button();
            label_reduction_left_tab1 = new Label();
            label_levels_tab1 = new Label();
            label_width_max_tab1 = new Label();
            label5 = new Label();
            label_width_tab1 = new Label();
            button2 = new System.Windows.Forms.Button();
            tabPage2 = new TabPage();
            label8 = new Label();
            textBox1 = new System.Windows.Forms.TextBox();
            width_KochLine = new System.Windows.Forms.TextBox();
            label3 = new Label();
            label2 = new Label();
            button3 = new System.Windows.Forms.Button();
            levels_KochLine = new System.Windows.Forms.TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            KochSnowWidth = new System.Windows.Forms.TextBox();
            label4 = new Label();
            label6 = new Label();
            button4 = new System.Windows.Forms.Button();
            KochSnowLevels = new System.Windows.Forms.TextBox();
            label7 = new Label();
            label9 = new Label();
            textBox2 = new System.Windows.Forms.TextBox();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            FlipSierpinski = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            SierpinskiLevels = new System.Windows.Forms.TextBox();
            button5 = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.ItemSize = new Size(90, 20);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(15, 4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(841, 131);
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
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(833, 103);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tree";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_angle_left_tab1
            // 
            textBox_angle_left_tab1.Location = new Point(83, 13);
            textBox_angle_left_tab1.Name = "textBox_angle_left_tab1";
            textBox_angle_left_tab1.Size = new Size(78, 27);
            textBox_angle_left_tab1.TabIndex = 146;
            // 
            // textBox_angle_right_tab1
            // 
            textBox_angle_right_tab1.Location = new Point(258, 13);
            textBox_angle_right_tab1.Name = "textBox_angle_right_tab1";
            textBox_angle_right_tab1.Size = new Size(78, 27);
            textBox_angle_right_tab1.TabIndex = 147;
            // 
            // textBox_reduction_right_tab1
            // 
            textBox_reduction_right_tab1.Location = new Point(281, 53);
            textBox_reduction_right_tab1.Margin = new Padding(3, 4, 3, 4);
            textBox_reduction_right_tab1.Name = "textBox_reduction_right_tab1";
            textBox_reduction_right_tab1.Size = new Size(23, 27);
            textBox_reduction_right_tab1.TabIndex = 151;
            // 
            // textBox_size_tab1
            // 
            textBox_size_tab1.Location = new Point(385, 13);
            textBox_size_tab1.Name = "textBox_size_tab1";
            textBox_size_tab1.Size = new Size(77, 27);
            textBox_size_tab1.TabIndex = 148;
            // 
            // textBox_reduction_left_tab1
            // 
            textBox_reduction_left_tab1.Location = new Point(106, 53);
            textBox_reduction_left_tab1.Margin = new Padding(3, 4, 3, 4);
            textBox_reduction_left_tab1.Name = "textBox_reduction_left_tab1";
            textBox_reduction_left_tab1.Size = new Size(29, 27);
            textBox_reduction_left_tab1.TabIndex = 150;
            // 
            // textBox_levels_tab1
            // 
            textBox_levels_tab1.Location = new Point(521, 13);
            textBox_levels_tab1.Margin = new Padding(3, 4, 3, 4);
            textBox_levels_tab1.Name = "textBox_levels_tab1";
            textBox_levels_tab1.Size = new Size(43, 27);
            textBox_levels_tab1.TabIndex = 149;
            // 
            // textBox_width_tab1
            // 
            textBox_width_tab1.Location = new Point(415, 53);
            textBox_width_tab1.Margin = new Padding(3, 4, 3, 4);
            textBox_width_tab1.Name = "textBox_width_tab1";
            textBox_width_tab1.Size = new Size(29, 27);
            textBox_width_tab1.TabIndex = 152;
            // 
            // label_angle_left_tab1
            // 
            label_angle_left_tab1.AutoSize = true;
            label_angle_left_tab1.Location = new Point(7, 17);
            label_angle_left_tab1.Name = "label_angle_left_tab1";
            label_angle_left_tab1.Size = new Size(77, 20);
            label_angle_left_tab1.TabIndex = 156;
            label_angle_left_tab1.Text = "Angle left:";
            // 
            // label_procent_reduction_right_tab1
            // 
            label_procent_reduction_right_tab1.AutoSize = true;
            label_procent_reduction_right_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_right_tab1.Location = new Point(318, 57);
            label_procent_reduction_right_tab1.Name = "label_procent_reduction_right_tab1";
            label_procent_reduction_right_tab1.Size = new Size(21, 20);
            label_procent_reduction_right_tab1.TabIndex = 163;
            label_procent_reduction_right_tab1.Text = "%";
            // 
            // label_angle_right_tab1
            // 
            label_angle_right_tab1.AutoSize = true;
            label_angle_right_tab1.Location = new Point(173, 17);
            label_angle_right_tab1.Name = "label_angle_right_tab1";
            label_angle_right_tab1.Size = new Size(86, 20);
            label_angle_right_tab1.TabIndex = 158;
            label_angle_right_tab1.Text = "Angle right:";
            // 
            // label_reduction_right_tab1
            // 
            label_reduction_right_tab1.AutoSize = true;
            label_reduction_right_tab1.Location = new Point(173, 57);
            label_reduction_right_tab1.Name = "label_reduction_right_tab1";
            label_reduction_right_tab1.Size = new Size(111, 20);
            label_reduction_right_tab1.TabIndex = 162;
            label_reduction_right_tab1.Text = "Right Redution:";
            // 
            // label_size_tab1
            // 
            label_size_tab1.AutoSize = true;
            label_size_tab1.Location = new Point(344, 17);
            label_size_tab1.Name = "label_size_tab1";
            label_size_tab1.Size = new Size(39, 20);
            label_size_tab1.TabIndex = 159;
            label_size_tab1.Text = "Size:";
            // 
            // label_procent_reduction_left_tab1
            // 
            label_procent_reduction_left_tab1.AutoSize = true;
            label_procent_reduction_left_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_left_tab1.Location = new Point(143, 57);
            label_procent_reduction_left_tab1.Name = "label_procent_reduction_left_tab1";
            label_procent_reduction_left_tab1.Size = new Size(21, 20);
            label_procent_reduction_left_tab1.TabIndex = 161;
            label_procent_reduction_left_tab1.Text = "%";
            // 
            // button1
            // 
            button1.Location = new Point(613, 13);
            button1.Name = "button1";
            button1.Size = new Size(97, 61);
            button1.TabIndex = 166;
            button1.Text = "Generate recursively";
            button1.UseVisualStyleBackColor = true;
            button1.Click += generate_treeFractal_recursive;
            // 
            // label_reduction_left_tab1
            // 
            label_reduction_left_tab1.AutoSize = true;
            label_reduction_left_tab1.Location = new Point(7, 57);
            label_reduction_left_tab1.Name = "label_reduction_left_tab1";
            label_reduction_left_tab1.Size = new Size(101, 20);
            label_reduction_left_tab1.TabIndex = 160;
            label_reduction_left_tab1.Text = "Left Redution:";
            // 
            // label_levels_tab1
            // 
            label_levels_tab1.AutoSize = true;
            label_levels_tab1.Location = new Point(470, 17);
            label_levels_tab1.Name = "label_levels_tab1";
            label_levels_tab1.Size = new Size(49, 20);
            label_levels_tab1.TabIndex = 157;
            label_levels_tab1.Text = "Levels";
            // 
            // label_width_max_tab1
            // 
            label_width_max_tab1.AutoSize = true;
            label_width_max_tab1.BackColor = SystemColors.ButtonHighlight;
            label_width_max_tab1.Location = new Point(451, 57);
            label_width_max_tab1.Name = "label_width_max_tab1";
            label_width_max_tab1.Size = new Size(31, 20);
            label_width_max_tab1.TabIndex = 155;
            label_width_max_tab1.Text = "<7 ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(571, 17);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 154;
            label5.Text = "<15 ";
            // 
            // label_width_tab1
            // 
            label_width_tab1.AutoSize = true;
            label_width_tab1.Location = new Point(360, 57);
            label_width_tab1.Name = "label_width_tab1";
            label_width_tab1.Size = new Size(52, 20);
            label_width_tab1.TabIndex = 153;
            label_width_tab1.Text = "Width:";
            // 
            // button2
            // 
            button2.Location = new Point(717, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(103, 61);
            button2.TabIndex = 167;
            button2.Text = "Generate iteratively";
            button2.UseVisualStyleBackColor = true;
            button2.Click += generate_treeFractal_iterative;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(width_KochLine);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(levels_KochLine);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(833, 103);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Koch-Line";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(311, 16);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 7;
            label8.Text = "Reduction:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 13);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 27);
            textBox1.TabIndex = 6;
            // 
            // width_KochLine
            // 
            width_KochLine.Location = new Point(232, 13);
            width_KochLine.Margin = new Padding(3, 4, 3, 4);
            width_KochLine.Name = "width_KochLine";
            width_KochLine.Size = new Size(45, 27);
            width_KochLine.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 16);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 16);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 3;
            label2.Text = "<8";
            // 
            // button3
            // 
            button3.Location = new Point(701, 12);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(114, 73);
            button3.TabIndex = 2;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += generate_kochLineFractal;
            // 
            // levels_KochLine
            // 
            levels_KochLine.Location = new Point(90, 13);
            levels_KochLine.Margin = new Padding(3, 4, 3, 4);
            levels_KochLine.Name = "levels_KochLine";
            levels_KochLine.Size = new Size(43, 27);
            levels_KochLine.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Levels:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(KochSnowWidth);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(KochSnowLevels);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(833, 103);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Koch-Snowflake";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // KochSnowWidth
            // 
            KochSnowWidth.Location = new Point(225, 11);
            KochSnowWidth.Margin = new Padding(3, 4, 3, 4);
            KochSnowWidth.Name = "KochSnowWidth";
            KochSnowWidth.Size = new Size(45, 27);
            KochSnowWidth.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 15);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 10;
            label4.Text = "Width:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 16);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 9;
            label6.Text = "<8";
            // 
            // button4
            // 
            button4.Location = new Point(694, 11);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(114, 73);
            button4.TabIndex = 8;
            button4.Text = "Generate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += generate_kochSnowFractal;
            // 
            // KochSnowLevels
            // 
            KochSnowLevels.Location = new Point(83, 13);
            KochSnowLevels.Margin = new Padding(3, 4, 3, 4);
            KochSnowLevels.Name = "KochSnowLevels";
            KochSnowLevels.Size = new Size(43, 27);
            KochSnowLevels.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 15);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 6;
            label7.Text = "Levels:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 16);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 7;
            label9.Text = "Reduction:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(396, 12);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 27);
            textBox2.TabIndex = 6;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(833, 103);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Weierstrass";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(FlipSierpinski);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(SierpinskiLevels);
            tabPage5.Controls.Add(button5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(833, 103);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Sierpinski";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // FlipSierpinski
            // 
            FlipSierpinski.AutoSize = true;
            FlipSierpinski.Location = new Point(487, 18);
            FlipSierpinski.Name = "FlipSierpinski";
            FlipSierpinski.Size = new Size(55, 24);
            FlipSierpinski.TabIndex = 5;
            FlipSierpinski.Text = "Flip";
            FlipSierpinski.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(268, 22);
            label11.Name = "label11";
            label11.Size = new Size(35, 20);
            label11.TabIndex = 4;
            label11.Text = "<15";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(61, 22);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 3;
            label10.Text = "Levels:";
            // 
            // SierpinskiLevels
            // 
            SierpinskiLevels.Location = new Point(137, 19);
            SierpinskiLevels.Name = "SierpinskiLevels";
            SierpinskiLevels.Size = new Size(125, 27);
            SierpinskiLevels.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(653, 19);
            button5.Name = "button5";
            button5.Size = new Size(149, 62);
            button5.TabIndex = 0;
            button5.Text = "Generate";
            button5.UseVisualStyleBackColor = true;
            button5.Click += generate_sierpinski;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl1";
            Size = new Size(853, 147);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_angle_left_tab1;
        private System.Windows.Forms.TextBox textBox_angle_right_tab1;
        private System.Windows.Forms.TextBox textBox_reduction_right_tab1;
        private System.Windows.Forms.TextBox textBox_size_tab1;
        private System.Windows.Forms.TextBox textBox_reduction_left_tab1;
        private System.Windows.Forms.TextBox textBox_levels_tab1;
        private System.Windows.Forms.TextBox textBox_width_tab1;
        private Label label_angle_left_tab1;
        private Label label_procent_reduction_right_tab1;
        private Label label_angle_right_tab1;
        private Label label_reduction_right_tab1;
        private Label label_size_tab1;
        private Label label_procent_reduction_left_tab1;
        private System.Windows.Forms.Button button1;
        private Label label_reduction_left_tab1;
        private Label label_levels_tab1;
        private Label label_width_max_tab1;
        private Label label5;
        private Label label_width_tab1;
        private System.Windows.Forms.Button button2;
        private TabPage tabPage2;
        private Label label1;
        private System.Windows.Forms.TextBox levels_KochLine;
        private System.Windows.Forms.Button button3;
        private Label label2;
        private System.Windows.Forms.TextBox width_KochLine;
        private Label label3;
        private TabPage tabPage3;
        private System.Windows.Forms.TextBox KochSnowWidth;
        private Label label4;
        private Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox KochSnowLevels;
        private Label label7;
        private Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Label label9;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox SierpinskiLevels;
        private Label label10;
        private Label label11;
        private CheckBox FlipSierpinski;
        private System.Windows.Forms.TextBox WeierstrassPrecision;
    }
}
