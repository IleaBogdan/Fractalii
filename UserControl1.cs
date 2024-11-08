using Fractalii.KochLineFractal;
using Fractalii.TreeFractal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractalii
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            debug();
        }
        private PictureBox pb;
        public void set_pictureBox(PictureBox pictureBox)
        {
            pb = pictureBox;
        }
        // color setting
        private Color initialColor = Color.Blue, finalColor = Color.Red;
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

        // Tree Fractal
        private void default_button_Click_treeFractal(object sender, EventArgs e)
        {
            textBox_angle_left_tab1.Text = "60";
            textBox_angle_right_tab1.Text = "30";
            textBox_size_tab1.Text = "60";
            textBox_levels_tab1.Text = "12";
            textBox_width_tab1.Text = "5";
            textBox_reduction_left_tab1.Text = "75";
            textBox_reduction_right_tab1.Text = "90";
            initialColor = Color.Green;
            finalColor = Color.Blue;
        }
        private void genearte_treeFractal_recursive(object sender, EventArgs e)
        {
            double start_angle_left = -1.0, start_angle_right = -1.0;
            double size = -1.0, width = -1.0;
            int levels = -1, redL = 0, redR = 0;

            double.TryParse(textBox_angle_left_tab1.Text, null, out start_angle_left);
            double.TryParse(textBox_angle_right_tab1.Text, null, out start_angle_right);
            double.TryParse(textBox_size_tab1.Text, null, out size);
            Int32.TryParse(textBox_levels_tab1.Text, null, out levels);
            double.TryParse(textBox_width_tab1.Text, null, out width);
            Int32.TryParse(textBox_reduction_left_tab1.Text, null, out redL);
            Int32.TryParse(textBox_reduction_right_tab1.Text, null, out redR);
            SetupTree.genearte_treeFractal_recursive(pb, start_angle_left, start_angle_right, size, width, levels, redL, redR, initialColor, finalColor);
        }

        private void generate_treeFractal_iterative(object sender, EventArgs e)
        {
            double start_angle_left = -1.0, start_angle_right = -1.0;
            double size = -1.0, width = -1.0;
            int levels = -1, redL = 0, redR = 0;

            double.TryParse(textBox_angle_left_tab1.Text, null, out start_angle_left);
            double.TryParse(textBox_angle_right_tab1.Text, null, out start_angle_right);
            double.TryParse(textBox_size_tab1.Text, null, out size);
            Int32.TryParse(textBox_levels_tab1.Text, null, out levels);
            double.TryParse(textBox_width_tab1.Text, null, out width);
            Int32.TryParse(textBox_reduction_left_tab1.Text, null, out redL);
            Int32.TryParse(textBox_reduction_right_tab1.Text, null, out redR);
            SetupTree.generate_treeFractal_iterative(pb, start_angle_left, start_angle_right, size, width, levels, redL, redR, initialColor, finalColor);
        }


        // Koch-Line
        private void default_button_Click_KochLine(object sender, EventArgs e)
        {
            levels_KochLine.Text = "11";
            width_KochLine.Text = "12";
            size_KochLine.Text = "50";
        }
        private void generate_kochLineFractal(object sender, EventArgs e)
        {
            int levels = -1;
            double width = -0.1, size = -1.0;
            Int32.TryParse(levels_KochLine.Text, null, out levels);
            Double.TryParse(width_KochLine.Text, null, out width);
            Double.TryParse(size_KochLine.Text, null, out size);
            Point start_point = new Point(0, pb.Height - 125), stop_point = new Point(pb.Width, pb.Height - 125);
            SetupKochLine.generate_kochLineFractal_iterative(pb, levels, width, size, start_point, stop_point, initialColor, finalColor);
        }
    }
}
