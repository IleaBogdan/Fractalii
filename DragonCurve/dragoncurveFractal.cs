using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.DragonCurve
{
    internal class dragoncurveFractal
    {
        private static Pen pen = new Pen(Color.Red, 1f);
        private static int[] angles = [90, -90, -90, 90, -90, -90, 90, 90];
        
        private static Point fromTo(Point p, int angle, int dist)
        {
            double rad = Math.PI * (double)angle / 180.0d;
            return new Point(p.X - (int)(dist * Math.Cos(rad)),
                             p.Y - (int)(dist * Math.Sin(rad)));
        }
        public static void generate(PictureBox pb, int levels, double width, Point p)
        {
            pen.Width = (float)width;
            int currLevel = 0;
            while (currLevel < levels)
            {
                Point nextp = p;
                List<Point> todraw=new();
                todraw.Add(p);
                int startangle = (currLevel%2==1 ? 0 : 90);
                if (currLevel % 4 > 2) startangle = -startangle;
                for (int i=0; i<8; ++i)
                {
                    int index = (currLevel%2==0 ? i : 8-i-1);
                    startangle-=angles[index];
                    nextp =fromTo(p, startangle, 25);
                    todraw.Add(nextp);
                    p = nextp;
                }
                Draw.draw_lines(pb, todraw.ToArray(), pen);
                Thread.Sleep(500);
                ++currLevel;
                Console.WriteLine(currLevel);
            }
        }
    }
}
