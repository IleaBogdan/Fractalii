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

        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private int size = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, null, out start_angle_left);
            double.TryParse(textBox2.Text, null, out start_angle_right);
            Int32.TryParse(textBox3.Text, null, out size);

            // hardcodare la valori. NU UITA SA STERGI
            start_angle_left =25; start_angle_right=35; size = 50;
            pictureBox1.Refresh();
            if (start_angle_left >= 0.0 && start_angle_right>=0.0 && size>0)
            {
                treeFractal fractal = new treeFractal();
                
                fractal.global_init(start_angle_left, start_angle_right, size);

                fractal.Generate_fractal1(size, pictureBox1, 
                    pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2, 90, 0);
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