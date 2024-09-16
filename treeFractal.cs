using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static Fractalii.Form1;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace Fractalii
{
    public class treeFractal
    {
        // private variables
        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private int start_size = -1;
        private float maxWidth = 5f;
        private int maxLvl = 14;

        private int[] RGB = new int[3];
        private float[] RGBDif = new float[3];

        Pen pen = new Pen(Color.Red, 1f);

        // initialaze the global variables
        public treeFractal(double saL, double saR, int s)
        {
            start_angle_left = saL;
            start_angle_right = saR;
            start_size = s;

            //Hardcoode here
            RGB[0] = pen.Color.R;
            RGB[1] = pen.Color.G;
            RGB[2] = pen.Color.B;
            RGBDif[1] = 130;
        }


        // a compact and reusable draw function
        private void draw(int coordonate_x_1, int coordonate_y_1, int coordonate_x_2, int coordonate_y_2, PictureBox p)
        {
            using (Graphics g = p.CreateGraphics())
            {
                g.DrawLine(pen, new Point(coordonate_x_1, coordonate_y_1), new Point(coordonate_x_2, coordonate_y_2));
            }
        }

        // recursive function
        public void Generate_fractal1(int size, PictureBox p, int start_x, int start_y, double angle, int level)
        {
            // calculating the angles
            double angleL = angle + start_angle_left;
            double angleR = angle - start_angle_right;
            // calculating the coords for the next x and y
            int end_x = (int)((double)(start_x) - (double)(size) * (Math.Cos(Math.PI*angle/180)));
            int end_y = (int)((double)(start_y) - (double)(size) * (Math.Sin(Math.PI*angle/180)));

            // line drawing
            // make other way of having width decrease (maybe make it same as size decrease)
            pen.Width = maxWidth - (float)level / 3f;
            float fraction = (float)level / (float)maxLvl;
            pen.Color = Color.FromArgb(RGB[0] + (int)(RGBDif[0] * fraction), RGB[1] + (int)(RGBDif[1] * fraction), 
                RGB[2] + (int)(RGBDif[2] * fraction));
            draw(start_x, start_y, end_x, end_y, p);
            
            if (level >= maxLvl) return;

            // recursive calls for left and right
            //System.Threading.Thread.Sleep(2);
            Generate_fractal1((int)((double)size * 0.90), p, end_x, end_y, angleL, level + 1);
            Generate_fractal1((int)((double)size * 0.70), p, end_x, end_y, angleR, level + 1);
        }
    }
}
