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
        private static Point getPointFormula(Point p1, Point p2, double d)
        {
            return new Point((int)((p2.X - p1.X) * d + p1.X), (int)((p2.Y - p1.Y) * d + p1.Y));
        }
        private static Point kochNextPoint(Point p1, Point p2, double angle = 0)
        {
            Point mid = getPointFormula(p1, p2, 1.0 / 2.0);
            double dist = MathForms.Point_Distance(p1, p2) * 0.866025, rad = Math.PI * angle / 180;
            Point next = new Point(0, 0);
            next.X = mid.X + (int)(dist * Math.Cos(rad));
            next.Y = mid.Y - (int)(dist * Math.Sin(rad));
            return next;
        }
        private static void makefractal(PictureBox pb, Queue<KochItem> que, int levels)
        {
            KochItem last=que.Dequeue();
            Draw.draw_line(pb, last.begin_point, last.end_point, pen);
            last.delete(pb);
            Console.WriteLine(last.begin_point.ToString()+" "+last.end_point.ToString()+"\n");
            if (last.level == levels) return;
            // trebuie splituit in 3 linia
            // si bagat partea 1 -> dist/3
            //    partea dist*2/3 -> dist
            // si dupa trebe calculat punctul in sus
            KochItem k1o3=last, k2o3=last; // 1/3 dist point and 2/3 dist point
            k1o3.end_point = new Point(last.end_point.X/3, last.end_point.Y/3);
            k2o3.begin_point = new Point(2*last.end_point.X/3, 2*last.end_point.Y/3);
            k1o3++;
            k2o3++;
            // aici facem chestia cu mijlocul
            Point begin= k1o3.end_point, end= k2o3.begin_point;
            Point mid=kochNextPoint(begin, end, k1o3.angle);
            KochItem line1=k1o3, line2=k2o3;
            line1.begin_point = line1.end_point; line1.end_point = mid;
            line2.end_point = line2.begin_point; line2.begin_point = mid;

            que.Enqueue(k1o3);
            que.Enqueue(line1+new Pair<Point, Point>(k1o3.end_point, k2o3.begin_point));
            que.Enqueue(line2);
            que.Enqueue(k2o3);
        }
        public static void generate_line(PictureBox pb, 
            Point START, Point END,
            int levels,
            double width
            )
        {
            Queue<KochItem> que = new Queue<KochItem>();
            que.Enqueue(new KochItem(START, END, 1, width));
            while (que.Count > 0)
            {
                makefractal(pb, que, levels);
            }
        }
    }
}
