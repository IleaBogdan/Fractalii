namespace Fractalii.DragonCurve
{
    internal class dragoncurveSetup
    {
        private static bool checker(int levels, double width, int size)
        {
            //Console.WriteLine("add the uppercondition please");
            return levels>0 && width > 0 && size>0 &&
                   levels<16 && size<20;
        }
        public static void generate_dragoncurve(PictureBox pb, int levels, double width,
                                                int size, Point Start)
        {
            if (checker(levels, width, size))
            {
                pb.Refresh();
                dragoncurveFractal.Generate(pb, levels, width, size, Start);
            } else
            {
                System.Windows.Forms.MessageBox.Show("Please enter levels number correctly!");
            }
        }
    }
}
