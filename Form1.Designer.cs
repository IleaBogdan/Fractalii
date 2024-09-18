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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(12, 67);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 459);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 6);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 32;
            label1.Text = "Angle left:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 34;
            label2.Text = "Angle right:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 6);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 9);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 35;
            label3.Text = "Size:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(402, 6);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(99, 23);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(633, 6);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(80, 40);
            button1.TabIndex = 10;
            button1.Text = "Generate recursively";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 9);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 34;
            label4.Text = "Levels";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(552, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(576, 9);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 30;
            label5.Text = "<15 ";
            // 
            // button2
            // 
            button2.Location = new Point(730, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 11;
            button2.Text = "Generate iteratively";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 42);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Width:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(414, 39);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(87, 23);
            textBox5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(466, 42);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 31;
            label7.Text = "<7 ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 39);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 36;
            label8.Text = "Left Redution:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(99, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(80, 23);
            textBox6.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(155, 42);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 38;
            label9.Text = "%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(336, 42);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 41;
            label10.Text = "%";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(280, 36);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(80, 23);
            textBox7.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(185, 39);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 39;
            label11.Text = "Right Redution:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 541);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
