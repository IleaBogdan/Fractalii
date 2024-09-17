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
        private double width = 5;


        private int[] RGB = new int[3];
        private double[] RGBDif = new double[3];
        Pen pen = new Pen(Color.Red, 1f);

        // initialaze the global variables
        public treeFractal(double saL, double saR, double s, PictureBox pic)
        {
            start_angle_left = saL;
            start_angle_right = saR;
            start_size = s;
            p = pic;

            //Hardcode here
            RGB[0] = pen.Color.R;
            RGB[1] = pen.Color.G;
            RGB[2] = pen.Color.B;
            RGBDif[2] = 255;
            RGBDif[0] = -255;
        }

        // a compact and reusable draw function
        private void draw(int coordonate_x_1, int coordonate_y_1, int coordonate_x_2, int coordonate_y_2)
        {
            using (Graphics g = p.CreateGraphics())
            {
                g.DrawLine(pen, new Point(coordonate_x_1, coordonate_y_1), new Point(coordonate_x_2, coordonate_y_2));
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
        private QueueItems calculate_end_point(QueueItems origin, double angle, double reduction)
        {
            QueueItems rez = new QueueItems();

            rez.start_x = origin.end_x;
            rez.start_y = origin.end_y;
            double size = origin.size * reduction;
            rez.angle = angle + origin.angle;
            rez.end_x = origin.end_x - (int)(size * Math.Cos(Math.PI * rez.angle/180));
            rez.end_y = origin.end_y - (int)(size * Math.Sin(Math.PI * rez.angle/180));
            rez.size = size;
            return rez;
        }
        // recursive function
        public void Generate_fractal1(double size, double width, int start_x, int start_y, double angle, int level, int maxLevel)
        {
            double angleL, angleR;
            int end_x, end_y;
            (end_x, end_y, angleL, angleR) = calculation(start_x, start_y, size, angle, start_angle_right, start_angle_left);

            // line drawing
            pen.Width = (float)(width);
            double fraction = (double)level / (double)maxLevel;
            pen.Color = Color.FromArgb(RGB[0] + (int)(RGBDif[0] * fraction), RGB[1] + (int)(RGBDif[1] * fraction),
                RGB[2] + (int)(RGBDif[2] * fraction));
            draw(start_x, start_y, end_x, end_y);
            // decoment for much beautiful designe
            //if (start_size/10<=size) 
            if (level < maxLevel)
            {
                // recursive calls for left and right
                //Thread.Sleep(2);
                Generate_fractal1(size * 0.9, width * 0.9, end_x, end_y, angleL, level + 1, maxLevel);
                Generate_fractal1(size * 0.7, width * 0.9, end_x, end_y, angleR, level + 1, maxLevel);
            }
        }


        // yeah I aint putting comments on this shit
        // I hate this function more then me so fuck it 
        // if you understand put comments on it but if not just leave it
        // anyways I put some comments 
        public void Generate_fractal2(double size, int start_x, int start_y, double angle, int maxLevel)
        {
            // vairables initialization
            QueueItems preStart=new QueueItems(0, 0, start_x, start_y, 0, 0, size);
            //(end_x, end_y, angleL, angleR) = calculation(start_x, start_y, size, angle, start_angle_right, start_angle_left);
            // queue declaration and first item added
            QueueItems Start=calculate_end_point(preStart, angle, 1);
            Start.level = 0;
            Queue<QueueItems> queue = new Queue<QueueItems>();
            QueueItems QItem; //= new QueueItems(start_x, start_y, end_x, end_y, angle, 0, size);
            queue.Enqueue(Start);

            // level count
            int currentLevel = 0;
            while (queue.Count() > 0)
            {
                // first item getting poped out
                QItem = queue.Dequeue();
                // draw function
                draw(QItem.start_x, QItem.start_y, QItem.end_x, QItem.end_y);

                if (currentLevel == QItem.level)
                {
                    Thread.Sleep(2);
                    currentLevel = QItem.level;
                }
                if (QItem.level >= maxLevel)
                {
                    continue;
                }

                QueueItems LeftBranch = calculate_end_point(QItem, start_angle_left, 0.90);
                QueueItems RightBranch = calculate_end_point(QItem, -start_angle_right, 0.75);
                LeftBranch.level = QItem.level+1;
                RightBranch.level = QItem.level+1;
                queue.Enqueue(LeftBranch); 
                queue.Enqueue(RightBranch);
                
                // variable overwriting


                //start_x = QItem.end_x;
                //start_y = QItem.end_y;
                //(end_x, end_y, angleL, angleR) = calculation(
                //    QItem.end_x, QItem.end_y, QItem.size, QItem.angle, 
                //    start_angle_right, start_angle_left);

                //size = QItem.size;
                //int tempLevel = QItem.level+1;
                //// adding new items into queue
                //QItem.Copy(start_x, start_y, end_x, end_y, size*0.90, tempLevel, angleL);
                //queue.Enqueue(new QueueItems(QItem));

                //QItem.Copy(start_x, start_y, end_x, end_y, size * 0.75, tempLevel, angleR);
                //queue.Enqueue(new QueueItems(QItem));
                
            }
        }
    }
}
