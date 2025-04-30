using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractalii
{
    internal class Draw
    {
        public static void draw_points(PictureBox pb, Point[] points, Pen pen)
        {
            foreach (Point p in points)
            {
                draw_point(pb, p, pen);
            }
        }
        public static void draw_point(PictureBox pb, Point point, Pen pen)
        {
            Graphics g = Graphics.FromHwnd(pb.Handle);
            SolidBrush brush = new SolidBrush(pen.Color);
            Rectangle rect = new Rectangle(point, new Size((int)pen.Width, (int)pen.Width));
            g.FillRectangle(brush, rect);
            g.Dispose();
        }
        public static void draw_line(PictureBox pb, Point begin_point, Point end_point, Pen pen)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(pen, begin_point, end_point);
            }
        }
        public static void draw_line(PictureBox pb, Pair<Point, Point> ps, Pen pen)
        {
            Point begin_point=ps.First, end_point = ps.Second;
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(pen, begin_point, end_point);
            }
        }
        public static void delete_line(PictureBox pb, Point begin_point, Point end_point, double width)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(new Pen(HomePage.bgC, (float)(width)), begin_point, end_point);
            }
        }
        public static void delete_line(PictureBox pb, Point begin_point, Point end_point, float width)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLine(new Pen(HomePage.bgC, width), begin_point, end_point);
            }
        }

        public static void draw_lines(PictureBox pb, Point[] points, Pen pen)
        {
            if (points == null) return;
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLines(pen, points);
            }
        }
        public static void draw_lines(PictureBox pb, PointF[] points, Pen pen)
        {
            using (Graphics g = pb.CreateGraphics())
            {
                g.DrawLines(pen, points);
            }
        }
    }
}
