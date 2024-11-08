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
        private static void draw(Point start_point, Point end_point, PictureBox pb)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(new Pen(Color.Red, 3), start_point, end_point);
            }
        }
        public static void generate_iterative(
                Point ipoint, Point epoint, int levels
            )
        {
            
        }
    }
}
