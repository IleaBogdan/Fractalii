using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractalii.KochLineFractal
{
    public partial class UserControlKochLine : UserControl
    {
        public UserControlKochLine()
        {
            InitializeComponent();
        }

        private PictureBox pictureBox_kochline;
        public void set_pictureBox(PictureBox pictureBox)
        {
            pictureBox_kochline = pictureBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int level;
            Int32.TryParse(textBox1.Text, null, out level);
            Point start_koch = new Point(100, 200), stop_koch=new Point(150, 350);
            kochLineFractal.init(pictureBox_kochline, level
                // more params to come
                );
            kochLineFractal.iterative_fractal(start_koch, stop_koch);
        }
    }
}
