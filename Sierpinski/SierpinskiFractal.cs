using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.Sierpinski
{
    internal class SierpinskiFractal
    {
        public static void generate(PictureBox pb, Point p1, Point p2, Point p3, int levels, double width)
        {
            Queue<Item> que = new Queue<Item>();
            Item curr = new Item(p1, p2, p3);
            que.Enqueue(curr);
            while (que.Count > 0)
            {
                curr = que.Dequeue();
                if (curr.level >= levels){continue;}
                ++curr.level;

                Item sp1=curr;
                Item sp2=curr;
                Item sp3=curr;
            }
        }
    }
    internal class Item
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public int level { get; set; }


        public Item(int currlevel=0){ level = currlevel; }
        public Item(Point _p1, Point _p2, Point _p3, int currlevel=0) {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
            level = currlevel;
        }
    };
}
