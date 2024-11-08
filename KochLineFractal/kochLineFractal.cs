using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.KochLineFractal
{
    internal class kochLineFractal
    {
        private static void draw(Point start_point, Point end_point, PictureBox pb, double width)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(new Pen(Color.Red, (float)(width)), start_point, end_point);
            }
        }
        public static void generate_iterative(
                PictureBox pb,
                Point ipoint, Point epoint, 
                int levels,
                double width
            )
        {
            draw(ipoint, epoint, pb, width);
        }
    }
}
