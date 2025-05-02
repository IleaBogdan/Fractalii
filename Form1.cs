using Fractalii.TreeFractal;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Windows.Forms;

namespace Fractalii
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            if (Debugger.IsAttached) { AllocConsole(); }
            this.Text = "Fractalii";
            this.KeyPreview = true; // Important to capture key events
            this.TopMost=false;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }
        public void SetText(string text)
        {
            this.Text = text;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public static Color bgC = Color.Black;
        public static String def = "Fractalii";

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = bgC;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle; 
            userControl11.set_pictureBox(pictureBox1);
            add_color(initialColor, initialColorSelect, "Select initial color");
            add_color(finalColor, finalColorSelect, "Select final color");

            //userControl11.SetSelectedTab(0, this, userControl11);

            pictureBox1.Paint += (s, args) =>
            {
                ControlPaint.DrawBorder(args.Graphics, pictureBox1.ClientRectangle,
                    Color.Green, 1, ButtonBorderStyle.Solid, // Left
                    Color.Green, 1, ButtonBorderStyle.Solid, // Top
                    Color.Green, 1, ButtonBorderStyle.Solid, // Right
                    Color.Green, 1, ButtonBorderStyle.Solid  // Bottom
                );
            };
        }
        // color setting
        public static Color initialColor = Color.Blue, finalColor = Color.Green;


        private static void add_color(Color color, Button b1, String text)
        {
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(new SolidBrush(color), 0, 0, 16, 16);
                g.DrawRectangle(Pens.Black, 0, 0, 15, 15);
            }

            b1.Image = bmp;
            b1.TextImageRelation = TextImageRelation.TextAboveImage;
            b1.TextAlign = ContentAlignment.MiddleCenter;
            b1.ImageAlign = ContentAlignment.MiddleCenter;
            b1.Text = text;
            b1.Tag = initialColor;
        }
        private void initialColorSelect_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                initialColor = colorSelector.setColor;
                add_color(initialColor, initialColorSelect, "Select initial color");
            }
        }
        private void finalColorSelect_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                finalColor = colorSelector.setColor;
                add_color(finalColor, finalColorSelect, "Select final color");
            }
        }

        private void pictureBox1_2Click(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            UserControl1.default_pressed(sender, e, userControl11);
            //Console.WriteLine("Boom");
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11) { ToggleFullscreen(); }
            if (e.KeyCode == Keys.F5)
            {
                // generate fractal
                UserControl1.Generate(sender, e, userControl11);
            }
            if (e.KeyCode == Keys.D) { UserControl1.default_pressed(sender, e, userControl11); }
            if (e.Control && e.KeyCode>=Keys.D0 && e.KeyCode <= Keys.D9)
            {
                // switch to specific tab
                int tab = (int)(e.KeyCode-'0')-1;
                if (tab == -1) { tab += 10; }
                //Console.WriteLine(tab.ToString());
                userControl11.SetSelectedTab(tab);
            }
        }

        private void ToggleFullscreen()
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = false;
            }
        }
        private void DarkMode_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null && checkBox.Checked)
            {
                ApplyTheme(this, Color.Black, Color.White);
            }
            else
            {
                ApplyTheme(this, Color.White, Color.Black);
            }
        }
        private void ApplyTheme(Control parent, Color backColor, Color foreColor)
        {
            if (parent is PictureBox)return;

            parent.BackColor = backColor;
            parent.ForeColor = foreColor;

            foreach (Control control in parent.Controls)
            {
                ApplyTheme(control, backColor, foreColor);
                if (control is TextBox || control is Label || control is Button)
                {
                    control.ForeColor = foreColor;
                    control.BackColor = backColor;
                }
            }
        }
    }
}