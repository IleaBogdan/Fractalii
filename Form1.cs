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
        // color setting
        public static Color initialColor = Color.Blue, finalColor = Color.Red;
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