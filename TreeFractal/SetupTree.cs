using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.TreeFractal
{
    internal class SetupTree
    {
        private static bool Condition_treeFractal(double start_angle_left, double start_angle_right, 
            double size, double width, int levels, int redL, int redR)
        {
            return (start_angle_left > 0.0 && start_angle_right > 0.0)
                && size > 0 && (levels > 0 && levels < 15) && (width > 0 && width < 7)
                && (redL > 0 && redR > 0) && (redR < 100 && redL < 100);
        }
        static public void genearte_treeFractal_recursive(PictureBox pictureBox_treeFractal,
            double start_angle_left = -1.0, double start_angle_right = -1.0,
            double size = -1.0, double width = -1.0,
            int levels = -1, int redL = 0, int redR = 0, Color initialColor=default(Color), Color finalColor=default(Color))
        {
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox_treeFractal.Refresh();
            // check if all variables have been assigned
            if (Condition_treeFractal(start_angle_left, start_angle_right, size, width, levels, redL, redR))
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
        public static void generate_treeFractal_iterative(PictureBox pictureBox_treeFractal,
            double start_angle_left = -1.0, double start_angle_right = -1.0,
            double size = -1.0, double width = -1.0,
            int levels = -1, int redL = 0, int redR = 0, Color initialColor = default(Color), Color finalColor = default(Color))
        {
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox_treeFractal.Refresh();
            // check if all variables have been assigned
            if (Condition_treeFractal(start_angle_left, start_angle_right, size, width, levels, redL, redR))
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
