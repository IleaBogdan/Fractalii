using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.Sierpinski
{
    internal class SetupSierpinski
    {
        private static bool checker(int level, double width)
        {
            return level > 0 && width > 0.9;
        }
        public static void generate_sierpinski(PictureBox pb, Point p1, Point p2, Point p3, int levels, double width)
        {
            if (checker(levels, width))
            {

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels and width correctly!");
            }
        }
    }
}
