using System;
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Windows.Forms;
namespace BTH5_BT8
{
    public partial class Bai08 : Form
    {
        private System.Windows.Forms.Timer timer;
        public Bai08()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                this.Invalidate();
            };
            timer.Start();
        }
        // Xử lý sự kiện Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            int centerX = width / 2;
            int centerY = height / 2;
            int radius = Math.Min(centerX, centerY) - 20;
            // Dời điểm (0, 0) từ góc trên trái về chính giữa tâm của form 
            g.TranslateTransform(centerX, centerY);
            // Mặt đồng hồ
            var originalState = g.Save();

            for (int i = 0; i < 60; i++)
            {
                if (i % 5 == 0)
                {
                    g.FillEllipse(Brushes.White, -9, -radius -9, 18, 18);
                }
                else
                {
                    g.FillEllipse(Brushes.White, -3, -radius, 6, 6);
                }
                // Xoay trục tọa độ đi 6 độ
                g.RotateTransform(6);
            }
            g.Restore(originalState);

            DateTime now = DateTime.Now;
            float hour = now.Hour;
            float minute = now.Minute;
            float second = now.Second;

            // Định nghĩa hình dáng kim (đa giác)
            Point[] hourHandPoints = { new Point(0, 20), new Point(10, 0), new Point(0, -90), new Point(-10, 0) };
            Point[] minHandPoints = { new Point(0, 20), new Point(8, 0), new Point(0, -120), new Point(-8, 0) };
            Point[] secHandPoints = { new Point(0, 20), new Point(5, 0), new Point(0, -130), new Point(-5, 0) };

            Pen whitePen = new Pen(Color.White, 1.5f);

            // Vẽ kim giờ
            float hourAngle = (hour % 12) * 30 + (minute * 0.5f);

            g.Save();
            g.RotateTransform(hourAngle); // Xoay trục theo góc giờ
            g.DrawPolygon(whitePen, hourHandPoints); // Vẽ khung dây (rỗng ruột)
            g.Restore(originalState);

            // Vẽ kim phút
            float minAngle = (minute * 6) + (second * 0.1f);

            g.Save();
            g.RotateTransform(minAngle);
            g.DrawPolygon(whitePen, minHandPoints);
            g.Restore(originalState);

            // Vẽ kim giây
            float secAngle = second * 6;

            g.Save();
            g.RotateTransform(secAngle);
            g.DrawPolygon(whitePen, secHandPoints);
            g.Restore(originalState);
        }
    }
}
