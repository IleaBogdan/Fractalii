﻿namespace Fractalii
{
    internal class MathForms
    {
        public static double Point_Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
        public static Point Half(Point p1, Point p2)
        {
            return new Point((p1.X+p2.X)/2, (p1.Y+p2.Y)/2);
        }
    }
}
