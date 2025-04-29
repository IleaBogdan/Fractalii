using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.KochLineFractal
{
    internal class SetupKoch
    {
        private static bool checker(
            int levels , double width
            )
        {
            return levels > 0 && levels < 8
                && width > 0.0;
        }
        public static void generate_kochLineFractal(
                PictureBox pb,
                Point start_point, Point stop_end, 
                int levels, double width,
                double reduction=1.0
            )
        {
            pb.Refresh();
            if (checker(levels, width))
            {
                kochFractal.generate_line(pb, start_point, stop_end, levels, width);
            } 
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels and width correctly!");
            }
        }
        public static void generate_kochSnowFractal(
            PictureBox pb,
            Point p1, Point p2, Point p3,
                int levels, double width,
                double reduction=1.0
            )
        {
            pb.Refresh();
            if (checker(levels, width))
            {
                Draw.draw_line(pb, p1, p2, new Pen(Color.Red, 3));
                Draw.draw_line(pb, p1, p3, new Pen(Color.Red, 3));
                Draw.draw_line(pb, p2, p3, new Pen(Color.Red, 3));
                
                //kochFractal.generate_snowflake(pb, p1, p2, p3, levels, width);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels and width correctly!");
            }
        }
    }
}
