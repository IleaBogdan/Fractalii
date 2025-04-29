using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.KochLineFractal
{
    internal class KochItem
    {
        public Point begin_point, end_point;
        public double angle, width;
        public int level;
        private Point delp1, delp2;
        public void set_del(Point p1, Point p2)
        {
            delp1= p1;
            delp2= p2;
        }
        public KochItem() { angle = 90; }
        public KochItem(Point BEGIN, Point END, int LEVEL, double WIDTH, double ANGLE = 90)
        {
            begin_point = BEGIN;
            end_point = END;
            level = LEVEL;
            width = WIDTH;
            angle = ANGLE;
        }
        public static KochItem merge(KochItem k, Point next, bool ok = true)
        {
            if (ok) { k.begin_point = next; } else { k.end_point = next; }
            return k;
        }
        public KochItem(KochItem k)
        {
            begin_point = k.begin_point;
            end_point = k.end_point;
            width = k.width;
            level = k.level;
            angle = k.angle;
        }
        public void delete(PictureBox pb)
        {
            Draw.delete_line(pb, delp1, delp2, width);
        }
        public static KochItem operator++(KochItem k){
            k.level++;
            return k;
        }
        public static KochItem operator +(KochItem k, Pair<Point, Point> p)
        {
            k.set_del(p.First, p.Second);
            return k;
        }
    }
}
