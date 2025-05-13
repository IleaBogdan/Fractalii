using Fractalii.KochLineFractal;
using Fractalii.Sierpinski;
using Fractalii.Weierstrass_Function;
using Fractalii.TreeFractal;
using Fractalii.Weierstrass_Function;
using Fractalii.DragonCurve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Fractalii
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            //debug();
        }
        private PictureBox pb;
        public void SetSelectedTab(int index)
        {
            if (index >= 0 && index < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = index;
            }
        }
        public void SetSelectedTab(int index, HomePage home, UserControl1 u1)
        {
            if (index >= 0 && index < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = index;
                home.SetText(HomePage.def + u1.tabControl1.Text);
            }
        }

        public void set_pictureBox(PictureBox p)
        {
            pb = p;
        }

        // Tree Fractal
        private void default_button_Click_treeFractal(object sender, EventArgs e)
        {
            //Console.WriteLine("tree");
            textBox_angle_left_tab1.Text = "60";
            textBox_angle_right_tab1.Text = "30";
            textBox_size_tab1.Text = "60";
            textBox_levels_tab1.Text = "12";
            textBox_width_tab1.Text = "5";
            textBox_reduction_left_tab1.Text = "75";
            textBox_reduction_right_tab1.Text = "90";
        }
        private void generate_treeFractal_recursive(object sender, EventArgs e)
        {
            double start_angle_left = -1.0, start_angle_right = -1.0;
            double size = -1.0, width = -1.0;
            int levels = -1, redL = 0, redR = 0;

            double.TryParse(textBox_angle_left_tab1.Text, null, out start_angle_left);
            double.TryParse(textBox_angle_right_tab1.Text, null, out start_angle_right);
            double.TryParse(textBox_size_tab1.Text, null, out size);
            Int32.TryParse(textBox_levels_tab1.Text, null, out levels);
            double.TryParse(textBox_width_tab1.Text, null, out width);
            Int32.TryParse(textBox_reduction_left_tab1.Text, null, out redL);
            Int32.TryParse(textBox_reduction_right_tab1.Text, null, out redR);
            SetupTree.generate_treeFractal_recursive(pb, start_angle_left, start_angle_right, size, width, levels, redL, redR, HomePage.initialColor, HomePage.finalColor);
        }

        private void generate_treeFractal_iterative(object sender, EventArgs e)
        {
            double start_angle_left = -1.0, start_angle_right = -1.0;
            double size = -1.0, width = -1.0;
            int levels = -1, redL = 0, redR = 0;

            double.TryParse(textBox_angle_left_tab1.Text, null, out start_angle_left);
            double.TryParse(textBox_angle_right_tab1.Text, null, out start_angle_right);
            double.TryParse(textBox_size_tab1.Text, null, out size);
            Int32.TryParse(textBox_levels_tab1.Text, null, out levels);
            double.TryParse(textBox_width_tab1.Text, null, out width);
            Int32.TryParse(textBox_reduction_left_tab1.Text, null, out redL);
            Int32.TryParse(textBox_reduction_right_tab1.Text, null, out redR);
            SetupTree.generate_treeFractal_iterative(pb, start_angle_left, start_angle_right, size, width, levels, redL, redR, HomePage.initialColor, HomePage.finalColor);
        }


        // Koch-Line
        private void default_button_Click_KochLine(object sender, EventArgs e)
        {
            levels_KochLine.Text = "6";
            width_KochLine.Text = "5";
            textBox1.Text = "1.0";
        }
        private void generate_kochLineFractal(object sender, EventArgs e)
        {
            int levels = -1;
            double width = -1;
            Int32.TryParse(levels_KochLine.Text, null, out levels);
            Double.TryParse(width_KochLine.Text, null, out width);
            const int minus = 125;
            Point start_point = new Point(0, pb.Height - minus), stop_point = new Point(pb.Width, pb.Height - minus);
            SetupKoch.generate_kochLineFractal(pb, start_point, stop_point, levels, width);
        }



        // Koch-Snowflake
        private void default_button_Click_KochSnow(object sender, EventArgs e)
        {
            KochSnowLevels.Text = "6";
            KochSnowWidth.Text = "5";
            textBox2.Text = "1.0";
        }
        private void generate_kochSnowFractal(object sender, EventArgs e)
        {
            int levels = -1;
            double width = -1;
            Int32.TryParse(KochSnowLevels.Text, null, out levels);
            Double.TryParse(KochSnowWidth.Text, null, out width);
            int offset = pb.Height / 10 - 15;
            Point p1 = new Point(pb.Width / 3, offset + pb.Height / 5);
            Point p2 = new Point((pb.Width / 3) * 2, offset + pb.Height / 5);
            Point p3 = new Point(pb.Width / 2, offset + (int)((double)(pb.Width / 3.0) * 0.866025) + pb.Height / 5);
            SetupKoch.generate_kochSnowFractal(pb,
                p1, p2, p3,
                levels, width);
        }

        private void CallWeierstrass(object sender, EventArgs e)
        {
            int precision = -1;
            Int32.TryParse(WeierstrassPrecision.Text, null, out precision);
            Weierstrass.CheckWeierstrassFunction(pb, precision);
        }

        private void default_button_Click_Sierpinski(object sender, EventArgs e)
        {
            SierpinskiLevels.Text = "11";
        }
        private void generate_sierpinski(object sender, EventArgs e)
        {
            int levels = -1;
            const double width = 3;
            Int32.TryParse(SierpinskiLevels.Text, null, out levels);
            int offset = pb.Height / 2;
            Point p1 = default(Point), p2 = default(Point), p3 = default(Point);
            if (FlipSierpinski.Checked)
            {
                p1 = new Point(pb.Width / 3, pb.Height / 5);
                p2 = new Point((pb.Width / 3) * 2, pb.Height / 5);
                p3 = new Point(pb.Width / 2, (int)((double)(pb.Width / 3.0) * 0.866025) + pb.Height / 5);
            }
            else
            {
                p1 = new Point(pb.Width / 3, pb.Height / 5 + (int)((double)(pb.Width / 3.0) * 0.866025));
                p2 = new Point((pb.Width / 3) * 2, pb.Height / 5 + (int)((double)(pb.Width / 3.0) * 0.866025));
                p3 = new Point(pb.Width / 2, pb.Height / 5);
            }
            SetupSierpinski.generate_sierpinski(pb, p1, p2, p3, levels, width);
        }


        private void default_button_Click_DragonCurve(object sender, EventArgs e) 
        {
            dragoncurvetextbox.Text = "14";
            dragonSize.Text = "5";
        }
        private void generate_dragoncurve(object sender, EventArgs e)
        {
            int levels = -1, size=-1;
            double width = -1.0;
            Int32.TryParse(dragoncurvetextbox.Text, out levels);
            Int32.TryParse(dragonSize.Text, out size);
            width = 3;
            Console.WriteLine("remove hardcoded width");
            dragoncurveSetup.generate_dragoncurve(pb, levels, width, size,
                new Point (pb.Width/2, pb.Height/2));
        }

        // default press for anything
        // for new tabs add them at the end please
        public static void default_pressed(object sender, EventArgs e, UserControl1 u1)
        {
            int val = u1.tabControl1.SelectedIndex;
            switch (val)
            {
                case 0:
                    u1.default_button_Click_treeFractal(sender, e);
                    break;
                case 1:
                    u1.default_button_Click_KochLine(sender, e);
                    break;
                case 2:
                    u1.default_button_Click_KochSnow(sender, e);
                    break;
                case 3:
                    break;
                case 4:
                    u1.default_button_Click_Sierpinski(sender, e);
                    break;
                case 5:
                    u1.default_button_Click_DragonCurve(sender, e);
                    break;
                default:
                    break;
            }
        }
        public static void Generate(object sender, EventArgs e, UserControl1 u1)
        {
            int val = u1.tabControl1.SelectedIndex;
            switch (val)
            {
                case 0:
                    u1.generate_treeFractal_iterative(sender, e);
                    break;
                case 1:
                    u1.generate_kochLineFractal(sender, e);
                    break;
                case 2:
                    u1.generate_kochSnowFractal(sender, e);
                    break;
                case 3:
                    break;
                case 4:
                    u1.generate_sierpinski(sender, e);
                    break;
                case 5:
                    u1.generate_dragoncurve(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
