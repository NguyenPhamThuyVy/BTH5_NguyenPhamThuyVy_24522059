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
            flpFonts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpFonts
            // 
            flpFonts.AutoScroll = true;
            flpFonts.FlowDirection = FlowDirection.TopDown;
            flpFonts.Location = new Point(12, 12);
            flpFonts.Name = "flpFonts";
            flpFonts.Size = new Size(495, 584);
            flpFonts.TabIndex = 0;
            flpFonts.WrapContents = false;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 608);
            Controls.Add(flpFonts);
            MaximizeBox = false;
            Name = "Bai06";
            Text = "All Fonts";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpFonts;
    }
}
