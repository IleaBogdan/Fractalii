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
            int levels, double width
            )
        {
            return levels > 0 && levels < 8
                && width > 0.0;
        }
        public static void generate_kochLineFractal(
                PictureBox pb,
                Point start_point, Point stop_end, 
                int levels, double width
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
            Point b1, Point b2, Point b3,
            Point e1, Point e2, Point e3,
                int levels, double width
            )
        {
            pb.Refresh();
            if (checker(levels, width))
            {
                // cod pt generare
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels and width correctly!");
            }
        }
    }
}
