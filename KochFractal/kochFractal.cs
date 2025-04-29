using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Fractalii.KochLineFractal;

namespace Fractalii.KochLineFractal
{
    internal class kochFractal
    {
        private static Pen pen = new Pen(Color.Red, 3);

        private static Point GetMidPoint(Point p1, Point p2, double fraction)
        {
            return new Point(
                (int)(p1.X + (p2.X - p1.X) * fraction),
                (int)(p1.Y + (p2.Y - p1.Y) * fraction)
            );
        }

        private static Point NextKochPoint(Point p1, Point p2)
        {
            double dx = -(p2.X - p1.X);
            double dy = -(p2.Y - p1.Y);
            double length = Math.Sqrt(dx * dx + dy * dy);

            double height = length * Math.Sqrt(3) / 2;

            Point mid = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);

            double angle = Math.Atan2(dy, dx) + Math.PI / 2;

            return new Point(
                mid.X + (int)(height * Math.Cos(angle)),
                mid.Y + (int)(height * Math.Sin(angle))
            );
        }

        private static int currLevel=0;
        private static void KochSegment(PictureBox pb, Queue<KochItem> queue, int maxLevel)
        {
            if (queue.Count <= 0) return;

            KochItem current = queue.Dequeue();

            if (currLevel < current.Level)
            {
                currLevel= current.Level;
                Thread.Sleep(150);
            }
            if (current.Level > maxLevel)
            {
                Draw.draw_line(pb, current.BeginPoint, current.EndPoint, pen);
                return;
            }

            Point oStart = current.BeginPoint;
            Point oEnd = current.EndPoint;

            Point p1 = current.BeginPoint;
            Point p5 = current.EndPoint;
            Point p2 = GetMidPoint(p1, p5, 1.0 / 3.0);
            Point p4 = GetMidPoint(p1, p5, 2.0 / 3.0);
            Point p3 = NextKochPoint(p2, p4);

            Draw.delete_line(pb, oStart, oEnd, pen.Width);

            Draw.draw_line(pb, p1, p2, pen);
            Draw.draw_line(pb, p2, p3, pen);
            Draw.draw_line(pb, p3, p4, pen);
            Draw.draw_line(pb, p4, p5, pen);

            if (current.Level < maxLevel)
            {
                queue.Enqueue(new KochItem(p1, p2, current.Level + 1));
                queue.Enqueue(new KochItem(p2, p3, current.Level + 1));
                queue.Enqueue(new KochItem(p3, p4, current.Level + 1));
                queue.Enqueue(new KochItem(p4, p5, current.Level + 1));
            }
        }

        public static void generate_line(PictureBox pb, Point start, Point end, int levels, double width)
        {
            --levels;
            pen.Width = (float)width;
            Queue<KochItem> queue = new Queue<KochItem>();
            queue.Enqueue(new KochItem(start, end, 1));

            while (queue.Count > 0){ KochSegment(pb, queue, levels); }
        }

        public static void generate_snowflake(PictureBox pb, Point p1, Point p2, Point p3, int levels, double width)
        {
            --levels;
            pen.Width = (float)width;
            Queue<KochItem> queue = new Queue<KochItem>();
            queue.Enqueue(new KochItem(p1, p2, 1));
            queue.Enqueue(new KochItem(p2, p3, 1));
            queue.Enqueue(new KochItem(p3, p1, 1));

            while (queue.Count > 0) { KochSegment(pb, queue, levels); }
        }
    }
}