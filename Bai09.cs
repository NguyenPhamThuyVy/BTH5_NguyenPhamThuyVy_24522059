using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Configuration;
namespace BTH5_BT9
{
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }
        // Hàm xử lý sự kiện Form load
        private void Bai09_Load(object sender, EventArgs e)
        {

            cbShape.SelectedIndex = 0;
            cbShape.SelectedIndexChanged += (s,e) => { this.Invalidate(); };
        }
        // Xử lý sự kiện Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (cbShape.SelectedItem == null) return;
            string selectedShape = cbShape.SelectedItem.ToString();

            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.DarkRed);

            Rectangle rectShape = new Rectangle(80, 80, 200, 120);
            Rectangle squareShape = new Rectangle(100, 80, 150, 150);

            switch(selectedShape)
            {
                case "Circle":
                    g.DrawEllipse(pen, squareShape);
                    break;
                case "Square":
                    g.DrawRectangle(pen, squareShape);
                    break;
                case "Ellipse":
                    g.DrawEllipse(pen, rectShape);
                    break;
                case "Pie":
                    g.DrawPie(pen, squareShape, 0, 45);
                    break;
                case "Filled Circle":
                    g.FillEllipse(brush, squareShape);
                    break;
                case "Filled Square":
                    g.FillRectangle(brush, squareShape);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(brush, rectShape);
                    break;
                case "Filled Pie":
                    g.FillPie(brush, squareShape, 0, 45);
                    break;
            }
        }
    }
}
