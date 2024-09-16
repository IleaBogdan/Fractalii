using System.Drawing;
using System.Windows.Forms;
using static Fractalii.lineFractal;
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

        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private int size = -1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            start_angle_left = Convert.ToDouble(textBox1.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            start_angle_right = Convert.ToDouble(textBox2.Text);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBox3.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            if (start_angle_left >= 0.0 && start_angle_right>=0.0 && size>0)
            {
                lineFractal fractal = new lineFractal();
                fractal.global_init(start_angle_left, start_angle_right, size);
                fractal.Generate_fractal1(start_angle_left,
                    start_angle_right, size, pictureBox1, 
                    pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2);
            } 
            else
            {
                using (Graphics g=pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates and size!", new System.Drawing.Font("Arial", 12), Brushes.Green, 
                        new PointF((pictureBox1.Size.Width / 2) -150, (pictureBox1.Size.Height / 2)-20));
                }
            }
        }
    }
}