namespace Fractalii.Sierpinski
{
    internal class SetupSierpinski
    {
        private static bool checker(int level, double width)
        {
            return level > 0 && level < 15;
        }
        public static void generate_sierpinski(PictureBox pb, Point p1, Point p2, Point p3, int levels, double width)
        {
            if (checker(levels, width))
            {
                pb.Refresh();
                SierpinskiFractal.generate(pb, p1, p2, p3, levels, width);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels number correctly!");
            }
        }
        public static void generate_sierpinskicarpet(PictureBox pb, 
            Point p1, Point p2, Point p3, Point p4,
            int levels, double width)
        {
            if (checker(levels, width))
            {
                pb.Refresh();
                //Point[] ps = [p1, p2, p3, p4, p1];
                //Draw.draw_lines(pb, ps, new Pen(Color.Red)); 
                SierpinskiFractal.generateCarpet(pb, p1, p2, p3, p4, levels, width);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels number correctly!");
            }
        }
    }
}
