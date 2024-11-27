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
        public static double PointDistance(Point end, Point begin)
        {
            double t1 = (end.X - begin.X), t2 = (end.Y - begin.Y);
            return Math.Sqrt(t1*t1+t2*t2);
        }
        private static Point getPointFormula(Point p1, Point p2, double d)
        {
            return new Point((int)((p2.X - p1.X) * d +p1.X), (int)((p2.Y - p1.Y) * d + p1.Y));
        }
        private static Point kochNextPoint(Point p1, Point p2, double angle=0)
        {
            Point mid=getPointFormula(p1, p2, 1.0/2.0);
            double dist=PointDistance(p1, p2)*0.866025, rad=Math.PI*angle/180;
            Point next=new Point(0, 0);
            next.X= mid.X+(int)(dist*Math.Cos(rad));
            next.Y=mid.Y-(int)(dist*Math.Sin(rad));
            return next;
        }
        private static Pen pen = new Pen(Color.Red, 3);
        private static int[] RGB = new int[3];
        private static double[] RGBDif = new double[3];
        private static Color initialColor, finalColor;
        private static void InitColor(Color initial_color, Color final_color)
        {
            initialColor = initial_color;
            finalColor = final_color;

            pen.Color = initialColor;
            RGB[0] = pen.Color.R;
            RGB[1] = pen.Color.G;
            RGB[2] = pen.Color.B;
            RGBDif[0] = finalColor.R - RGB[0];
            RGBDif[1] = finalColor.G - RGB[1];
            RGBDif[2] = finalColor.B - RGB[2];
        }
        private static void predraw(int level, int maxLevel, double width)
        {
            pen.Width = (float)(width);

            float fraction = (float)level / (float)maxLevel;
            int green = RGB[1] + (int)(RGBDif[1] * fraction), red = RGB[0] + (int)(RGBDif[0] * fraction), blue = RGB[2] + (int)(RGBDif[2] * fraction);
            pen.Color = Color.FromArgb(red >= 0 && red <= 255 ? red : 0, green >= 0 && green <= 255 ? green : 0, blue >= 0 && blue <= 255 ? blue : 0);
        }

        private static void inWhile(Queue<KochItem> q, int levels, double reduction, PictureBox pb, int currLevel=0)
        {
            Point mid;
            KochItem k2 = q.Dequeue(), k1 = q.Dequeue();

            // this shit is broken
            pen.Width = (float)(k1.width);
            if (k1.level != currLevel)
            {
                // for better visuals:
                //Thread.Sleep(500);
                currLevel = k1.level;
                if (Debugger.IsAttached)
                {
                    /*
                    Console.WriteLine(currLevel.ToString());
                    Console.WriteLine("pen: " + pen.Width.ToString());
                    Console.WriteLine("k1:  " + k1.width.ToString());
                    */
                }
            }
            /*
            Console.WriteLine(k1.begin_point.ToString()+" "+k1.end_point.ToString());
            Console.WriteLine(k2.begin_point.ToString() + " " + k2.end_point.ToString());
            Console.WriteLine();
            */
            Draw.delete_line(pb, k1.begin_point, k2.end_point, k1.width);
            predraw(currLevel, levels, (k1.width * reduction));
            Draw.draw_line(pb, k1.begin_point, k1.end_point, pen);
            Draw.draw_line(pb, k2.begin_point, k2.end_point, pen);
            ++k1.level; ++k2.level;
            k1.width = pen.Width; k2.width = pen.Width;
            if (levels > k1.level)
            {
                k1.angle += 60;
                Point p1 = k1.begin_point, p2 = k1.end_point;
                k1.begin_point = getPointFormula(p1, p2, 1.0 / 3.0);
                k1.end_point = getPointFormula(p1, p2, 2.0 / 3.0);
                mid = kochNextPoint(k1.begin_point, k1.end_point, k1.angle);
                q.Enqueue(KochItem.merge(new KochItem(k1), mid));
                q.Enqueue(KochItem.merge(new KochItem(k1), mid, false));
            }
            if (levels > k2.level)
            {
                k2.angle -= 60;
                Point p1 = k2.begin_point, p2 = k2.end_point;
                k2.begin_point = getPointFormula(p1, p2, 1.0 / 3.0);
                k2.end_point = getPointFormula(p1, p2, 2.0 / 3.0);
                mid = kochNextPoint(k2.begin_point, k2.end_point, k2.angle);
                q.Enqueue(KochItem.merge(new KochItem(k2), mid));
                q.Enqueue(KochItem.merge(new KochItem(k2), mid, false));
            }
        }
        public static void generate_snowflake(
            PictureBox pb,
            Point p1, Point p2, Point p3,
            int levels,
            double width, double reduction = 1.0
            )
        {
            InitColor(HomePage.initialColor, HomePage.finalColor);
            Queue<KochItem> q = new Queue<KochItem>();
            predraw(0, levels, width);
            Draw.draw_triangle(pb, p1, p2, p3, pen);
            //Draw.draw_line(pb, new Point(10, 10), new Point(250, 200), new Pen(Color.Red, 5.0f));
            //Thread.Sleep(1000);
            //Draw.delete_line(pb, new Point(10, 10), new Point(250, 200), 5.0);
            //Draw.draw_line(pb, new Point(10, 10), new Point(250, 200), new Pen(Color.Blue, 5.0f));
        }
        public static void generate_line(
                PictureBox pb,
                Point ipoint, Point epoint, 
                int levels,
                double width, double reduction = 1.0
            )
        {
            InitColor(HomePage.initialColor, HomePage.finalColor);

            Queue<KochItem>q = new Queue<KochItem>();
            predraw(0, levels, width);
            Draw.draw_line(pb, ipoint, epoint, pen);
            KochItem k=new KochItem(getPointFormula(ipoint, epoint, 1.0 / 3.0), 
                getPointFormula(ipoint, epoint, 2.0 / 3.0), 
                1, width);


            pen.Width = (float)(width);
            if (Debugger.IsAttached) Console.WriteLine(k.width.ToString());
            //Draw.draw_line(pb, ipoint, k.begin_point, new Pen(Color.Blue, 1));
            //Draw.draw_line(pb, epoint, k.end_point, new Pen(Color.Blue, 1));
            //Draw.draw_line(pb, k.begin_point, k.end_point, pen);
            Point mid = kochNextPoint(k.begin_point, k.end_point, 90);
            q.Enqueue(KochItem.merge(new KochItem(k), mid));
            q.Enqueue(KochItem.merge(new KochItem(k), mid, false));
            if (levels == 1)
            {
                q.Dequeue(); q.Dequeue();
            }
            while (q.Count > 0)
            {
                inWhile(q, levels, reduction, pb);
            }
            pen.Width = (float)width;
        }
    }
}
