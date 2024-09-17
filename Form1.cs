using Fractalii.TreeFractal;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static Fractalii.TreeFractal.treeFractal;
using static System.Net.Mime.MediaTypeNames;

namespace Fractalii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        // private variables 
        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private double size = -1.0;
        private int levels = -1;


        private (double, double, double, int) get_data()
        {
            double angleL, angleR, Size;
            int Level;
            double.TryParse(textBox1.Text, null, out angleL);
            double.TryParse(textBox2.Text, null, out angleR);
            double.TryParse(textBox3.Text, null, out Size);
            Int32.TryParse(textBox4.Text, null, out Level);
            return (angleL, angleR, Size, Level);
        }
        private bool condition()
        {
            return start_angle_left >= 0.0 && start_angle_right >= 0.0 && size > 0 && levels != -1 && levels < 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (start_angle_left, start_angle_right, size, levels) = get_data();
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox1.Refresh();
            // check if all variables have been assigned
            if (condition())
            {
                treeFractal fractal = new treeFractal();

                // initialaze the global variables
                fractal.global_init(start_angle_left, start_angle_right, size, pictureBox1);

                // first call of the recursive function
                fractal.Generate_fractal1(size, pictureBox1.Size.Width / 2, 
                    pictureBox1.Size.Height / 2 + 100, 90, levels);
            }
            else
            {
                // printing the invalide statemant
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates, size and levels correctly!", 
                        new System.Drawing.Font("Arial", 12), Brushes.Green,
                        new PointF((pictureBox1.Size.Width / 2) - 175, (pictureBox1.Size.Height / 2) - 20));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (start_angle_left, start_angle_right, size, levels) = get_data();
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox1.Refresh();
            // check if all variables have been assigned
            if (condition())
            {
                treeFractal fractal = new treeFractal();

                // initialaze the global variables
                fractal.global_init(start_angle_left, start_angle_right, size, pictureBox1);

                // first call of the recursive function
                fractal.Generate_fractal2(size, pictureBox1.Size.Width / 2, 
                    pictureBox1.Size.Height / 2 + 100, 90, levels);
            }
            else
            {
                // printing the invalide statemant
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates, size and levels correctly!", 
                        new System.Drawing.Font("Arial", 12), Brushes.Green,
                        new PointF((pictureBox1.Size.Width / 2) - 175, (pictureBox1.Size.Height / 2) - 20));
                }
            }
        }
    }
}