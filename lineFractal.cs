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
    public class lineFractal
    {
        private double start_angle_left=-1.0, start_angle_right = -1.0, start_size = -1.0;
        public void global_init(double saL, double saR, double s)
        {
            start_angle_left=saL; 
            start_angle_right=saR; 
            start_size = s;
        }
        public void Generate_fractal1(double L_angle, double R_angle, 
            double size, PictureBox p, int coordonate_x, int coordonate_y)
        {
            if (size >= start_size * 0.1)
            {
                using (Graphics g = p.CreateGraphics())
                {

                }
            }
        }
    }
}
