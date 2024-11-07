using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.KochLineFractal
{
    internal class kochLineFractal
    {
        private static Pen pen= new Pen(Color.Red, 2);
        private static Color ic=Color.Blue, fc= Color.Red;
        private static PictureBox p;
        private static int lvl;
        public kochLineFractal()
        {
            lvl = 0;
            p= new PictureBox();
            pen = new Pen(Color.Red, 2);
            ic = Color.Blue; 
            fc = Color.Red;
        }
        public static void init(PictureBox picture, int level, Color initial_color = default(Color), Color final_color= default(Color))
        {
            p = picture;
            lvl = level;
            if (!(initial_color == default(Color)) && !(initial_color == default(Color)))
            {
                ic= initial_color;
                fc = final_color;
            }
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
