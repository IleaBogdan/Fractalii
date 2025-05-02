using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalii.DragonCurve
{
    internal class dragoncurveSetup
    {
        private static bool checker(int levels, double width)
        {
            Console.WriteLine("add the uppercondition please");
            return levels>0 && width > 0;
        }
        public static void generate_dragoncurve(PictureBox pb, int levels, double width, Point Start)
        {
            if (checker(levels, width))
            {
                dragoncurveFractal.generate(pb, levels, width, Start);
            } else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels number correctly!");
            }
        }
    }
}
