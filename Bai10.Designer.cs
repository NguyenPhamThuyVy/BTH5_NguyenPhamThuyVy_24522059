namespace BTH5_BT10
{
    partial class Bai10
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
            pnControls = new Panel();
            cbEndCap = new ComboBox();
            label6 = new Label();
            cbStartCap = new ComboBox();
            label5 = new Label();
            cbDashCap = new ComboBox();
            label4 = new Label();
            cbLineJoin = new ComboBox();
            label3 = new Label();
            cbWidth = new ComboBox();
            label2 = new Label();
            cbDash = new ComboBox();
            label1 = new Label();
            pnDrawing = new Panel();
            pnControls.SuspendLayout();
            SuspendLayout();
            // 
            // pnControls
            // 
            pnControls.BackColor = Color.LightGray;
            pnControls.Controls.Add(cbEndCap);
            pnControls.Controls.Add(label6);
            pnControls.Controls.Add(cbStartCap);
            pnControls.Controls.Add(label5);
            pnControls.Controls.Add(cbDashCap);
            pnControls.Controls.Add(label4);
            pnControls.Controls.Add(cbLineJoin);
            pnControls.Controls.Add(label3);
            pnControls.Controls.Add(cbWidth);
            pnControls.Controls.Add(label2);
            pnControls.Controls.Add(cbDash);
            pnControls.Controls.Add(label1);
            pnControls.Dock = DockStyle.Left;
            pnControls.Location = new Point(0, 0);
            pnControls.Name = "pnControls";
            pnControls.Size = new Size(268, 372);
            pnControls.TabIndex = 0;
            // 
            // cbEndCap
            // 
            cbEndCap.FormattingEnabled = true;
            cbEndCap.Items.AddRange(new object[] { "Flat", "Square", "Round", "Triangle", "ArrowAnchor", "RoundAnchor", "SquareAnchor", "DiamondAnchor" });
            cbEndCap.Location = new Point(99, 331);
            cbEndCap.Name = "cbEndCap";
            cbEndCap.Size = new Size(151, 28);
            cbEndCap.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(12, 334);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 10;
            label6.Text = "End Cap:";
            // 
            // cbStartCap
            // 
            cbStartCap.FormattingEnabled = true;
            cbStartCap.Items.AddRange(new object[] { "Flat", "Square", "Round", "Triangle", "ArrowAnchor", "RoundAnchor", "SquareAnchor", "DiamondAnchor" });
            cbStartCap.Location = new Point(99, 270);
            cbStartCap.Name = "cbStartCap";
            cbStartCap.Size = new Size(151, 28);
            cbStartCap.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(12, 273);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 8;
            label5.Text = "Start Cap:";
            // 
            // cbDashCap
            // 
            cbDashCap.FormattingEnabled = true;
            cbDashCap.Items.AddRange(new object[] { "Flat", "Round", "Triangle" });
            cbDashCap.Location = new Point(99, 207);
            cbDashCap.Name = "cbDashCap";
            cbDashCap.Size = new Size(151, 28);
            cbDashCap.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 6;
            label4.Text = "Dash Cap:";
            // 
            // cbLineJoin
            // 
            cbLineJoin.FormattingEnabled = true;
            cbLineJoin.Items.AddRange(new object[] { "Miter", "Bevel", "Round", "MiterClipped" });
            cbLineJoin.Location = new Point(99, 147);
            cbLineJoin.Name = "cbLineJoin";
            cbLineJoin.Size = new Size(151, 28);
            cbLineJoin.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Line Join:";
            // 
            // cbWidth
            // 
            cbWidth.FormattingEnabled = true;
            cbWidth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbWidth.Location = new Point(99, 90);
            cbWidth.Name = "cbWidth";
            cbWidth.Size = new Size(151, 28);
            cbWidth.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Width:";
            // 
            // cbDash
            // 
            cbDash.FormattingEnabled = true;
            cbDash.Items.AddRange(new object[] { "Solid", "Dash", "Dot", "DashDot", "DashDotDot", "Custom" });
            cbDash.Location = new Point(99, 34);
            cbDash.Name = "cbDash";
            cbDash.Size = new Size(151, 28);
            cbDash.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Dash Style:";
            // 
            // pnDrawing
            // 
            pnDrawing.BackColor = Color.White;
            pnDrawing.Dock = DockStyle.Fill;
            pnDrawing.Location = new Point(268, 0);
            pnDrawing.Name = "pnDrawing";
            pnDrawing.Size = new Size(532, 372);
            pnDrawing.TabIndex = 1;
            pnDrawing.Paint += OnPaint;
            // 
            // Bai10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(pnDrawing);
            Controls.Add(pnControls);
            Name = "Bai10";
            Text = "Pen Demo";
            Load += Bai10_Load;
            pnControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnControls;
        private ComboBox cbEndCap;
        private Label label6;
        private ComboBox cbStartCap;
        private Label label5;
        private ComboBox cbDashCap;
        private Label label4;
        private ComboBox cbLineJoin;
        private Label label3;
        private ComboBox cbWidth;
        private Label label2;
        private ComboBox cbDash;
        private Label label1;
        private Panel pnDrawing;
    }
}
