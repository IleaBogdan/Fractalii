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
        public static Point nextPoint(Point begin, Point end)
        {
            Point next=new Point(100, 100);
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
            KochItem k = new KochItem(ipoint, epoint, 0, width);
            Draw.draw_line(pb, k.begin_point, k.end_point, pen);
            
            
            // this part is still not done but it will be soon
            Point MidPoint = nextPoint(k.begin_point, k.end_point);
            q.Enqueue(KochItem.merge(new KochItem(k), MidPoint));
            q.Enqueue(KochItem.merge(new KochItem(k), MidPoint, false));

            while (q.Count > 0)
            {
                k = q.Dequeue();
                Draw.draw_line(pb, k.begin_point, k.end_point, pen);
            }
        }
    }
}
