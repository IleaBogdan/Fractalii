﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractalii.Sierpinski
{
    internal class SierpinskiFractal
    {
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

        private static Color initialColor, finalColor;
        private static int[] RGB = new int[3];
        private static double[] RGBDif = new double[3];
        private static Pen pen = new Pen(Color.Red, 3f);
        private static void preDraw(int level, int maxLevel, double width)
        {
            pen.Width = (float)(width);

            float fraction = (float)level / (float)maxLevel;
            int green = RGB[1] + (int)(RGBDif[1] * fraction), red = RGB[0] + (int)(RGBDif[0] * fraction), blue = RGB[2] + (int)(RGBDif[2] * fraction);
            pen.Color = Color.FromArgb(red >= 0 && red <= 255 ? red : 0, green >= 0 && green <= 255 ? green : 0, blue >= 0 && blue <= 255 ? blue : 0);
        }
        public static void generate(PictureBox pb, Point p1, Point p2, Point p3, int levels, double width)
        {
            initialColor = HomePage.initialColor;
            finalColor = HomePage.finalColor;
            pen.Color = initialColor;
            RGB[0] = pen.Color.R;
            RGB[1] = pen.Color.G;
            RGB[2] = pen.Color.B;
            RGBDif[0] = finalColor.R - RGB[0];
            RGBDif[1] = finalColor.G - RGB[1];
            RGBDif[2] = finalColor.B - RGB[2];
            pen =new Pen(Color.Red, (float)width);

            int currLevel = 0;
            Color befor=Color.Red;
            Queue<Item> que = new Queue<Item>();
            que.Enqueue(new Item(p1, p2, p3));
            while (que.Count > 0)
            {
                Item[] curr;
                if (que.Count>=3)
                {
                    curr = [que.Dequeue(), que.Dequeue(), que.Dequeue()];
                }
                else
                {
                    curr = [que.Dequeue()];
                }
                if (curr[0].level > currLevel)
                {
                    befor = pen.Color;
                    currLevel = curr[0].level;
                    Thread.Sleep(500);
                }
                preDraw(currLevel, levels, width);
                for (int i = 0; i < Math.Min(curr.Length, 3); ++i)
                {
                    if (currLevel != 0)
                    {
                        Draw.draw_line(pb, curr[i].ToDraw(i), pen);
                        Draw.draw_points(pb, curr[i].ToVec(), new Pen(befor, pen.Width));
                    }
                    else
                    {
                        Draw.draw_lines(pb, curr[0].ToVec(), pen);
                    }

                    if (curr[i].level >= levels) { continue; }
                    ++curr[i].level;

                    Item[] ncurrs = next(curr[i]);
                    for (int j = 0; j < 3; ++j) { que.Enqueue(ncurrs[j]); }
                }
            }
        }
    }
    internal class Item
    {
        public Pair<Point, Point> ToDraw(int i)
        {
            return new Pair<Point, Point>(p2, p3);
        }
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
