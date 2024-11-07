using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.KochLineFractal
{
    internal class kochLineFractal
    {
        private static Pen pen= new Pen(Color.Red, 2);
        private static PictureBox p;
        private static int lvl;
        public kochLineFractal()
        {
            lvl = 0;
            p= new PictureBox();
            pen = new Pen(Color.Red, 2);
        }
        public static void init(PictureBox picture, int level)
        {
            p = picture;
            lvl = level;
        }
        public static void iterative_fractal(Point begin, Point end)
        {
            using (Graphics g = p.CreateGraphics())
            {
                g.DrawLine(pen , begin, end);
            }
        }
    }
}
