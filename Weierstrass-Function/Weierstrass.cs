namespace Fractalii.Weierstrass_Function
{
    internal class Weierstrass
    {
        private static PictureBox pictureBox = default(PictureBox);
        private static Pen pen = new Pen(Color.Red, 1f);
        private static double A = -1;
        private static int Precision = -1, B = -1;
        private static double scaleX = 100.0, scaleY = 100.0;
        private static double worldCenterX = 0.0;
        private static double worldCenterY = 0.0;
        private const int sleepTime = 100;
        private const int zoom = 5;
        private static double zoomFactor = 1;
        private static int MouseRX = 0, MouseRY = 0;
        public static void getPictureBox(PictureBox pb)
        {
            pictureBox = pb;

            zoomFactor = 1.0;
            worldCenterX = 0.0;
            worldCenterY = 0.0;
        }
        public static void getMouseRClick(int x, int y)
        {
            pen.Color=HomePage.initialColor;
            MouseRX = x;
            MouseRY = y;

            // 1) Inverse‐map this click to world coords *relative* to the current center:
            //    ΔworldX = (screenX - pictureBox.Width/2) / (scaleX * zoomFactor)
            double deltaWorldX = (MouseRX - pictureBox.Width / 2.0)
                                 / (scaleX * zoomFactor);
            double deltaWorldY = ((pictureBox.Height / 2.0) - MouseRY)
                                 / (scaleY * zoomFactor);

            // 2) Accumulate it onto the *existing* center:
            worldCenterX += deltaWorldX;
            worldCenterY += deltaWorldY;

            // 3) Only now bump the zoom
            zoomFactor *= zoom;

            // 4) Redraw
            pictureBox.Refresh();
            DrawZoomFunction(300, A, B);
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
            pen.Color=HomePage.initialColor;
            if (ValidWeierstrass(precision, a, b))
            {
                zoomFactor = 1.0;
                worldCenterX = 0.0;
                worldCenterY = 0.0;
                MouseRX = pictureBox.Width / 2;
                MouseRY = pictureBox.Height / 2;
                pb.Refresh();
                Precision = precision; A = a; B = b;
                DrawWeierstrassFunction(precision, a, b);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter the parameters correctly!");
            }
        }
        public static void NOscillate(PictureBox pb, double a, int b)
        {
            pen.Color=HomePage.initialColor;
            if (ValidWeierstrass(a, b))
            {
                pb.Refresh();
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
            pen.Color=HomePage.initialColor;
            if (ValidWeierstrass(precision, b))
            {
                pb.Refresh();
                double minA = 0;
                double maxA = 1;
                for (double tA = minA; tA <= maxA; tA += .1)
                {
                    pictureBox.Refresh();
                    DrawWeierstrassFunction(precision, tA, b);
                    Thread.Sleep(sleepTime);
                }
                for (double tA = maxA - .1; tA >= minA; tA -= .1)
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
            pen.Color=HomePage.initialColor;
            if (ValidWeierstrass(precision, a, b))
            {
                pb.Refresh();
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

        private static PointF[] GenerateWeierstrassPoints(double a, int b, int maxN)
        {
            pen.Color=HomePage.initialColor;
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            zoomFactor = 1;
            PointF[] points = new PointF[pictureBox.Width];
            for (int px = 0; px < pictureBox.Width; px++)
            {
                double x = (px - pictureBox.Width / 2) / scaleX;
                double y = Calculate(x, a, b, maxN);
                points[px] = new PointF(px, (float)(height / 2 - y * scaleY));
            }
            return points;
        }

        private static void DrawWeierstrassFunction(int maxN, double a, int b)
        {
            pen.Color=HomePage.initialColor;
            PointF[] points = GenerateWeierstrassPoints(a, b, maxN);
            Draw.draw_lines(pictureBox, points, pen);
        }
        private static void DrawZoomFunction(int maxN, double a, int b)
        {
            pen.Color=HomePage.initialColor;
            var points = GenerateZoomPoints(a, b, maxN);
            Draw.draw_lines(pictureBox, points, pen);
        }
        private static PointF[] GenerateZoomPoints(double a, int b, int maxN)
        {
            pen.Color=HomePage.initialColor;
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            var pts = new PointF[width];
            for (int px = 0; px < width; px++)
            {
                // 1) map pixel to world X, using worldCenterX
                double worldX = ((px - (width / 2.0)) / (scaleX * zoomFactor)) + worldCenterX;

                // 2) compute Weierstrass at that X
                double yVal = Calculate(worldX, a, b, maxN);

                // 3) map back to screen Y
                //    worldY → (pictureBox.Height/2) - (worldY*scaleY*zoomFactor)
                float screenY = (float)((height / 2.0) - ((yVal - worldCenterY) * scaleY * zoomFactor));

                pts[px] = new PointF(px, screenY);
            }

            return pts;
        }
    }
}
