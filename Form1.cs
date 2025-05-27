using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Fractalii
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            if (Debugger.IsAttached) { AllocConsole(); }
            this.Text = "Fractalii";
            this.KeyPreview = true; // Important to capture key events
            this.TopMost = false;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            //this.DoubleBuffered = true;

            using Stream iconStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Fractalii.fractal.ico");
            if (iconStream != null)
            {
                this.Icon = new Icon(iconStream);
            }
            else
            {
                MessageBox.Show("Icon resource not found.");
            }
        }
        public void SetText(string text)
        {
            this.Text = text;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        const int DWMWA_CAPTION_COLOR = 35;


        public static Color bgC = Color.Black;
        public static String def = "Fractalii";
        private static int TitleColor = 0x000000;
        private Pair<int, int> initialSize;

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Drawing.Rectangle ScreenR = Screen.PrimaryScreen.WorkingArea;
            //this.Size = new System.Drawing.Size(Convert.ToInt32(.55 * ScreenR.Width), Convert.ToInt32(.7 * ScreenR.Height));
            initialSize = new Pair<int, int>(this.Size.Width, this.Size.Height);
            this.Location = new System.Drawing.Point(145, 160);

            //this.KeyDown += new KeyEventHandler(Form_KeyDown);
            this.Resize += HomePage_Resize;
            DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref TitleColor, sizeof(int));

            pictureBox1.BackColor = bgC;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            userControl11.set_pictureBox(pictureBox1);
            add_color(initialColor, initialColorSelect, "Select initial color");
            add_color(finalColor, finalColorSelect, "Select final color");

            //userControl11.SetSelectedTab(0, this, userControl11);

            pictureBox1.Paint += (s, args) =>
            {
                //args.Graphics.Clear(pictureBox1.BackColor);
                ControlPaint.DrawBorder(args.Graphics, pictureBox1.ClientRectangle,
                    Color.Green, 3, ButtonBorderStyle.Solid, // Left
                    Color.Green, 3, ButtonBorderStyle.Solid, // Top
                    Color.Green, 3, ButtonBorderStyle.Solid, // Right
                    Color.Green, 3, ButtonBorderStyle.Solid  // Bottom
                );
            };
            this.Resize += (s, e) =>
            {
                //var rect = pictureBox1.Bounds;
                //rect.Inflate(2, 2); 
                //this.Invalidate(rect);
                pictureBox1.Invalidate();
            };
        }


        // color setting
        public static Color initialColor = Color.Blue, finalColor = Color.Green;


        private static void add_color(Color color, Button b1, String text)
        {
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(new SolidBrush(color), 0, 0, 16, 16);
                g.DrawRectangle(Pens.Black, 0, 0, 15, 15);
            }

            b1.Image = bmp;
            b1.TextImageRelation = TextImageRelation.TextAboveImage;
            b1.TextAlign = ContentAlignment.MiddleCenter;
            b1.ImageAlign = ContentAlignment.MiddleCenter;
            b1.Text = text;
            b1.Tag = initialColor;
        }
        private void initialColorSelect_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                initialColor = colorSelector.setColor;
                add_color(initialColor, initialColorSelect, "Select initial color");
            }
        }
        private void finalColorSelect_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Color_Selector colorSelector = new Color_Selector();
            DialogResult result = colorSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                finalColor = colorSelector.setColor;
                add_color(finalColor, finalColorSelect, "Select final color");
            }
        }

        private void pictureBox1_2Click(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            UserControl1.default_pressed(sender, e, userControl11);
            //Console.WriteLine("Boom");
        }

        private static bool activeFullScreenChange = false;
        public static bool isFractalFullScreen = false;
        public static Rectangle pbOriginalBounds = default(Rectangle);
        public static void FullScreenPictureBox(ref PictureBox pb)
        {
            if (!activeFullScreenChange) return;
            if (pbOriginalBounds==default(Rectangle)) pbOriginalBounds = pb.Bounds;
            isFractalFullScreen = true;
            pb.BringToFront();
            pb.Dock = DockStyle.Fill;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11) { ToggleFullscreen(); }
            if (e.KeyCode == Keys.F5)
            {
                // generate fractal
                UserControl1.Generate(sender, e, userControl11);
            }
            if (e.KeyCode == Keys.F1) { UserControl1.default_pressed(sender, e, userControl11); }
            if (e.Control && e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                // switch to specific tab
                int tab = (int)(e.KeyCode - '0') - 1;
                if (tab == -1) { tab += 10; }
                //Console.WriteLine(tab.ToString());
                userControl11.SetSelectedTab(tab);
            }
            Console.WriteLine(isFractalFullScreen);
            if (e.KeyCode == Keys.Escape && isFractalFullScreen)
            {
                Console.WriteLine("ESC pressed");
                if (!activeFullScreenChange) return;
                Console.WriteLine("executing ESC");
                // Restore PictureBox
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.Bounds = pbOriginalBounds;
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

                isFractalFullScreen = false;
                pbOriginalBounds = default(Rectangle);
            }
        }

        private void ToggleFullscreen()
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = false;
            }
            //pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
        private void DarkMode_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null && checkBox.Checked)
            {
                ApplyTheme(this, Color.Black, Color.White);
            }
            else
            {
                ApplyTheme(this, Color.White, Color.Black);
            }
        }
        private void ApplyTheme(Control parent, Color backColor, Color foreColor)
        {
            if (parent is PictureBox) return;

            parent.BackColor = backColor;
            parent.ForeColor = foreColor;

            foreach (Control control in parent.Controls)
            {
                ApplyTheme(control, backColor, foreColor);
                if (control is TextBox || control is Label || control is Button)
                {
                    control.ForeColor = foreColor;
                    control.BackColor = backColor;
                }
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                userControl11.getMouseRClick(e.X, e.Y);
            }
            else userControl11.getMouseLClick(e.X, e.Y);
        }
        private void HomePage_Resize(object sender, EventArgs e)
        {
            // Example: maintain a margin of 12 pixels around the PictureBox.
            int margin = 12;
            // Position the PictureBox 5 pixels beneath userControl11
            int pbY = userControl11.Bottom + 5;
            pictureBox1.Location = new Point(margin, pbY);
            // Set PictureBox size while preserving the margins
            pictureBox1.Size = new Size(
                this.ClientSize.Width - 2 * margin,
                this.ClientSize.Height - pbY - margin
            );
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            activeFullScreenChange = !activeFullScreenChange;
        }
    }
}