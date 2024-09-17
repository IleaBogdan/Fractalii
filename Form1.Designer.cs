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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(12, 59);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 467);
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
            label1.TabIndex = 3;
            label1.Text = "Angle left:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
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
            label3.TabIndex = 6;
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
            button1.TabIndex = 8;
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
            label4.TabIndex = 9;
            label4.Text = "Levels";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(552, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 23);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(585, 9);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "<15 ";
            // 
            // button2
            // 
            button2.Location = new Point(730, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 12;
            button2.Text = "Generate iteratively";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 541);
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
            Cursor = Cursors.SizeAll;
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
    }
}
