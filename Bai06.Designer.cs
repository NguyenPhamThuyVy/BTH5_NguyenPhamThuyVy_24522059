namespace BTH5_BT6
{
    partial class Bai06
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFonts = new ListBox();
            SuspendLayout();
            // 
            // lbFonts
            // 
            lbFonts.Dock = DockStyle.Fill;
            lbFonts.DrawMode = DrawMode.OwnerDrawFixed;
            lbFonts.FormattingEnabled = true;
            lbFonts.HorizontalExtent = 300;
            lbFonts.HorizontalScrollbar = true;
            lbFonts.ItemHeight = 30;
            lbFonts.Location = new Point(0, 0);
            lbFonts.Name = "lbFonts";
            lbFonts.Size = new Size(454, 450);
            lbFonts.TabIndex = 0;
            lbFonts.DrawItem += lbFonts_DrawItem;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(lbFonts);
            Name = "Bai06";
            Text = "All Fonts";
            Load += Bai06_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbFonts;
    }
}
