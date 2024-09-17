using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static Fractalii.Form1;
using System.Security.Policy;
using System.Reflection.Metadata;
using static Fractalii.TreeFractal.QueueItems;


namespace Fractalii.TreeFractal
{
    public class treeFractal
    {
        // private variables
        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private double start_size = -1;
        private PictureBox p;

        // initialaze the global variables
        public void global_init(double saL, double saR, double s, PictureBox pic)
        {
            start_angle_left = saL;
            start_angle_right = saR;
            start_size = s;
            p = pic;
        }


        // a compact and reusable draw function
        private void draw(int coordonate_x_1, int coordonate_y_1, int coordonate_x_2, int coordonate_y_2)
        {
            using (Graphics g = p.CreateGraphics())
            {
                g.DrawLine(Pens.Red, new Point(coordonate_x_1, coordonate_y_1), new Point(coordonate_x_2, coordonate_y_2));
            }
        }

        private (int, int, double, double) calculation(int start_x, int start_y,
            double size, double angle,
            double start_angle_right, double start_angle_left)
        {
            // calculating the angles
            // calculating the coords for the next x and y
            return ((int)(start_x - size * Math.Cos(Math.PI * angle / 180)),
                (int)(start_y - size * Math.Sin(Math.PI * angle / 180)),
                angle + start_angle_left, angle - start_angle_right);
        }
        // recursive function
        public void Generate_fractal1(double size, int start_x, int start_y, double angle, int maxLevel)
        {
            double angleL, angleR;
            int end_x, end_y;
            (end_x, end_y, angleL, angleR) = calculation(start_x, start_y, size, angle, start_angle_right, start_angle_left);
            // line drawing
            draw(start_x, start_y, end_x, end_y);
            // decoment for much beautiful designe
            //if (start_size/10<=size) 
            if (maxLevel>0)
            {
                // recursive calls for left and right
                Thread.Sleep(2);
                Generate_fractal1(size * 0.90, end_x, end_y, angleL, maxLevel- 1);
                Generate_fractal1(size * 0.70, end_x, end_y, angleR, maxLevel- 1);
            }
        }


        // yeah I aint putting comments on this shit
        // I hate this function more then me so fuck it 
        // if you understand put comments on it but if not just leave it
        public void Generate_fractal2(double size, int start_x, int start_y, double angle, int maxLevel)
        {
            double angleL, angleR;
            int end_x, end_y;
            (end_x, end_y, angleL, angleR) = calculation(start_x, start_y, size, angle, start_angle_right, start_angle_left);
            Queue<QueueItems> queue = new Queue<QueueItems>();
            QueueItems QItem = new QueueItems(start_x, start_y, end_x, end_y, angle, 0, size);
            queue.Enqueue(QItem);

            int currentLevel = 0;
            while (queue.Count()>0)
            {
                QItem = queue.Dequeue();
                draw(QItem.start_x, QItem.start_y, QItem.end_x, QItem.end_y);
                if (currentLevel == QItem.level)
                {
                    Thread.Sleep(2);
                    currentLevel=QItem.level;
                }
                if (QItem.level > maxLevel)
                {
                    continue;
                }
                start_x = QItem.end_x;
                start_y = QItem.end_y;
                (end_x, end_y, angleL, angleR) = calculation(
                    QItem.end_x, QItem.end_y, QItem.size, QItem.angle, 
                    start_angle_right, start_angle_left);

                QItem.start_x = start_x;
                QItem.start_y = start_y;
                QItem.end_x = end_x; 
                QItem.end_y = end_y;

                size = QItem.size;


                QItem.angle = angleL;
                QItem.size = size * 0.90;
                queue.Enqueue(new QueueItems(QItem.start_x, QItem.start_y,
                    QItem.end_x, QItem.end_y,
                    QItem.angle, QItem.level+1, QItem.size));


                QItem.angle = angleR;
                QItem.size = size * 0.75;
                queue.Enqueue(new QueueItems(QItem.start_x, QItem.start_y,
                    QItem.end_x, QItem.end_y,
                    QItem.angle, QItem.level+1, QItem.size));
                
            }
        }
    }
}
