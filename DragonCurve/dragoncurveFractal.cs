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
        private static Pair<int, int>[] rout = [
            new Pair<int, int>(0, -25), 
            new Pair<int, int>(25, 0),
            new Pair<int, int>(0, 25),
            new Pair<int, int>(25, 0),
            new Pair<int, int>(0, 25),
            new Pair<int, int>(-25, 0),
            new Pair<int, int>(0, 25),
            new Pair<int, int>(25, 0)
        ];
        // you get the orientation like this:
        // x:- y:0 --- North
        // x:0 y:+ --- West
        // x:+ y:0 --- South
        // x:0 y:- --- East
        public static void generate(PictureBox pb, int levels, double width, Point p)
        {
            pen.Width = (float)width;
            int currLevel = 0;
            while (currLevel < levels)
            {
                Point nextp = p;
                List<Point> todraw=new();
                todraw.Add(p);
                for (int i=0; i<8; ++i)
                {
                    int index = (currLevel%2==0 ? i : 8-i-1);
                    nextp.X += rout[index].First;
                    nextp.Y += rout[index].Second;
                    todraw.Add(nextp);
                    p = nextp;
                }
                Draw.draw_lines(pb, todraw.ToArray(), pen);
                Thread.Sleep(500);
                ++currLevel;
            }
        }
    }
}
