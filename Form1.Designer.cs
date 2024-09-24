using System;
using System.Diagnostics;
using System.Drawing.Text;

namespace Fractalii
{
    partial class Form1
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
                default_button.Click += default_button_Click;
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            initialColorSelect = new Button();
            finalColorSelect = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(14, 81);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(968, 442);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 18);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 32;
            label1.Text = "Angle left:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 34;
            label2.Text = "Angle right:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 18);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 21);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 35;
            label3.Text = "Size:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(396, 18);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(99, 23);
            textBox3.TabIndex = 7;
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
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 21);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 34;
            label4.Text = "Levels";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(546, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 23);
            textBox4.TabIndex = 8;
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
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 54);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Width:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(408, 51);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(87, 23);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(460, 54);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 31;
            label7.Text = "<7 ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 51);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 36;
            label8.Text = "Left Redution:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(93, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(80, 23);
            textBox6.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(149, 54);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 38;
            label9.Text = "%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(330, 54);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 41;
            label10.Text = "%";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(274, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(80, 23);
            textBox7.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(179, 51);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 39;
            label11.Text = "Right Redution:";
            // 
            // initialColorSelect
            // 
            initialColorSelect.Location = new Point(626, 18);
            initialColorSelect.Margin = new Padding(3, 2, 3, 2);
            initialColorSelect.Name = "initialColorSelect";
            initialColorSelect.Size = new Size(88, 53);
            initialColorSelect.TabIndex = 42;
            initialColorSelect.Text = "Select initial color";
            initialColorSelect.UseVisualStyleBackColor = true;
            initialColorSelect.Click += initialColorSelect_Click;
            // 
            // finalColorSelect
            // 
            finalColorSelect.Location = new Point(718, 18);
            finalColorSelect.Margin = new Padding(3, 2, 3, 2);
            finalColorSelect.Name = "finalColorSelect";
            finalColorSelect.Size = new Size(88, 53);
            finalColorSelect.TabIndex = 43;
            finalColorSelect.Text = "Select final color";
            finalColorSelect.UseVisualStyleBackColor = true;
            finalColorSelect.Click += finalColorSelect_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(999, 565);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 102;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(finalColorSelect);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(initialColorSelect);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
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
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 567);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractal Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private Button initialColorSelect;
        private Button finalColorSelect;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
