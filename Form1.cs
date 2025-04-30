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
            this.Text = "Fullscreen on F11 Example";
            this.KeyPreview = true; // Important to capture key events

            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public static Color bgC = Color.Black;


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = bgC;
            userControl11.set_pictureBox(pictureBox1);
        }
        // color setting
        public static Color initialColor = Color.Blue, finalColor = Color.Green;
        private void initialColorSelect_Click(object sender, EventArgs e)
        {
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                initialColor = colorSelector.setColor;
            }
        }
        private void finalColorSelect_Click(object sender, EventArgs e)
        {
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                finalColor = colorSelector.setColor;
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
            if (e.KeyCode == Keys.F11){ToggleFullscreen();}
            if (e.KeyCode == Keys.F5)
            {
                // generate fractal
                UserControl1.Generate(sender, e, userControl11);
            }
            if (e.KeyCode == Keys.D) { UserControl1.default_pressed(sender, e, userControl11); }
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
                this.TopMost = true;
            }
        }
    }
}