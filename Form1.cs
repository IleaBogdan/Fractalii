using Fractalii.TreeFractal;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
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
            if (Debugger.IsAttached) { AllocConsole(); }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public static Color bgC = Color.Black;


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = bgC;
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

        private void pictureBox1_2Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}