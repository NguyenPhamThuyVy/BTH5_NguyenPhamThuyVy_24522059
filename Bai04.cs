using System;
using System.Windows.Forms;
using System.Drawing;
namespace BTH5_BT4
{
    public partial class Bai04 : Form
    {
        private Color currentColor = Color.Black;
        public Bai04()
        {
            InitializeComponent();
        }
        // Xử lý sự kiện Form load
        private void Bai04_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbFont.Items.Add(font.Name);
            }
            cbFont.SelectedItem = "Arial";
            cbSize.SelectedItem = "14";
            ApplyFont();
        }
        // Hàm áp dụng Font
        private void ApplyFont()
        {
            if (cbFont.SelectedItem == null || cbSize.SelectedItem == null)
            {
                return;
            }
            string fontName = cbFont.SelectedItem.ToString();
            float fontSize = float.Parse(cbSize.SelectedItem.ToString());
            FontStyle style = FontStyle.Regular;
            if (ckbBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (ckbItalic.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (ckbUnderline.Checked)
            {
                style |= FontStyle.Underline;
            }
            rtbEdit.SelectionFont = new Font(fontName, fontSize, style);
            rtbEdit.SelectionColor = currentColor;
        }
        // Sự kiện khi chọn Font mới
        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }
        // Sự kiện khi chọn Size mới
        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }
        // Color
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                currentColor = color.Color;
                btnColor.BackColor = color.Color;
                rtbEdit.SelectionColor = currentColor;
            }
        }
        // Định dạng chữ
        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }
        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }
        private void ckbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }
        // Căn lề văn bản
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLeft.Checked)
            {
                rtbEdit.SelectionAlignment = HorizontalAlignment.Left;
                ApplyFont();

            }
            if (rbCenter.Checked)
            {
                rtbEdit.SelectionAlignment = HorizontalAlignment.Center;
                ApplyFont();
            }
            if (rbRight.Checked)
            {
                rtbEdit.SelectionAlignment = HorizontalAlignment.Right;
                ApplyFont();
            }
        }
    }
}
