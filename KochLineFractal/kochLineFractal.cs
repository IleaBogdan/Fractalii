using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
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
        public static Point nextPointKochLine(Point begin, Point end, 
            double dist, double angle = 90)
        {
            Point mid=new Point((end.X+begin.X)/2, (end.Y+begin.Y)/2);
            //dist *= 0.866025405;
            angle = Math.PI * angle / 180;
            mid.X += (int)(dist * Math.Cos(angle));
            mid.Y -= (int)(dist * Math.Sin(angle));
            return mid;
        }
        public static Point OneOverThree(Point p, double dist, double angle=90)
        {
            angle = Math.PI * angle / 180;
            p.X += (int)(dist*Math.Cos(angle));
            p.Y -= (int)(dist * Math.Sin(angle));
            return p;
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
            ipoint.X = epoint.X / 3;
            epoint.X = 2*(epoint.X/3);
            Point MidPoint = new Point(0, 0);
            {
                KochItem k = new KochItem(ipoint, epoint, 0, width);


                // this part is still not done but it will be soon
                //Point MidPoint = nextPoint(k.begin_point, (double)(k.end_point.X-k.begin_point.X));
                // is io prost de aia nu mergea aia de mai sus da oricum o schimb
                MidPoint = nextPointKochLine(k.begin_point, k.end_point,
                    PointDistance(k.begin_point, k.end_point));


                k.level = 1;
                q.Enqueue(KochItem.merge(new KochItem(k), MidPoint, false));
                q.Enqueue(KochItem.merge(new KochItem(k), MidPoint));
            }
            //System.Windows.Forms.MessageBox.Show(string.Format("{0}", [ MidPoint.X, MidPoint.Y]));
            while (q.Count > 0)
            {
                KochItem k1=q.Dequeue(), k2=q.Dequeue();
                Draw.draw_line(pb, k1.begin_point, k2.end_point, new Pen(Color.Blue
                                                                         //HomePage.bgC,
                                                                         ,pen.Width));
                Draw.draw_line(pb, k1.begin_point, k1.end_point, pen);
                Draw.draw_line(pb, k2.begin_point, k2.end_point, pen);
                k1.level++;
                k2.level++;
                if (k1.level < levels)
                {

                    double dist = PointDistance(k1.begin_point, k1.end_point);
                    k1.begin_point = OneOverThree(k1.begin_point, dist/3.0, k1.angle);
                    k1.end_point = OneOverThree(k1.end_point, dist/3.0, k1.angle);
                    k1.angle += 30;
                    MidPoint = nextPointKochLine(k1.begin_point,k1.end_point, 
                        dist/3.0, k1.angle);
                    q.Enqueue(KochItem.merge(new KochItem(k1), MidPoint, false));
                    q.Enqueue(KochItem.merge(new KochItem(k1), MidPoint));
                }
                // scoate false cand ai reparat pe partea ailalta
                // si vezi ca trebe sa recalculezi MidPoint
                if (k2.level < levels && false)
                {
                    k2.angle -= 1.0472;
                    double dist = PointDistance(k1.begin_point, k1.end_point);
                    MidPoint = nextPointKochLine(k2.begin_point, k2.end_point, dist, k2.angle);
                    q.Enqueue(KochItem.merge(new KochItem(k2), MidPoint, false));
                    q.Enqueue(KochItem.merge(new KochItem(k2), MidPoint));
                }
            }
        }
    }
}
