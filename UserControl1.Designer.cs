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
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            FlipSierpinski = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            SierpinskiLevels = new System.Windows.Forms.TextBox();
            button5 = new System.Windows.Forms.Button();
            tabPage6 = new TabPage();
            label15 = new Label();
            dragonSize = new System.Windows.Forms.TextBox();
            label14 = new Label();
            label13 = new Label();
            button6 = new System.Windows.Forms.Button();
            dragoncurvetextbox = new System.Windows.Forms.TextBox();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.ItemSize = new Size(90, 20);
            tabControl1.Location = new Point(4, 5);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(15, 4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1051, 191);
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
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(1043, 163);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tree";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_angle_left_tab1
            // 
            textBox_angle_left_tab1.Location = new Point(104, 17);
            textBox_angle_left_tab1.Margin = new Padding(4, 3, 4, 3);
            textBox_angle_left_tab1.Name = "textBox_angle_left_tab1";
            textBox_angle_left_tab1.Size = new Size(97, 31);
            textBox_angle_left_tab1.TabIndex = 146;
            // 
            // textBox_angle_right_tab1
            // 
            textBox_angle_right_tab1.Location = new Point(323, 17);
            textBox_angle_right_tab1.Margin = new Padding(4, 3, 4, 3);
            textBox_angle_right_tab1.Name = "textBox_angle_right_tab1";
            textBox_angle_right_tab1.Size = new Size(97, 31);
            textBox_angle_right_tab1.TabIndex = 147;
            // 
            // textBox_reduction_right_tab1
            // 
            textBox_reduction_right_tab1.Location = new Point(351, 67);
            textBox_reduction_right_tab1.Margin = new Padding(4, 5, 4, 5);
            textBox_reduction_right_tab1.Name = "textBox_reduction_right_tab1";
            textBox_reduction_right_tab1.Size = new Size(28, 31);
            textBox_reduction_right_tab1.TabIndex = 151;
            // 
            // textBox_size_tab1
            // 
            textBox_size_tab1.Location = new Point(481, 17);
            textBox_size_tab1.Margin = new Padding(4, 3, 4, 3);
            textBox_size_tab1.Name = "textBox_size_tab1";
            textBox_size_tab1.Size = new Size(95, 31);
            textBox_size_tab1.TabIndex = 148;
            // 
            // textBox_reduction_left_tab1
            // 
            textBox_reduction_left_tab1.Location = new Point(133, 67);
            textBox_reduction_left_tab1.Margin = new Padding(4, 5, 4, 5);
            textBox_reduction_left_tab1.Name = "textBox_reduction_left_tab1";
            textBox_reduction_left_tab1.Size = new Size(35, 31);
            textBox_reduction_left_tab1.TabIndex = 150;
            // 
            // textBox_levels_tab1
            // 
            textBox_levels_tab1.Location = new Point(651, 17);
            textBox_levels_tab1.Margin = new Padding(4, 5, 4, 5);
            textBox_levels_tab1.Name = "textBox_levels_tab1";
            textBox_levels_tab1.Size = new Size(53, 31);
            textBox_levels_tab1.TabIndex = 149;
            // 
            // textBox_width_tab1
            // 
            textBox_width_tab1.Location = new Point(519, 67);
            textBox_width_tab1.Margin = new Padding(4, 5, 4, 5);
            textBox_width_tab1.Name = "textBox_width_tab1";
            textBox_width_tab1.Size = new Size(35, 31);
            textBox_width_tab1.TabIndex = 152;
            // 
            // label_angle_left_tab1
            // 
            label_angle_left_tab1.AutoSize = true;
            label_angle_left_tab1.Location = new Point(9, 22);
            label_angle_left_tab1.Margin = new Padding(4, 0, 4, 0);
            label_angle_left_tab1.Name = "label_angle_left_tab1";
            label_angle_left_tab1.Size = new Size(92, 25);
            label_angle_left_tab1.TabIndex = 156;
            label_angle_left_tab1.Text = "Angle left:";
            // 
            // label_procent_reduction_right_tab1
            // 
            label_procent_reduction_right_tab1.AutoSize = true;
            label_procent_reduction_right_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_right_tab1.Location = new Point(397, 72);
            label_procent_reduction_right_tab1.Margin = new Padding(4, 0, 4, 0);
            label_procent_reduction_right_tab1.Name = "label_procent_reduction_right_tab1";
            label_procent_reduction_right_tab1.Size = new Size(27, 25);
            label_procent_reduction_right_tab1.TabIndex = 163;
            label_procent_reduction_right_tab1.Text = "%";
            // 
            // label_angle_right_tab1
            // 
            label_angle_right_tab1.AutoSize = true;
            label_angle_right_tab1.Location = new Point(216, 22);
            label_angle_right_tab1.Margin = new Padding(4, 0, 4, 0);
            label_angle_right_tab1.Name = "label_angle_right_tab1";
            label_angle_right_tab1.Size = new Size(104, 25);
            label_angle_right_tab1.TabIndex = 158;
            label_angle_right_tab1.Text = "Angle right:";
            // 
            // label_reduction_right_tab1
            // 
            label_reduction_right_tab1.AutoSize = true;
            label_reduction_right_tab1.Location = new Point(216, 72);
            label_reduction_right_tab1.Margin = new Padding(4, 0, 4, 0);
            label_reduction_right_tab1.Name = "label_reduction_right_tab1";
            label_reduction_right_tab1.Size = new Size(134, 25);
            label_reduction_right_tab1.TabIndex = 162;
            label_reduction_right_tab1.Text = "Right Redution:";
            // 
            // label_size_tab1
            // 
            label_size_tab1.AutoSize = true;
            label_size_tab1.Location = new Point(430, 22);
            label_size_tab1.Margin = new Padding(4, 0, 4, 0);
            label_size_tab1.Name = "label_size_tab1";
            label_size_tab1.Size = new Size(47, 25);
            label_size_tab1.TabIndex = 159;
            label_size_tab1.Text = "Size:";
            // 
            // label_procent_reduction_left_tab1
            // 
            label_procent_reduction_left_tab1.AutoSize = true;
            label_procent_reduction_left_tab1.BackColor = SystemColors.ButtonHighlight;
            label_procent_reduction_left_tab1.Location = new Point(179, 72);
            label_procent_reduction_left_tab1.Margin = new Padding(4, 0, 4, 0);
            label_procent_reduction_left_tab1.Name = "label_procent_reduction_left_tab1";
            label_procent_reduction_left_tab1.Size = new Size(27, 25);
            label_procent_reduction_left_tab1.TabIndex = 161;
            label_procent_reduction_left_tab1.Text = "%";
            // 
            // button1
            // 
            button1.Location = new Point(766, 17);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(121, 77);
            button1.TabIndex = 166;
            button1.Text = "Generate recursively";
            button1.UseVisualStyleBackColor = true;
            button1.Click += generate_treeFractal_recursive;
            // 
            // label_reduction_left_tab1
            // 
            label_reduction_left_tab1.AutoSize = true;
            label_reduction_left_tab1.Location = new Point(9, 72);
            label_reduction_left_tab1.Margin = new Padding(4, 0, 4, 0);
            label_reduction_left_tab1.Name = "label_reduction_left_tab1";
            label_reduction_left_tab1.Size = new Size(121, 25);
            label_reduction_left_tab1.TabIndex = 160;
            label_reduction_left_tab1.Text = "Left Redution:";
            // 
            // label_levels_tab1
            // 
            label_levels_tab1.AutoSize = true;
            label_levels_tab1.Location = new Point(587, 22);
            label_levels_tab1.Margin = new Padding(4, 0, 4, 0);
            label_levels_tab1.Name = "label_levels_tab1";
            label_levels_tab1.Size = new Size(59, 25);
            label_levels_tab1.TabIndex = 157;
            label_levels_tab1.Text = "Levels";
            // 
            // label_width_max_tab1
            // 
            label_width_max_tab1.AutoSize = true;
            label_width_max_tab1.BackColor = SystemColors.ButtonHighlight;
            label_width_max_tab1.Location = new Point(564, 72);
            label_width_max_tab1.Margin = new Padding(4, 0, 4, 0);
            label_width_max_tab1.Name = "label_width_max_tab1";
            label_width_max_tab1.Size = new Size(39, 25);
            label_width_max_tab1.TabIndex = 155;
            label_width_max_tab1.Text = "<7 ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(714, 22);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 154;
            label5.Text = "<15 ";
            // 
            // label_width_tab1
            // 
            label_width_tab1.AutoSize = true;
            label_width_tab1.Location = new Point(450, 72);
            label_width_tab1.Margin = new Padding(4, 0, 4, 0);
            label_width_tab1.Name = "label_width_tab1";
            label_width_tab1.Size = new Size(64, 25);
            label_width_tab1.TabIndex = 153;
            label_width_tab1.Text = "Width:";
            // 
            // button2
            // 
            button2.Location = new Point(896, 17);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(129, 77);
            button2.TabIndex = 167;
            button2.Text = "Generate iteratively";
            button2.UseVisualStyleBackColor = true;
            button2.Click += generate_treeFractal_iterative;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(width_KochLine);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(levels_KochLine);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1043, 163);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Koch-Line";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // width_KochLine
            // 
            width_KochLine.Location = new Point(290, 17);
            width_KochLine.Margin = new Padding(4, 5, 4, 5);
            width_KochLine.Name = "width_KochLine";
            width_KochLine.Size = new Size(55, 31);
            width_KochLine.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 4;
            label3.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 3;
            label2.Text = "<8";
            // 
            // button3
            // 
            button3.Location = new Point(876, 15);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(143, 92);
            button3.TabIndex = 2;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += generate_kochLineFractal;
            // 
            // levels_KochLine
            // 
            levels_KochLine.Location = new Point(113, 17);
            levels_KochLine.Margin = new Padding(4, 5, 4, 5);
            levels_KochLine.Name = "levels_KochLine";
            levels_KochLine.Size = new Size(53, 31);
            levels_KochLine.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
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
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(1043, 135);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Koch-Snowflake";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // KochSnowWidth
            // 
            KochSnowWidth.Location = new Point(281, 13);
            KochSnowWidth.Margin = new Padding(4, 5, 4, 5);
            KochSnowWidth.Name = "KochSnowWidth";
            KochSnowWidth.Size = new Size(55, 31);
            KochSnowWidth.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 10;
            label4.Text = "Width:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 20);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 9;
            label6.Text = "<8";
            // 
            // button4
            // 
            button4.Location = new Point(867, 13);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(143, 92);
            button4.TabIndex = 8;
            button4.Text = "Generate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += generate_kochSnowFractal;
            // 
            // KochSnowLevels
            // 
            KochSnowLevels.Location = new Point(104, 17);
            KochSnowLevels.Margin = new Padding(4, 5, 4, 5);
            KochSnowLevels.Name = "KochSnowLevels";
            KochSnowLevels.Size = new Size(53, 31);
            KochSnowLevels.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 6;
            label7.Text = "Levels:";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(4, 5, 4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4, 5, 4, 5);
            tabPage4.Size = new Size(1043, 135);
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
            tabPage5.Margin = new Padding(4, 5, 4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(4, 5, 4, 5);
            tabPage5.Size = new Size(1043, 135);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Sierpinski";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // FlipSierpinski
            // 
            FlipSierpinski.AutoSize = true;
            FlipSierpinski.Location = new Point(609, 23);
            FlipSierpinski.Margin = new Padding(4, 3, 4, 3);
            FlipSierpinski.Name = "FlipSierpinski";
            FlipSierpinski.Size = new Size(66, 29);
            FlipSierpinski.TabIndex = 5;
            FlipSierpinski.Text = "Flip";
            FlipSierpinski.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(334, 27);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(44, 25);
            label11.TabIndex = 4;
            label11.Text = "<15";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 27);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 3;
            label10.Text = "Levels:";
            // 
            // SierpinskiLevels
            // 
            SierpinskiLevels.Location = new Point(171, 23);
            SierpinskiLevels.Margin = new Padding(4, 3, 4, 3);
            SierpinskiLevels.Name = "SierpinskiLevels";
            SierpinskiLevels.Size = new Size(155, 31);
            SierpinskiLevels.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(816, 23);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(186, 77);
            button5.TabIndex = 0;
            button5.Text = "Generate";
            button5.UseVisualStyleBackColor = true;
            button5.Click += generate_sierpinski;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label15);
            tabPage6.Controls.Add(dragonSize);
            tabPage6.Controls.Add(label14);
            tabPage6.Controls.Add(label13);
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(dragoncurvetextbox);
            tabPage6.Controls.Add(label12);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Margin = new Padding(4, 3, 4, 3);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(4, 3, 4, 3);
            tabPage6.Size = new Size(1043, 163);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Dragon Curve";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(719, 40);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(44, 25);
            label15.TabIndex = 6;
            label15.Text = "<20";
            // 
            // dragonSize
            // 
            dragonSize.Location = new Point(574, 35);
            dragonSize.Margin = new Padding(4, 3, 4, 3);
            dragonSize.Name = "dragonSize";
            dragonSize.Size = new Size(134, 31);
            dragonSize.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(519, 35);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(47, 25);
            label14.TabIndex = 4;
            label14.Text = "Size:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(359, 40);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(44, 25);
            label13.TabIndex = 3;
            label13.Text = "<16";
            // 
            // button6
            // 
            button6.Location = new Point(869, 25);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(143, 83);
            button6.TabIndex = 2;
            button6.Text = "Generate";
            button6.UseVisualStyleBackColor = true;
            button6.Click += generate_dragoncurve;
            // 
            // dragoncurvetextbox
            // 
            dragoncurvetextbox.Location = new Point(193, 35);
            dragoncurvetextbox.Margin = new Padding(4, 3, 4, 3);
            dragoncurvetextbox.Name = "dragoncurvetextbox";
            dragoncurvetextbox.Size = new Size(155, 31);
            dragoncurvetextbox.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(114, 35);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 25);
            label12.TabIndex = 0;
            label12.Text = "Levels: ";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserControl1";
            Size = new Size(1066, 201);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
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
        private TabPage tabPage4;
        private TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox SierpinskiLevels;
        private Label label10;
        private Label label11;
        private CheckBox FlipSierpinski;
        private System.Windows.Forms.TextBox WeierstrassPrecision;
        private TabPage tabPage6;
        private System.Windows.Forms.TextBox dragoncurvetextbox;
        private Label label12;
        private System.Windows.Forms.Button button6;
        private Label label15;
        private System.Windows.Forms.TextBox dragonSize;
        private Label label14;
        private Label label13;
    }
}
