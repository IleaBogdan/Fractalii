using System;
using System.Collections.Generic;
using System.Formats.Asn1;
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
        private static double A = -1;
        private static int Precision = -1, B = -1;
        private const int sleepTime = 100;
        private const int zoom = 5;
        private static double zoomFactor = 1;
        private static Point Origin = new Point(0, 0), oldOrigin = new Point(0, 0);
        private static int MouseRX = 0, MouseRY = 0;
        public static void getPictureBox(PictureBox pb)
        {
            pictureBox = pb;
            Origin = new Point(pb.Width, pb.Height);
            oldOrigin = new Point(pb.Width / 2, pb.Height / 2);
        }
        public static void getMouseRClick(int x, int y)
        {
            MouseRX = x;
            MouseRY = y;
            Zoom();
        }
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
                Precision = precision; A = a; B = b;
                DrawWeierstrassFunction(Origin, precision, a, b);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter the parameters correctly!");
            }
        }
        public static void NOscillate(PictureBox pb, double a, int b)
        {
            if (ValidWeierstrass(a, b))
            {
                pb.Refresh();
                int maxP = 7;
                for (int precision = 1; precision <= maxP; precision++)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(Origin, precision, a, b);
                    Thread.Sleep(sleepTime);
                }
                for (int precision = maxP - 1; precision > 0; precision--)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(Origin, precision, a, b);
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
            if (ValidWeierstrass(precision, b))
            {
                pb.Refresh();
                double minA = 0;
                double maxA = 1;
                for (double tA = minA; tA <= maxA; tA += .1)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(Origin, precision, tA, b);
                    Thread.Sleep(sleepTime);
                }
                for (double tA = maxA - .1; tA >= minA; tA -= .1)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(Origin, precision, tA, b);
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
                int minB = Math.Max(b - 5, 3);
                int maxB = minB + 10;
                for (int tB = minB; tB <= maxB; tB++)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(Origin, precision, a, tB);
                    Thread.Sleep(sleepTime);
                }
                for (int tB = maxB - 1; tB >= minB; tB--)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(Origin, precision, a, tB);
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
            zoomFactor = 1;
            oldOrigin = new Point(Origin.X/2, Origin.Y/2);
            double scaleX = 100.0; // Scale for x-axis
            double scaleY = 100.0; // Scale for y-axis
            PointF[] points = new PointF[pictureBox.Width];
            for (int px = 0; px < pictureBox.Width; px++)
            {
                double x = (px - pictureBox.Width / 2) / scaleX;
                double y = Calculate(x, a, b, maxN);
                points[px] = new PointF(px, (float)(height / 2 - y * scaleY));
            }
            return points;
        }

        private static void DrawWeierstrassFunction(Point origin, int maxN, double a, int b)
        {
            PointF[] points = GenerateWeierstrassPoints(origin.X, origin.Y, a, b, maxN);
            Draw.draw_lines(pictureBox, points, pen);
        }

        private static void Zoom()
        {
            Point newOrigin = new Point(MouseRX, MouseRY);
            pictureBox.Refresh();
            /// REMEMBER TO USE ZOOM VARIABLE CORRECTLY
            DrawZoomFunction(newOrigin, Precision, A, B);
        }
        private static void DrawZoomFunction(Point origin, int maxN, double a, int b)
        {
            PointF[] points = GenerateZoomPoints(origin.X, origin.Y, a, b, maxN);
            Draw.draw_lines(pictureBox, points, pen);
            Draw.draw_line(pictureBox, new Point(pictureBox.Width/2, 0), new Point(pictureBox.Width/2, pictureBox.Height), pen);
        }
        private static PointF[] GenerateZoomPoints(int width, int height, double a, int b, int maxN)
        {
            double scaleX = 100.0; // Scale for x-axis
            double scaleY = 100.0; // Scale for y-axis
            zoomFactor *= zoom;
            PointF[] points = new PointF[pictureBox.Width];
            for (int px = 0; px < pictureBox.Width; px++)
            {
                double x = (px - oldOrigin.X - pictureBox.Width / 2 + width) / scaleX / zoomFactor;
                double y = Calculate(x, a, b, maxN);
                points[px] = new PointF(px, (float)(pictureBox.Height - y * scaleY - height));
            }
            oldOrigin = new Point(oldOrigin.X + pictureBox.Width / 2 - width, height);
            return points;
        }
    }
}
