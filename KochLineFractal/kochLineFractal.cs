using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Fractalii.KochLineFractal;

namespace Fractalii.KochLineFractal
{
    internal class kochLineFractal
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
        public static void generate_iterative(
                PictureBox pb,
                Point ipoint, Point epoint, 
                int levels,
                double width
            )
        {


            Queue<KochItem>q = new Queue<KochItem>();
            Draw.draw_line(pb, ipoint, epoint, pen);
            KochItem k=new KochItem(getPointFormula(ipoint, epoint, 1.0 / 3.0), 
                getPointFormula(ipoint, epoint, 2.0 / 3.0), 
                1, width);



            //Draw.draw_line(pb, ipoint, k.begin_point, new Pen(Color.Blue, 1));
            //Draw.draw_line(pb, epoint, k.end_point, new Pen(Color.Blue, 1));
            Draw.draw_line(pb, k.begin_point, k.end_point, pen);
            Point mid = kochNextPoint(k.begin_point, k.end_point, 90);
            q.Enqueue(KochItem.merge(new KochItem(k), mid));
            q.Enqueue(KochItem.merge(new KochItem(k), mid, false));
            if (levels == 1)
            {
                q.Dequeue(); q.Dequeue();
            }
            int currLevel=0;
            while (q.Count > 0)
            {
                KochItem k2 = q.Dequeue(), k1 = q.Dequeue();
                // ok LETS GOOOOOO it works
                // get owned suckers
                if (k1.level != currLevel) { Thread.Sleep(500); currLevel = k1.level; }
                Draw.delete_line(pb, k1.begin_point, k2.end_point, width);
                Draw.draw_line(pb, k1.begin_point, k1.end_point, pen);
                Draw.draw_line(pb, k2.begin_point, k2.end_point, pen);
                ++k1.level; ++k2.level;
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
        }
    }
}
