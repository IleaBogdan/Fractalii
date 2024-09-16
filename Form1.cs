using System.Drawing;
using System.Windows.Forms;
using static Fractalii.treeFractal;
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
        private float size = -1f, width = 5f;

        // reading data only on click
        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, null, out start_angle_left);
            double.TryParse(textBox2.Text, null, out start_angle_right);
            float.TryParse(textBox3.Text, null, out size);

            // Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox1.Refresh();
            // check if all variables have been assigned
            if (start_angle_left >= 0.0 && start_angle_right>=0.0 && size>0)
            {
                // initialaze the global variables
                treeFractal fractal = new treeFractal(start_angle_left, start_angle_right);

                // first call of the recursive function
                fractal.Generate_fractal1(size, width, pictureBox1, 
                    pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2 + 200, 90, 0);
            } 
            else
            {
                // printing the invalide statemant
                using (Graphics g=pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates and size!", new System.Drawing.Font("Arial", 12), Brushes.Green, 
                        new PointF((pictureBox1.Size.Width / 2) -150, (pictureBox1.Size.Height / 2)-20));
                }
            }
        }
    }
}