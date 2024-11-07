using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractalii.TreeFractal
{
    public partial class UserControlTree : UserControl
    {
        public UserControlTree()
        {
            InitializeComponent();
            debug();
        }


        PictureBox pictureBox_treeFractal;
        public void set_pictureBox(PictureBox pictureBox)
        {
            pictureBox_treeFractal = pictureBox;
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
        private bool condition_treeFractal(double start_angle_left, double start_angle_right, double size, double width, int levels, int redL, int redR)
        {
            return (start_angle_left > 0.0 && start_angle_right > 0.0)
                && size > 0 && (levels > 0 && levels < 15) && (width > 0 && width < 7)
                && (redL > 0 && redR > 0) && (redR < 100 && redL < 100);
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
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox_treeFractal.Refresh();
            // check if all variables have been assigned
            if (condition_treeFractal(start_angle_left, start_angle_right, size, width, levels, redL, redR))
            {
                // initialaze the global variables
                treeFractal fractal = new treeFractal(start_angle_left, start_angle_right, size, initialColor, finalColor, pictureBox_treeFractal);

                // first call of the recursive function
                fractal.preGenerate(size, width, pictureBox_treeFractal.Size.Width / 2,
                    pictureBox_treeFractal.Size.Height / 2 + 150, 90, 0, levels, (double)(redL) / 100, (double)(redR) / 100);
            }
            else
            {
                // invalide statemant popup
                System.Windows.Forms.MessageBox.Show("Please enter all coordinates, size, width, reduction and levels correctly!");
                /*// printing the invalide statemant
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates, size, width, reduction and levels correctly!", 
                        new System.Drawing.Font("Arial", 12), Brushes.Green,
                        new PointF((pictureBox1.Size.Width / 2) - 175, (pictureBox1.Size.Height / 2) - 20));
                }*/
            }
        }

        private void generate_treeFractal_iterative(object sender, EventArgs e)
        {
            double start_angle_left = -1.0, start_angle_right = -1.0;
            double size = -1.0, width = -1.0;
            int levels = -1, redL = 0, redR = 0;


            (start_angle_left, start_angle_right, size, levels, width, redL, redR) = get_data_treeFractal();
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox_treeFractal.Refresh();
            // check if all variables have been assigned
            if (condition_treeFractal(start_angle_left, start_angle_right, size, width, levels, redL, redR))
            {
                treeFractal fractal = new treeFractal(start_angle_left, start_angle_right, size, initialColor, finalColor, pictureBox_treeFractal);


                // first call of the iterative function
                fractal.Generate_fractal2(size, width, pictureBox_treeFractal.Size.Width / 2,
                    pictureBox_treeFractal.Size.Height / 2 + 150, 90, levels, (double)(redL) / 100, (double)(redR) / 100);
            }
            else
            {
                // invalide statemant popup
                System.Windows.Forms.MessageBox.Show("Please enter all coordinates, size, width, reduction and levels correctly!");
                /*// printing the invalide statemant
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates, size, width, reduction and levels correctly!", 
                        new System.Drawing.Font("Arial", 12), Brushes.Green,
                        new PointF((pictureBox1.Size.Width / 2) - 175, (pictureBox1.Size.Height / 2) - 20));
                }*/
            }
        }
    }
}
