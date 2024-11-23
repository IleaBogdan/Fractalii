using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
        public static void delete_line(PictureBox pb, Point begin_point, Point end_point, float width)
        {
            //if (Debugger.IsAttached) Console.WriteLine("float:  " + width.ToString());
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(new Pen(HomePage.bgC, width), begin_point, end_point);
            }
        }
    }
}
