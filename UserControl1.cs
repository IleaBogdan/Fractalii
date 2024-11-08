using Fractalii.TreeFractal;
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

        private Color initialColor = Color.Blue, finalColor = Color.Red;

        private (double, double, double, int, double, int, int) get_data_treeFractal()
        {
            double angleL, angleR, Size, Width;
            int Level, rL, rR;
            double.TryParse(textBox_angle_left_tab1.Text, null, out angleL);
            double.TryParse(textBox_angle_right_tab1.Text, null, out angleR);
            double.TryParse(textBox_size_tab1.Text, null, out Size);
            Int32.TryParse(textBox_levels_tab1.Text, null, out Level);
            double.TryParse(textBox_width_tab1.Text, null, out Width);
            Int32.TryParse(textBox_reduction_left_tab1.Text, null, out rL);
            Int32.TryParse(textBox_reduction_right_tab1.Text, null, out rR);



            return (angleL, angleR, Size, Level, Width, rL, rR);
        }

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

        private void genearte_treeFractal_recursive(object sender, EventArgs e)
        {
            double start_angle_left = -1.0, start_angle_right = -1.0;
            double size = -1.0, width = -1.0;
            int levels = -1, redL = 0, redR = 0;


            (start_angle_left, start_angle_right, size, levels, width, redL, redR) = get_data_treeFractal();
            SetupTree.genearte_treeFractal_recursive(pb, start_angle_left, start_angle_right, size, width, levels, redL, redR, initialColor, finalColor);
        }

        private void generate_treeFractal_iterative(object sender, EventArgs e)
        {
            double start_angle_left = -1.0, start_angle_right = -1.0;
            double size = -1.0, width = -1.0;
            int levels = -1, redL = 0, redR = 0;


            (start_angle_left, start_angle_right, size, levels, width, redL, redR) = get_data_treeFractal();
            SetupTree.generate_treeFractal_iterative(pb, start_angle_left, start_angle_right, size, width, levels, redL, redR, initialColor, finalColor);
        }
    }
}
