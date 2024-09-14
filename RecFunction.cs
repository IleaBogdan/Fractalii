using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static Fractalii.Form1;

namespace Fractalii
{
    public class RecFunction
    {
        public void Generate_fractal1(double L_angle, double R_angle, 
            double size, PictureBox p, int coordonate_x, int coordonate_y)
        {
            using (Graphics g = p.CreateGraphics())
            {
                g.DrawLine(Pens.Red, new Point(10, 10), new Point(100, 200));
            }
        }
    }
}
