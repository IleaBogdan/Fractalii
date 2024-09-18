namespace Fractalii
{
    partial class Color_Selector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Color_Selector));
            colorSelectorLabel = new Label();
            pictureBox1 = new PictureBox();
            rgbValuesLb = new Label();
            smallScreenLb = new Label();
            groupBox1 = new GroupBox();
            selectedScreenPnl = new Panel();
            blueValueTbx = new TextBox();
            greenValueTbx = new TextBox();
            redValueTbx = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            closeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // colorSelectorLabel
            // 
            colorSelectorLabel.Dock = DockStyle.Top;
            colorSelectorLabel.Font = new Font("Segoe UI", 20F);
            colorSelectorLabel.Location = new Point(0, 0);
            colorSelectorLabel.Name = "colorSelectorLabel";
            colorSelectorLabel.Size = new Size(382, 43);
            colorSelectorLabel.TabIndex = 0;
            colorSelectorLabel.Text = "Color Selector";
            colorSelectorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // rgbValuesLb
            // 
            rgbValuesLb.BorderStyle = BorderStyle.FixedSingle;
            rgbValuesLb.Font = new Font("Segoe UI", 10F);
            rgbValuesLb.Location = new Point(33, 214);
            rgbValuesLb.Name = "rgbValuesLb";
            rgbValuesLb.Size = new Size(182, 27);
            rgbValuesLb.TabIndex = 2;
            // 
            // smallScreenLb
            // 
            smallScreenLb.BorderStyle = BorderStyle.FixedSingle;
            smallScreenLb.Font = new Font("Segoe UI", 10F);
            smallScreenLb.Location = new Point(252, 214);
            smallScreenLb.Name = "smallScreenLb";
            smallScreenLb.Size = new Size(63, 27);
            smallScreenLb.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectedScreenPnl);
            groupBox1.Controls.Add(blueValueTbx);
            groupBox1.Controls.Add(greenValueTbx);
            groupBox1.Controls.Add(redValueTbx);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 151);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Color";
            // 
            // selectedScreenPnl
            // 
            selectedScreenPnl.Location = new Point(210, 37);
            selectedScreenPnl.Name = "selectedScreenPnl";
            selectedScreenPnl.Size = new Size(142, 103);
            selectedScreenPnl.TabIndex = 6;
            // 
            // blueValueTbx
            // 
            blueValueTbx.Location = new Point(90, 113);
            blueValueTbx.Name = "blueValueTbx";
            blueValueTbx.Size = new Size(99, 27);
            blueValueTbx.TabIndex = 5;
            // 
            // greenValueTbx
            // 
            greenValueTbx.Location = new Point(90, 73);
            greenValueTbx.Name = "greenValueTbx";
            greenValueTbx.Size = new Size(99, 27);
            greenValueTbx.TabIndex = 4;
            // 
            // redValueTbx
            // 
            redValueTbx.Location = new Point(90, 37);
            redValueTbx.Name = "redValueTbx";
            redValueTbx.Size = new Size(99, 27);
            redValueTbx.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 120);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Blue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Green";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Red";
            // 
            // closeBtn
            // 
            closeBtn.DialogResult = DialogResult.OK;
            closeBtn.Location = new Point(144, 417);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 29);
            closeBtn.TabIndex = 5;
            closeBtn.Text = "Apply";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Color_Selector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(closeBtn);
            Controls.Add(groupBox1);
            Controls.Add(smallScreenLb);
            Controls.Add(rgbValuesLb);
            Controls.Add(pictureBox1);
            Controls.Add(colorSelectorLabel);
            Name = "Color_Selector";
            Text = "Color Selector";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label colorSelectorLabel;
        private PictureBox pictureBox1;
        private Label rgbValuesLb;
        private Label smallScreenLb;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox greenValueTbx;
        private TextBox redValueTbx;
        private TextBox blueValueTbx;
        private Panel selectedScreenPnl;
        private Button closeBtn;
    }
}