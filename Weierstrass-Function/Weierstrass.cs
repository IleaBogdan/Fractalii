using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractalii.Weierstrass_Function
{
    internal class Weierstrass
    {
        private static PictureBox pictureBox = default(PictureBox);
        private static Pen pen = new Pen(Color.Red, 1f);
        const int sleepTime = 100;
        private static bool ValidWeierstrass(int precision, double a, int b)
        {
            if (precision < 0 || a < 0 || a > 1 || b < 2) return false;
            return true;
        }
        private static bool ValidWeierstrass(double a, int b)
        {
            if (a < 0 || a > 1 || b < 2) return false;
            return true;
        }
        private static bool ValidWeierstrass(int precision, int b)
        {
            if (precision < 0 || b < 2) return false;
            return true;
        }
        public static void CheckWeierstrassFunction(PictureBox pb, int precision, double a, int b)
        {
            if (ValidWeierstrass(precision, a, b))
            {
                pb.Refresh();
                pictureBox = pb;
                DrawWeierstrassFunction(precision, a, b);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter the parameters correctly!");
            }
        }
        public static void NOscillate(PictureBox pb, double a, int b)
        {
            if(ValidWeierstrass(a, b))
            {
                pb.Refresh();
                pictureBox = pb;
                int maxP = 7;
                for (int precision = 1; precision <= maxP; precision++)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(precision, a, b);
                    Thread.Sleep(sleepTime);
                }
                for (int precision = maxP - 1; precision > 0; precision--) 
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(precision, a, b);
                    Thread.Sleep(sleepTime);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter the parameters correctly!");
            }
        }
        public static void AOscillate(PictureBox pb, int precision, double a, int b)
        {
            if(ValidWeierstrass(precision, b))
            {
                pb.Refresh();
                pictureBox = pb;
                double minA = 0;
                double maxA = 1;
                for (double tA = minA; tA <= maxA; tA += .1)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(precision, tA, b);
                    Thread.Sleep(sleepTime);
                }
                for (double tA = maxA - .1 ; tA >= minA; tA -= .1) 
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(precision, tA, b);
                    Thread.Sleep(sleepTime);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter the parameters correctly!");
            }
        }
        public static void BOscillate(PictureBox pb, int precision, double a, int b)
        {
            if (ValidWeierstrass(precision, a, b))
            {
                pb.Refresh();
                pictureBox = pb;
                int minB = Math.Max(b - 5, 3);
                int maxB = minB + 10;
                for (int tB = minB; tB <= maxB; tB++)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(precision, a, tB);
                    Thread.Sleep(sleepTime);
                }
                for (int tB = maxB - 1; tB >= minB; tB--) 
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(precision, a, tB);
                    Thread.Sleep(sleepTime);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter the parameters correctly!");
            }
        }
        private static double Calculate(double x, double a, int b, int maxN)
        {
            double sum = 0.0;
            for (int n = 0; n < maxN; n++)
            {
                sum += Math.Pow(a, n) * Math.Cos(Math.Pow(b, n) * Math.PI * x);
            }
            return sum;
        }

        private static PointF[] GenerateWeierstrassPoints(int width, int height, double a, int b, int maxN)
        {
            double scaleX = 150.0; // Scale for x-axis
            double scaleY = 150.0; // Scale for y-axis
            PointF[] points = new PointF[pictureBox.Width];
            for (int px = 0; px < pictureBox.Width; px++)
            {
                double x = (px - pictureBox.Width / 2) / scaleX;
                double y = Calculate(x, a, b, maxN);
                points[px] = new PointF(px, (float)(pictureBox.Height / 2 - y * scaleY));
            }
            return points;
        }

        private static void DrawWeierstrassFunction(int maxN, double a, int b)
        {
            PointF[] points = GenerateWeierstrassPoints(pictureBox.Width, pictureBox.Height, a, b, maxN);
            Draw.draw_lines(pictureBox, points, pen);
        }
    }
}
