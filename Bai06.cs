using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
namespace BTH5_BT6
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
            lbFonts.DrawMode = DrawMode.OwnerDrawFixed;
            lbFonts.ItemHeight = 30;
            lbFonts.HorizontalScrollbar = true;
        }
        // Hàm xử lý sự kiện Form load
        private void Bai06_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily font in installedFonts.Families)
            {
                lbFonts.Items.Add(font.Name);
            }
        }
        // Hàm xử lý sự kiện Draw Item 
        private void lbFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            string fontName = lbFonts.Items[e.Index].ToString();
            Font fontToDraw;
            try
            {
                fontToDraw = new Font(fontName, 12, FontStyle.Regular);
            }
            catch
            {
                fontToDraw = new Font("Arial", 12, FontStyle.Regular);
            }
            e.Graphics.DrawString(fontName, fontToDraw, new SolidBrush(e.ForeColor), e.Bounds);
            e.DrawFocusRectangle();
        }
    }
}
