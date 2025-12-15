namespace BTH5_BT9
{
    partial class Bai09
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
            cbShape = new ComboBox();
            SuspendLayout();
            // 
            // cbShape
            // 
            cbShape.FormattingEnabled = true;
            cbShape.Items.AddRange(new object[] { "Circle", "Square", "Ellipse", "Pie", "Filled Circle", "Filled Square", "Filled Ellipse", "Filled Pie" });
            cbShape.Location = new Point(12, 12);
            cbShape.Name = "cbShape";
            cbShape.Size = new Size(170, 28);
            cbShape.TabIndex = 0;
            // 
            // Bai09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 304);
            Controls.Add(cbShape);
            Name = "Bai09";
            Text = "ComboBoxTest";
            Load += Bai09_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbShape;
    }
}
