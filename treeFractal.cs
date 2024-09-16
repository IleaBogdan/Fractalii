using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static Fractalii.Form1;
using System.Security.Policy;
using System.Reflection.Metadata;

namespace Fractalii
{
    public class treeFractal
    {
        // private variables
        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private double start_size = -1;

        // initialaze the global variables
        public void global_init(double saL, double saR, double s)
        {
            start_angle_left=saL; 
            start_angle_right=saR; 
            start_size = s;
        }


        // a compact and reusable draw function
        private void draw(int coordonate_x_1, int coordonate_y_1, int coordonate_x_2, int coordonate_y_2, PictureBox p)
        {
            using (Graphics g = p.CreateGraphics())
            {
                g.DrawLine(Pens.Red, new Point(coordonate_x_1, coordonate_y_1), new Point(coordonate_x_2, coordonate_y_2));
            }
        }

        private (int, int, double, double) calculation(int start_x, int start_y, 
            double size, double angle, 
            double start_angle_right, double start_angle_left)
        {
            // calculating the angles
            // calculating the coords for the next x and y
            return ( (int)(start_x - (size * Math.Cos(Math.PI * angle / 180))),
                (int)(start_y - size * (Math.Sin(Math.PI * angle / 180))),
                angle + start_angle_left, (angle - start_angle_right));
        }
        // recursive function
        public void Generate_fractal1(double size, PictureBox p, int start_x, int start_y, double angle, int level)
        {
            double angleL, angleR;
            int end_x, end_y;
            (end_x, end_y, angleL, angleR)=calculation(start_x, start_y, size, angle, start_angle_right, start_angle_left);
            // line drawing
            draw(start_x, start_y, end_x, end_y, p);
            // decoment for much beautiful designe
            //if (start_size/10<=size) 
            if (level<13)
            {
                // recursive calls for left and right
                System.Threading.Thread.Sleep(2);
                Generate_fractal1(size * 0.90, p, end_x, end_y, angleL, level + 1);
                Generate_fractal1(size * 0.70, p, end_x, end_y, angleR, level + 1);
            }
        }
    }
}
