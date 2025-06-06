﻿namespace Fractalii.TreeFractal
{
    public class treeFractal
    {
        // private variables
        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private PictureBox p;
        private Color initialColor, finalColor;

        private int[] RGB = new int[3];
        private double[] RGBDif = new double[3];
        Pen pen = new Pen(Color.Red, 1f);

        private static int currLevel = 0;
        // initialaze the global variables
        public treeFractal(double saL, double saR, double s, 
            Color initial_color, Color final_color, PictureBox pic)
        {
            // Setting parameters
            start_angle_left = saL;
            start_angle_right = saR;
            initialColor = initial_color;
            finalColor = final_color;
            p = pic;

            // Managing
            pen.Color = initialColor;
            RGB[0] = pen.Color.R;            
            RGB[1] = pen.Color.G;
            RGB[2] = pen.Color.B;
            RGBDif[0] = finalColor.R - RGB[0];
            RGBDif[1] = finalColor.G - RGB[1];
            RGBDif[2] = finalColor.B - RGB[2];


            currLevel = 0;
        }

        private void predraw(int level, int maxLevel, double width)
        {
            pen.Width = (float)(width);

            float fraction = (float)level / (float)maxLevel;
            int green = RGB[1] + (int)(RGBDif[1] * fraction), red = RGB[0] + (int)(RGBDif[0] * fraction), blue = RGB[2] + (int)(RGBDif[2] * fraction);
            pen.Color = Color.FromArgb(red>=0 && red<=255 ? red : 0, green>=0 && green<=255 ? green : 0, blue >= 0 && blue <= 255 ? blue : 0);
        }
        private TreeItem calculate_end_point(TreeItem origin, double angle, double reduction)
        {
            TreeItem rez = new TreeItem();

            rez.width = origin.width * reduction;
            rez.start_x = origin.end_x;
            rez.start_y = origin.end_y;
            double size = origin.size * reduction;
            rez.angle = angle + origin.angle;
            double rad = Math.PI * rez.angle / 180;
            rez.end_x = origin.end_x + (int)(size * Math.Cos(rad));
            rez.end_y = origin.end_y - (int)(size * Math.Sin(rad));
            rez.size = size;
            return rez;
        }
        // recursive function
        public void preGenerate(double size, double width, int start_x, int start_y, double angle,
            int level, int maxLevel, double reductionL, double reductionR)
        {
            currLevel = 0;
            predraw(level, maxLevel, width);
            Draw.draw_line(p, new Point(start_x, start_y), new Point(start_x, (int)(start_y - size)), pen);
            Generate_fractal1(size, width, start_x, (int)(start_y - size), angle, level+1, maxLevel, reductionL, reductionR);
        }
        public void Generate_fractal1(double size, double width, 
            int start_x, int start_y, double angle, 
            int level, int maxLevel, double reductionL, double reductionR)
        {
            predraw(level, maxLevel, width);

            // right
            TreeItem rezR = calculate_end_point(new TreeItem(0, 0, 
                start_x, start_y, angle, level, size, width), -start_angle_right, reductionR);
            Draw.draw_line(p, new Point(rezR.start_x, rezR.start_y), 
                new Point(rezR.end_x, rezR.end_y), pen);
            if (level<maxLevel) Generate_fractal1(size * reductionR, 
                width * reductionR, rezR.end_x, rezR.end_y, 
                rezR.angle, level + 1, maxLevel, reductionL, reductionR);


            predraw(level, maxLevel, width);
            // left
            TreeItem rezL = calculate_end_point(new TreeItem(0, 0, 
                start_x, start_y, angle, level, size, width), start_angle_left, reductionL);
            Draw.draw_line(p, new Point(rezL.start_x, rezL.start_y), 
                new Point(rezL.end_x, rezL.end_y), pen);
            if (level<maxLevel) Generate_fractal1(size * reductionL, 
                width * reductionL, rezL.end_x, rezL.end_y, 
                rezL.angle, level + 1, maxLevel, reductionL, reductionR);
        }


        // yeah I aint putting comments on this shit
        // I hate this function more then me so fuck it 
        // if you understand put comments on it but if not just leave it
        // anyways I put some comments 
        public void Generate_fractal2(double size, double width, int start_x, int start_y, double angle, int maxLevel, double reductionL, double reductionR)
        {
            // vairables initialization
            TreeItem preStart = new TreeItem(0, 0, start_x, start_y, 0, 0, size, width);
            //(end_x, end_y, angleL, angleR) = calculation(start_x, start_y, size, angle, start_angle_right, start_angle_left);
            // queue declaration and first item added
            TreeItem Start = calculate_end_point(preStart, angle, 1);
            Start.level = 0;
            Queue<TreeItem> queue = new Queue<TreeItem>();
            TreeItem QItem; //= new QueueItems(start_x, start_y, end_x, end_y, angle, 0, size);
            queue.Enqueue(Start);
            currLevel = 0;
            while (queue.Count() > 0)
            {
                // first item getting poped out
                QItem = queue.Dequeue();
                // draw function

                predraw(QItem.level, maxLevel, QItem.width);
                Draw.draw_line(p, new Point(QItem.start_x, QItem.start_y), 
                    new Point(QItem.end_x, QItem.end_y), pen);

                if (currLevel > QItem.level)
                {
                    if (maxLevel<=8)Thread.Sleep(512);
                    currLevel = QItem.level;
                }
                if (QItem.level >= maxLevel)
                {
                    continue;
                }

                TreeItem LeftBranch = calculate_end_point(QItem, start_angle_left, reductionL);
                TreeItem RightBranch = calculate_end_point(QItem, -start_angle_right, reductionR);
                LeftBranch.level = QItem.level + 1;
                RightBranch.level = QItem.level + 1;
                queue.Enqueue(LeftBranch); 
                queue.Enqueue(RightBranch);
            }
        }
    }
}
