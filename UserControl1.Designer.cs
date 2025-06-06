﻿using System.Diagnostics;
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
            WeierstrassB = new System.Windows.Forms.TextBox();
            WeierstrassA = new System.Windows.Forms.TextBox();
            label18 = new Label();
            label17 = new Label();
            WeierstrassGenerate = new System.Windows.Forms.Button();
            WeierstrassPrecision = new System.Windows.Forms.TextBox();
            label16 = new Label();
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
            SierpinskiCarpet = new TabPage();
            label9 = new Label();
            button7 = new System.Windows.Forms.Button();
            label8 = new Label();
            SierpinskiCarpetTextBox = new System.Windows.Forms.TextBox();
            buttonSierpinskiCarpet = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SierpinskiCarpet.SuspendLayout();
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
            tabControl1.Controls.Add(SierpinskiCarpet);
            tabControl1.ItemSize = new Size(90, 20);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(15, 4);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(736, 115);
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
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(728, 87);
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
            button1.Location = new Point(536, 10);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(85, 46);
            button1.TabIndex = 166;
            button1.Text = "Generate recursively";
            button1.UseVisualStyleBackColor = true;
            button1.Click += generate_treeFractal_recursive;
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
            button2.Location = new Point(627, 10);
            button2.Name = "button2";
            button2.Size = new Size(90, 46);
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
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(728, 87);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Koch-Line";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // width_KochLine
            // 
            width_KochLine.Location = new Point(203, 10);
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
            label2.Location = new Point(122, 12);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 3;
            label2.Text = "<8";
            // 
            // button3
            // 
            button3.Location = new Point(613, 9);
            button3.Name = "button3";
            button3.Size = new Size(100, 55);
            button3.TabIndex = 2;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += generate_kochLineFractal;
            // 
            // levels_KochLine
            // 
            levels_KochLine.Location = new Point(79, 10);
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
            // tabPage3
            // 
            tabPage3.Controls.Add(KochSnowWidth);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(KochSnowLevels);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(728, 87);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Koch-Snowflake";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // KochSnowWidth
            // 
            KochSnowWidth.Location = new Point(197, 8);
            KochSnowWidth.Name = "KochSnowWidth";
            KochSnowWidth.Size = new Size(40, 23);
            KochSnowWidth.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 11);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "Width:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 12);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 9;
            label6.Text = "<8";
            // 
            // button4
            // 
            button4.Location = new Point(607, 8);
            button4.Name = "button4";
            button4.Size = new Size(100, 55);
            button4.TabIndex = 8;
            button4.Text = "Generate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += generate_kochSnowFractal;
            // 
            // KochSnowLevels
            // 
            KochSnowLevels.Location = new Point(73, 10);
            KochSnowLevels.Name = "KochSnowLevels";
            KochSnowLevels.Size = new Size(38, 23);
            KochSnowLevels.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Levels:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(WeierstrassB);
            tabPage4.Controls.Add(WeierstrassA);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(WeierstrassGenerate);
            tabPage4.Controls.Add(WeierstrassPrecision);
            tabPage4.Controls.Add(label16);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(728, 87);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Weierstrass";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // WeierstrassB
            // 
            WeierstrassB.Location = new Point(416, 15);
            WeierstrassB.Margin = new Padding(4, 5, 4, 5);
            WeierstrassB.Name = "WeierstrassB";
            WeierstrassB.Size = new Size(50, 23);
            WeierstrassB.TabIndex = 6;
            // 
            // WeierstrassA
            // 
            WeierstrassA.Location = new Point(256, 15);
            WeierstrassA.Margin = new Padding(4, 5, 4, 5);
            WeierstrassA.Name = "WeierstrassA";
            WeierstrassA.Size = new Size(50, 23);
            WeierstrassA.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(335, 18);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(73, 15);
            label18.TabIndex = 4;
            label18.Text = "Parameter 2:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(175, 18);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(73, 15);
            label17.TabIndex = 3;
            label17.Text = "Parameter 1:";
            // 
            // WeierstrassGenerate
            // 
            WeierstrassGenerate.Location = new Point(867, 13);
            WeierstrassGenerate.Margin = new Padding(4, 5, 4, 5);
            WeierstrassGenerate.Name = "WeierstrassGenerate";
            WeierstrassGenerate.Size = new Size(143, 92);
            WeierstrassGenerate.TabIndex = 2;
            WeierstrassGenerate.Text = "Generate";
            WeierstrassGenerate.UseVisualStyleBackColor = true;
            WeierstrassGenerate.Click += CallWeierstrass;
            // 
            // WeierstrassPrecision
            // 
            WeierstrassPrecision.Location = new Point(97, 15);
            WeierstrassPrecision.Margin = new Padding(4, 5, 4, 5);
            WeierstrassPrecision.Name = "WeierstrassPrecision";
            WeierstrassPrecision.Size = new Size(50, 23);
            WeierstrassPrecision.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(31, 18);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(58, 15);
            label16.TabIndex = 0;
            label16.Text = "Precision:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(FlipSierpinski);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(SierpinskiLevels);
            tabPage5.Controls.Add(button5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(728, 87);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Sierpinski";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // FlipSierpinski
            // 
            FlipSierpinski.AutoSize = true;
            FlipSierpinski.Location = new Point(426, 14);
            FlipSierpinski.Margin = new Padding(3, 2, 3, 2);
            FlipSierpinski.Name = "FlipSierpinski";
            FlipSierpinski.Size = new Size(45, 19);
            FlipSierpinski.TabIndex = 5;
            FlipSierpinski.Text = "Flip";
            FlipSierpinski.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(234, 16);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 4;
            label11.Text = "<15";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 16);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 3;
            label10.Text = "Levels:";
            // 
            // SierpinskiLevels
            // 
            SierpinskiLevels.Location = new Point(120, 14);
            SierpinskiLevels.Margin = new Padding(3, 2, 3, 2);
            SierpinskiLevels.Name = "SierpinskiLevels";
            SierpinskiLevels.Size = new Size(110, 23);
            SierpinskiLevels.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(571, 14);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(130, 46);
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
            tabPage6.Margin = new Padding(3, 2, 3, 2);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 2, 3, 2);
            tabPage6.Size = new Size(728, 87);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Dragon Curve";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(503, 24);
            label15.Name = "label15";
            label15.Size = new Size(27, 15);
            label15.TabIndex = 6;
            label15.Text = "<20";
            // 
            // dragonSize
            // 
            dragonSize.Location = new Point(402, 21);
            dragonSize.Margin = new Padding(3, 2, 3, 2);
            dragonSize.Name = "dragonSize";
            dragonSize.Size = new Size(95, 23);
            dragonSize.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(363, 21);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 4;
            label14.Text = "Size:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(251, 24);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 3;
            label13.Text = "<16";
            // 
            // button6
            // 
            button6.Location = new Point(608, 15);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(100, 50);
            button6.TabIndex = 2;
            button6.Text = "Generate";
            button6.UseVisualStyleBackColor = true;
            button6.Click += generate_dragoncurve;
            // 
            // dragoncurvetextbox
            // 
            dragoncurvetextbox.Location = new Point(135, 21);
            dragoncurvetextbox.Margin = new Padding(3, 2, 3, 2);
            dragoncurvetextbox.Name = "dragoncurvetextbox";
            dragoncurvetextbox.Size = new Size(110, 23);
            dragoncurvetextbox.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(80, 21);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 0;
            label12.Text = "Levels: ";
            // 
            // SierpinskiCarpet
            // 
            SierpinskiCarpet.Controls.Add(label9);
            SierpinskiCarpet.Controls.Add(button7);
            SierpinskiCarpet.Controls.Add(label8);
            SierpinskiCarpet.Controls.Add(SierpinskiCarpetTextBox);
            SierpinskiCarpet.Location = new Point(4, 24);
            SierpinskiCarpet.Name = "SierpinskiCarpet";
            SierpinskiCarpet.Padding = new Padding(3);
            SierpinskiCarpet.Size = new Size(728, 87);
            SierpinskiCarpet.TabIndex = 6;
            SierpinskiCarpet.Text = "Sierpinski Carpet";
            SierpinskiCarpet.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(179, 31);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 3;
            label9.Text = "<=~6";
            // 
            // button7
            // 
            button7.Location = new Point(595, 12);
            button7.Name = "button7";
            button7.Size = new Size(107, 53);
            button7.TabIndex = 2;
            button7.Text = "Generate";
            button7.UseVisualStyleBackColor = true;
            button7.Click += generate_sierpinskicarpet;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 31);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 1;
            label8.Text = "Levels:";
            // 
            // SierpinskiCarpetTextBox
            // 
            SierpinskiCarpetTextBox.Location = new Point(73, 28);
            SierpinskiCarpetTextBox.Name = "SierpinskiCarpetTextBox";
            SierpinskiCarpetTextBox.Size = new Size(100, 23);
            SierpinskiCarpetTextBox.TabIndex = 0;
            // 
            // buttonSierpinskiCarpet
            // 
            buttonSierpinskiCarpet.Location = new Point(0, 0);
            buttonSierpinskiCarpet.Name = "buttonSierpinskiCarpet";
            buttonSierpinskiCarpet.Size = new Size(75, 23);
            buttonSierpinskiCarpet.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new Point(608, 15);
            button8.Name = "button8";
            button8.Size = new Size(100, 55);
            button8.TabIndex = 7;
            button8.Text = "Generate";
            button8.UseVisualStyleBackColor = true;
            button8.Click += CallWeierstrass;
            // 
            // button9
            // 
            button9.Location = new Point(53, 47);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 8;
            button9.Text = "N Oscillate";
            button9.UseVisualStyleBackColor = true;
            button9.Click += CallNOscillate;
            // 
            // button10
            // 
            button10.Location = new Point(202, 47);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 9;
            button10.Text = "A Oscillate";
            button10.UseVisualStyleBackColor = true;
            button10.Click += CallAOscillate;
            // 
            // button11
            // 
            button11.Location = new Point(361, 47);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 10;
            button11.Text = "B Oscillate";
            button11.UseVisualStyleBackColor = true;
            button11.Click += CallBOscillate;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UserControl1";
            Size = new Size(746, 121);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            SierpinskiCarpet.ResumeLayout(false);
            SierpinskiCarpet.PerformLayout();
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
        private TabPage tabPage6;
        private System.Windows.Forms.TextBox dragoncurvetextbox;
        private Label label12;
        private System.Windows.Forms.Button button6;
        private Label label15;
        private System.Windows.Forms.TextBox dragonSize;
        private Label label14;
        private Label label13;
        private TabPage SierpinskiCarpet;
        private System.Windows.Forms.TextBox SierpinskiCarpetTextBox;
        private System.Windows.Forms.Button button7;
        private Label label8;
        private Label label9;
        private System.Windows.Forms.Button WeierstrassGenerate;
        private System.Windows.Forms.TextBox WeierstrassPrecision;
        private Label label16;
        private System.Windows.Forms.TextBox WeierstrassB;
        private System.Windows.Forms.TextBox WeierstrassA;
        private Label label18;
        private Label label17;
        private System.Windows.Forms.Button buttonSierpinskiCarpet;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}
