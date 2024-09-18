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
                Controls.Add(default_button);
                // 
                // button3
                // 
                default_button.Location = new Point(540, 35);
                default_button.Name = "default_button";
                default_button.Size = new Size(75, 23);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(14, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1115, 647);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 32;
            label1.Text = "Angle left:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 12);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 34;
            label2.Text = "Angle right:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(297, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 12);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 35;
            label3.Text = "Size:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(459, 8);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 27);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(946, 8);
            button1.Name = "button1";
            button1.Size = new Size(91, 53);
            button1.TabIndex = 10;
            button1.Text = "Generate recursively";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 12);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 34;
            label4.Text = "Levels";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(631, 8);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(71, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(658, 12);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 30;
            label5.Text = "<15 ";
            // 
            // button2
            // 
            button2.Location = new Point(1043, 8);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 53);
            button2.TabIndex = 11;
            button2.Text = "Generate iteratively";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 56);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 13;
            label6.Text = "Width:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(473, 52);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(99, 27);
            textBox5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(533, 56);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 31;
            label7.Text = "<7 ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 52);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 36;
            label8.Text = "Left Redution:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(113, 48);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(91, 27);
            textBox6.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(177, 56);
            label9.Name = "label9";
            label9.Size = new Size(21, 20);
            label9.TabIndex = 38;
            label9.Text = "%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(384, 56);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 41;
            label10.Text = "%";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(320, 48);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(91, 27);
            textBox7.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(211, 52);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 39;
            label11.Text = "Right Redution:";
            // 
            // initialColorSelect
            // 
            initialColorSelect.Location = new Point(722, 8);
            initialColorSelect.Name = "initialColorSelect";
            initialColorSelect.Size = new Size(100, 71);
            initialColorSelect.TabIndex = 42;
            initialColorSelect.Text = "Select initial color";
            initialColorSelect.UseVisualStyleBackColor = true;
            initialColorSelect.Click += initialColorSelect_Click;
            // 
            // finalColorSelect
            // 
            finalColorSelect.Location = new Point(828, 8);
            finalColorSelect.Name = "finalColorSelect";
            finalColorSelect.Size = new Size(100, 71);
            finalColorSelect.TabIndex = 43;
            finalColorSelect.Text = "Select final color";
            finalColorSelect.UseVisualStyleBackColor = true;
            finalColorSelect.Click += finalColorSelect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 756);
            Controls.Add(finalColorSelect);
            Controls.Add(initialColorSelect);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fractal Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
