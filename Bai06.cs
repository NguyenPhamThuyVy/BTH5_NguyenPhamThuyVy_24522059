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
            LoadFonts();
        }
        // Hàm tải Font lên
        private void LoadFonts()
        {
            flpFonts.HorizontalScroll.Enabled = true;
            flpFonts.HorizontalScroll.Visible = true;
            InstalledFontCollection installedFonts = new InstalledFontCollection();

            foreach (FontFamily family in installedFonts.Families)
            { 
                Label lblFont = new Label();
                lblFont.Text = family.Name;
                lblFont.AutoSize = true;
                lblFont.Padding = new Padding(5);
                lblFont.Margin = new Padding(5, 5, 20, 5);

                try
                {
                    lblFont.Font = new Font(family, 16, FontStyle.Regular);
                }
                catch
                {
                    continue;
                }
                flpFonts.Controls.Add(lblFont);
                int requiredWidth = lblFont.Right + 200;
                if (requiredWidth > flpFonts.AutoScrollMinSize.Width)
                {
                    flpFonts.AutoScrollMinSize =
                        new Size(requiredWidth, flpFonts.AutoScrollMinSize.Height);
                }
            }
        }
    }
}