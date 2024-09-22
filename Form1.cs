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
            debbug();
        }

        // private variables 
        private double start_angle_left = -1.0, start_angle_right = -1.0;
        private double size = -1.0, width = -1.0;
        private int levels = -1, redL = 0, redR = 0;

        private Color initialColor = Color.Red, finalColor = Color.Red;

        private (double, double, double, int, double, int, int) get_data()
        {
            double angleL, angleR, Size, Width;
            int Level, rL, rR;
            double.TryParse(textBox1.Text, null, out angleL);
            double.TryParse(textBox2.Text, null, out angleR);
            double.TryParse(textBox3.Text, null, out Size);
            Int32.TryParse(textBox4.Text, null, out Level);
            double.TryParse(textBox5.Text, null, out Width);
            Int32.TryParse(textBox6.Text, null, out rL);
            Int32.TryParse(textBox7.Text, null, out rR);



            return (angleL, angleR, Size, Level, Width, rL, rR);
        }
        private bool condition()
        {
            return start_angle_left > 0.0 && start_angle_right > 0.0
                && size > 0 && levels > 0 && levels < 15 && width > 0 && width < 7
                && redL > 0 && redR > 0 && redR < 100 && redL < 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (start_angle_left, start_angle_right, size, levels, width, redL, redR) = get_data();
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox1.Refresh();
            // check if all variables have been assigned
            if (condition())
            {
                // initialaze the global variables
                treeFractal fractal = new treeFractal(start_angle_left, start_angle_right, size, initialColor, finalColor, pictureBox1);

                // first call of the recursive function
                fractal.preGenerate(size, width, pictureBox1.Size.Width / 2,
                    pictureBox1.Size.Height / 2 + 150, 90, 0, levels, (double)(redL) / 100, (double)(redR) / 100);
            }
            else
            {
                // invalide statemant popup
                System.Windows.Forms.MessageBox.Show("Please enter all coordinates, size, width, reduction and levels correctly!");
                /*// printing the invalide statemant
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates, size, width, reduction and levels correctly!", 
                        new System.Drawing.Font("Arial", 12), Brushes.Green,
                        new PointF((pictureBox1.Size.Width / 2) - 175, (pictureBox1.Size.Height / 2) - 20));
                }*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (start_angle_left, start_angle_right, size, levels, width, redL, redR) = get_data();
            // .Refresh erases anything on pictureBox1 if we want to redraw
            pictureBox1.Refresh();
            // check if all variables have been assigned
            if (condition())
            {
                treeFractal fractal = new treeFractal(start_angle_left, start_angle_right, size, initialColor, finalColor, pictureBox1);


                // first call of the recursive function
                fractal.Generate_fractal2(size, width, pictureBox1.Size.Width / 2,
                    pictureBox1.Size.Height / 2 + 150, 90, levels, (double)(redL) / 100, (double)(redR) / 100);
            }
            else
            {
                // invalide statemant popup
                System.Windows.Forms.MessageBox.Show("Please enter all coordinates, size, width, reduction and levels correctly!");
                /*// printing the invalide statemant
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString("Please enter all coordinates, size, width, reduction and levels correctly!", 
                        new System.Drawing.Font("Arial", 12), Brushes.Green,
                        new PointF((pictureBox1.Size.Width / 2) - 175, (pictureBox1.Size.Height / 2) - 20));
                }*/
            }
        }

        private void default_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "30";
            textBox2.Text = "60";
            textBox3.Text = "60";
            textBox4.Text = "12";
            textBox5.Text = "5";
            textBox6.Text = "90";
            textBox7.Text = "75";
            initialColor= Color.Green;
            finalColor = Color.Blue;
        }

        private void initialColorSelect_Click(object sender, EventArgs e)
        {
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                initialColor = colorSelector.setColor;
            }
        }

        private void finalColorSelect_Click(object sender, EventArgs e)
        {
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                finalColor = colorSelector.setColor;
            }
        }
    }
}