using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace BTH5_BT11
{
    public partial class Bai11 : Form
    {
        Color currentColor = Color.Black;
        Point startPoint;
        Point endPoint;
        bool isDrawing = false;
        Bitmap mainBitmap;
        public Bai11()
        {
            InitializeComponent();
        }
        // Xử lý sự kiện Form load
        private void Bai11_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(mainBitmap))
            {
                g.Clear(Color.White);
            }
        }
        // Xử lý sự kiện nhấn nút Color
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                currentColor = dlg.Color;
                btnColor.BackColor = dlg.Color;
            }
        }
        // Xử lý sự kiện MouseDown
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                endPoint = e.Location;
            }
        }
        // Xử lý sự kiện MouseMove
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }
        // Xử lý sự kiện MouseUp
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            using (Graphics g = Graphics.FromImage(mainBitmap))
            {
                VeHinh(g, startPoint, endPoint);
            }
        }
        // Xử lý sự kiện Paint
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (mainBitmap != null)
            {
                e.Graphics.DrawImage(mainBitmap, 0, 0);
            }
            if (isDrawing)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                VeHinh(e.Graphics, startPoint, endPoint);
            }
        }
        // Hàm vẽ hình
        private void VeHinh(Graphics g, Point p1, Point p2)
        {
            float penWidth = 1;
            float.TryParse(txtWidth.Text, out penWidth);

            if (rbLine.Checked)
            {
                using (Pen p = new Pen(currentColor, penWidth))
                {
                    g.DrawLine(p, p1, p2);
                }
            }
            else // Vẽ hình khối
            {
                int x = Math.Min(p1.X, p2.X);
                int y = Math.Min(p1.Y, p2.Y);
                int w = Math.Abs(p1.X - p2.X);
                int h = Math.Abs(p1.Y - p2.Y);
                Rectangle rect = new Rectangle(x, y, w, h);

                if (w <= 0 || h <= 0) return;

                Brush myBrush = null;

                if (rbSolid.Checked)
                    myBrush = new SolidBrush(Color.Green);
                else if (rbHatch.Checked)
                    myBrush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                else if (rbTexture.Checked)
                {
                    Bitmap bmp = new Bitmap(20, 20);
                    using (Graphics gBmp = Graphics.FromImage(bmp))
                    {
                        gBmp.Clear(Color.Yellow);
                        gBmp.FillEllipse(Brushes.Red, 2, 2, 16, 16);
                    }
                    myBrush = new TextureBrush(bmp);
                }
                else if (rbLiGra.Checked)
                    myBrush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);

                if (myBrush != null)
                {
                    if (rbRect.Checked) g.FillRectangle(myBrush, rect);
                    else if (rbEllipse.Checked) g.FillEllipse(myBrush, rect);
                    myBrush.Dispose();
                }
            }
        }
    }
}
