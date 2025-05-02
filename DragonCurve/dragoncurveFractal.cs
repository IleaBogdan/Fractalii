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
            new Pair<int, int>(-5, 0), 
            new Pair<int, int>(0, 5),
            new Pair<int, int>(5, 0),
            new Pair<int, int>(0, 5),
            new Pair<int, int>(5, 0),
            new Pair<int, int>(0, -5),
            new Pair<int, int>(5, 0),
            new Pair<int, int>(0, 5)
        ];
        // you get the orientation like this:
        // x:- y:0 --- North
        // x:0 y:+ --- West
        // x:+ y:0 --- South
        // x:0 y:- --- East
        public static void generate(PictureBox pb, int levels, double width, Point p)
        {
            pen.Width = (float)width;
            
        }
    }
}
