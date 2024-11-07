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
            pictureBox_treeFractal.BackColor = Color.Black;
            pictureBox_kochline.BackColor = Color.Black;
            ucTree.set_pictureBox(pictureBox_treeFractal);
            ucKochLine.set_pictureBox(pictureBox_kochline);
        }
    }
}