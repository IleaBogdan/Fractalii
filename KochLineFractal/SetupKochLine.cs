using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.KochLineFractal
{
    internal class SetupKochLine
    {
        private static bool checker(
            int levels, double width
            )
        {
            return levels > 0 && levels < 8
                && width > 0.0;
        }
        public static void generate_iterative(
                PictureBox pb,
                Point start_point, Point stop_end, 
                int levels, double width
            )
        {
            pb.Refresh();
            if (checker(levels, width))
            {
                kochLineFractal.generate_iterative(pb, start_point, stop_end, levels, width);
            } 
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels and width correctly!");
            }
        }
    }
}
