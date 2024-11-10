using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii
{
    internal class Draw
    {
        public static void draw_line(PictureBox pb, Point begin_point, Point end_point, Pen pen)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(pen, begin_point, end_point);
            }
        }
    }
}
