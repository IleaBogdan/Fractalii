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
        public static void CheckWeierstrassFunction(PictureBox pb, int precision, double a, int b)
        {
            if (precision > 0)
            {
                pb.Refresh();
                pictureBox = pb;
                DrawWeierstrassFunction(precision, a, b);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels and width correctly!");
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
            double scaleX = 100.0; // Scale for x-axis
            double scaleY = 100.0; // Scale for y-axis
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
