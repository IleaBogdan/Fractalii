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

        public static void Generate(PictureBox pb, int iterations,
                                  double width, int size, Point startPoint)
        {
            pen.Width = (float)width;

            List<string> sequences = new List<string>();
            string sequence = "F";
            sequences.Add(sequence); // Add initial state

            for (int i = 0; i < iterations; i++)
            {
                sequence = ApplyRules(sequence);
                sequences.Add(sequence);
            }

            // Draw each sequence separately
            foreach (var seq in sequences)
            {
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
            var points = new List<Point> { startPoint };
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