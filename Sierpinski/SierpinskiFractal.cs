using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.Sierpinski
{
    internal class SierpinskiFractal
    {
        private static Pen pen = new Pen(Color.Red, 3);
        
        private static Item[] next(Item curr)
        {
            return [
                new Item([curr.p1, 
                    MathForms.Half(curr.p1, curr.p2), 
                    MathForms.Half(curr.p1, curr.p3)], 
                curr.level + 1),
                
                new Item([curr.p2,
                    MathForms.Half(curr.p2, curr.p1),
                    MathForms.Half(curr.p2, curr.p3)], 
                curr.level+1),
                
                new Item([curr.p3,
                    MathForms.Half(curr.p3, curr.p1),
                    MathForms.Half(curr.p3, curr.p2)], 
                curr.level+1)
                ];
        }
        
        public static void generate(PictureBox pb, Point p1, Point p2, Point p3, int levels, double width)
        {
            pen.Width = (float)width;
            int currLevel = 0;
            Queue<Item> que = new Queue<Item>();
            Item curr = new Item(p1, p2, p3);
            que.Enqueue(curr);
            while (que.Count > 0)
            {
                curr = que.Dequeue();

                if (curr.level > currLevel)
                {
                    currLevel = curr.level;
                    Thread.Sleep(500);
                }

                Draw.draw_lines(pb, curr.ToVec(), pen);
                if (curr.level >= levels){continue;}
                ++curr.level;
                
                Item[] ncurrs=next(curr);
                for (int i = 0; i < 3; ++i){que.Enqueue(ncurrs[i]);}
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
        public Item(Point _p1, Point _p2, Point _p3, int _level = 0) {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
            level = _level;
        }
        public Item(Point[] ps, int _level)
        {
            p1 = ps[0];
            p2 = ps[1];
            p3 = ps[2];
            level = _level;
        }
        public Point[] ToVec(){return [p1, p2, p3, p1];}
    };
}
