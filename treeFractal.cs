using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static Fractalii.Form1;
using System.Security.Policy;

namespace Fractalii
{
    public class treeFractal
    {
        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private int start_size = -1;
        public void global_init(double saL, double saR, int s)
        {
            start_angle_left=saL; 
            start_angle_right=saR; 
            start_size = s;
        }
        private void generate(int coordonate_x_1, int coordonate_y_1, int coordonate_x_2, int coordonate_y_2, PictureBox p)
        {
            using (Graphics g = p.CreateGraphics())
            {
                g.DrawLine(Pens.Red, new Point(coordonate_x_1, coordonate_y_1), new Point(coordonate_x_2, coordonate_y_2));
            }
        }
        public void Generate_fractal1(int size, PictureBox p, int start_x, int start_y, double angle, int level)
        {
            System.Threading.Thread.Sleep(2);
            if (level<10)
            {
                double angleL = (angle + start_angle_left);
                double angleR = (angle - start_angle_right);
                int end_x = (int)((double)(start_x) - (double)(size) * (Math.Cos(Math.PI*angle/180)));
                int end_y = (int)((double)(start_y) - (double)(size) * (Math.Sin(Math.PI*angle/180)));
                generate(start_x, start_y, end_x, end_y, p);
                Generate_fractal1((int)((double)size * 0.90), p, end_x, end_y, angleL, level + 1);
                Generate_fractal1((int)((double)size * 0.70), p, end_x, end_y, angleR, level + 1);



            }
        }
    }
}
