using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace BTH5_BT10
{
    public partial class Bai10 : Form
    {
        private Point[] drawingPoints = new Point[]
        {
            new Point(20, 20),
            new Point(120, 250),
            new Point(250, 100)  
        };
        public Bai10()
        {
            InitializeComponent();
            pnDrawing.Paint += OnPaint;
        }
        // Hàm xử lý sự kiện Form load
        private void Bai10_Load(object sender, EventArgs e)
        {
            cbDash.SelectedIndex = 0;
            cbLineJoin.SelectedIndex = 0;
            cbDashCap.SelectedIndex = 0;
            cbStartCap.SelectedIndex = 0;
            cbEndCap.SelectedIndex = 0;
            cbWidth.SelectedItem = "9";

            // Nạp dữ liệu Enum vào DataSource
            cbDash.DataSource = Enum.GetValues(typeof(DashStyle));
            cbDash.SelectedItem = DashStyle.Solid;

            cbLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cbLineJoin.SelectedItem = LineJoin.Round;

            cbDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cbDashCap.SelectedItem = DashCap.Triangle;

            cbStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cbStartCap.SelectedItem = LineCap.ArrowAnchor;

            cbEndCap.DataSource = Enum.GetValues(typeof(LineCap));
            cbEndCap.SelectedItem = LineCap.DiamondAnchor;

            cbDash.SelectedIndexChanged += (s, ev) => { pnDrawing.Invalidate(); };
            cbLineJoin.SelectedIndexChanged += (s, ev) => { pnDrawing.Invalidate(); };
            cbDashCap.SelectedIndexChanged += (s, ev) => { pnDrawing.Invalidate(); };
            cbStartCap.SelectedIndexChanged += (s, ev) => { pnDrawing.Invalidate(); };
            cbEndCap.SelectedIndexChanged += (s, ev) => { pnDrawing.Invalidate(); };
            cbWidth.SelectedIndexChanged += (s, ev) => { pnDrawing.Invalidate(); };
        }
        // Xử lý sự kiện Paint
        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (cbDash.SelectedItem == null || cbWidth.SelectedItem == null) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            try
            {
                float width = float.Parse(cbWidth.Text);

                using (Pen myPen = new Pen(Color.Red, width))
                {
                    DashStyle style = (DashStyle)cbDash.SelectedValue;
                    myPen.DashStyle = style;

                    if (style == DashStyle.Custom)
                    {
                        myPen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                    }
                    myPen.LineJoin = (LineJoin)cbLineJoin.SelectedValue;
                    myPen.DashCap = (DashCap)cbDashCap.SelectedValue;
                    myPen.StartCap = (LineCap)cbStartCap.SelectedValue;
                    myPen.EndCap = (LineCap)cbEndCap.SelectedValue;

                    e.Graphics.DrawLines(myPen, drawingPoints);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi vẽ: " + ex.Message);
            }
        }
    }
}
