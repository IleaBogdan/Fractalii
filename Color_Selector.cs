using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractalii
{
    public partial class Color_Selector : Form
    {
        public Color setColor { get; private set; }
        public Color_Selector()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            smallScreenLb.BackColor = clr;
            rgbValuesLb.Text = "R: " + clr.R.ToString() + " G: " + clr.G.ToString() + " B: " + clr.B.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            setColor = pixelData.GetPixel(e.X, e.Y);
            redValueTbx.Text = setColor.R.ToString();
            greenValueTbx.Text = setColor.G.ToString();
            blueValueTbx.Text = setColor.B.ToString();
            selectedScreenPnl.BackColor = setColor;
        }
    }
}
