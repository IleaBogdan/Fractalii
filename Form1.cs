using System.Drawing;
using static Fractalii.RecFunction;

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
            pictureBox1.BackColor = Color.White;
        }
        // Variable that will hold the point from which to draw the next line
        Point latestPoint;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // Remember the location where the button was pressed
                latestPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    // Draw next line and...
                    g.DrawLine(Pens.Red, latestPoint, e.Location);

                    // ... Remember the location
                    latestPoint = e.Location;
                }
            }
        }
        double start_angle_left = 0.0, start_angle_right = 0.0, size = 0.0;
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
            size = Convert.ToDouble(textBox3.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RecFunction obj1 = new RecFunction();
            obj1.Generate_fractal1(start_angle_left, 
                start_angle_right, size, 
                pictureBox1, 0, 0);
        }
    }
}