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
        private static Color initialColor, finalColor;

        private static int[] RGB = new int[3];
        private static double[] RGBDif = new double[3];
        private static Pen pen = new Pen(Color.Red, 1f);


        private static void preDraw(int maxlvl, int currlvl, double width)
        {
            pen.Width = (float)(width);

            float fraction = (float)currlvl / (float)maxlvl;
            int green = RGB[1] + (int)(RGBDif[1] * fraction), red = RGB[0] + (int)(RGBDif[0] * fraction), blue = RGB[2] + (int)(RGBDif[2] * fraction);
            pen.Color = Color.FromArgb(red >= 0 && red <= 255 ? red : 0, green >= 0 && green <= 255 ? green : 0, blue >= 0 && blue <= 255 ? blue : 0);
        }
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
                preDraw(maxLevel, currLevel, pen.Width);
                Thread.Sleep(500);
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

        private static void pregen(double width)
        {
            currLevel = 0;
            pen.Width = (float)width;
            initialColor = HomePage.initialColor;
            finalColor = HomePage.finalColor;
            pen.Color = initialColor;
            RGB[0] = pen.Color.R;
            RGB[1] = pen.Color.G;
            RGB[2] = pen.Color.B;
            RGBDif[0] = finalColor.R - RGB[0];
            RGBDif[1] = finalColor.G - RGB[1];
            RGBDif[2] = finalColor.B - RGB[2];
        }
        public static void generate_line(PictureBox pb, Point start, Point end, int levels, double width)
        {
            pregen(width);
            --levels;
            Queue<KochItem> queue = new Queue<KochItem>();
            queue.Enqueue(new KochItem(start, end, 1));

            while (queue.Count > 0){ KochSegment(pb, queue, levels); }
        }

        public static void generate_snowflake(PictureBox pb, Point p1, Point p2, Point p3, int levels, double width)
        {
            pregen(width);
            --levels;
            Queue<KochItem> queue = new Queue<KochItem>();
            queue.Enqueue(new KochItem(p1, p2, 1));
            queue.Enqueue(new KochItem(p2, p3, 1));
            queue.Enqueue(new KochItem(p3, p1, 1));

            while (queue.Count > 0) { KochSegment(pb, queue, levels); }
        }
    }
}