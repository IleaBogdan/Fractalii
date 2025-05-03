using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 

namespace Fractalii.DragonCurve
{
    internal class dragoncurveFractal
    {
        private static Pen pen = new Pen(Color.Red, 1f);

        private static Point FromTo(Point p, int angle, int dist)
        {
            double rad = Math.PI * angle / 180.0;
            return new Point(
                p.X + (int)(dist * Math.Cos(rad)),
                p.Y + (int)(dist * Math.Sin(rad))
            );
        }

        private static Color initialColor, finalColor;

        private static int[] RGB = new int[3];
        private static double[] RGBDif = new double[3];
        private static void preDraw(int level, int maxLevel, double width)
        {
            pen.Width = (float)(width);

            float fraction = (float)level / (float)maxLevel;
            int green = RGB[1] + (int)(RGBDif[1] * fraction), red = RGB[0] + (int)(RGBDif[0] * fraction), blue = RGB[2] + (int)(RGBDif[2] * fraction);
            pen.Color = Color.FromArgb(red >= 0 && red <= 255 ? red : 0, green >= 0 && green <= 255 ? green : 0, blue >= 0 && blue <= 255 ? blue : 0);
        }
        public static void Generate(PictureBox pb, int iterations,
                                  double width, int size, Point startPoint)
        {
            pen.Width = (float)width;
            initialColor = HomePage.initialColor;
            finalColor = HomePage.finalColor;
            pen.Color = initialColor;
            RGB[0] = pen.Color.R;
            RGB[1] = pen.Color.G;
            RGB[2] = pen.Color.B;
            RGBDif[0] = finalColor.R - RGB[0];
            RGBDif[1] = finalColor.G - RGB[1];
            RGBDif[2] = finalColor.B - RGB[2];


            List<string> sequences = new();
            string sequence = "F";
            sequences.Add(sequence); 

            for (int i = 0; i < iterations; i++)
            {
                sequence = ApplyRules(sequence);
                sequences.Add(sequence);
            }

            int level = 0;
            foreach (string seq in sequences)
            {
                preDraw(level++, iterations, width);
                DrawSequence(pb, seq, startPoint, size);
                Thread.Sleep(500);
            }
        }

        private static string ApplyRules(string sequence)
        {
            // Rules:
            // F → F+G
            // G → F-G
            var result = new System.Text.StringBuilder();

            foreach (char c in sequence)
            {
                switch (c)
                {
                    case 'F':
                        result.Append("F+G");
                        break;
                    case 'G':
                        result.Append("F-G");
                        break;
                    default:
                        result.Append(c);
                        break;
                }
            }
            return result.ToString();
        }

        private static void DrawSequence(PictureBox pb, string sequence,
                                      Point startPoint, int stepLength)
        {
            List<Point> points = new() { startPoint };
            Point current = startPoint;
            int angle = 90;

            foreach (char c in sequence)
            {
                switch (c)
                {
                    case 'F':
                    case 'G':
                        current = FromTo(current, angle, stepLength);
                        points.Add(current);
                        break;
                    case '+':
                        angle += 90;
                        break;
                    case '-':
                        angle -= 90;
                        break;
                }
            }

            if (points.Count > 1)
            {
                Draw.draw_lines(pb, points.ToArray(), pen);
            }
        }
    }
}