using Fractalii.TreeFractal;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Fractalii
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
            userControl11.set_pictureBox(pictureBox1);
        }
    }
}