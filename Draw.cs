using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
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
        public static void delete_line(PictureBox pb, Point begin_point, Point end_point, 
            // don't fucking change this shit ok?
            // it worked and since you changed it is all fucked LUCA
            double width)
        {
            //if (Debugger.IsAttached) Console.WriteLine("float:  " + width.ToString());
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(new Pen(HomePage.bgC, (float)(width)), begin_point, end_point);
            }
        }
        public static void draw_triangle(PictureBox pb, Point p1, Point p2, Point p3, Pen pen)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(pen, p1, p2);
                g.DrawLine(pen, p2, p3);
                g.DrawLine(pen, p3, p1);
            }
        }
    }
}
