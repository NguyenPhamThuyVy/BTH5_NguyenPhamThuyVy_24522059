namespace BTH5_BT4
{
    partial class Bai04
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
            label1 = new Label();
            cbFont = new ComboBox();
            ckbBold = new CheckBox();
            ckbItalic = new CheckBox();
            ckbUnderline = new CheckBox();
            cbSize = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rbRight = new RadioButton();
            rbCenter = new RadioButton();
            rbLeft = new RadioButton();
            label3 = new Label();
            btnColor = new Button();
            rtbEdit = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 66);
            label1.Name = "label1";
            label1.Size = new Size(83, 36);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // cbFont
            // 
            cbFont.FormattingEnabled = true;
            cbFont.Location = new Point(108, 74);
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(151, 28);
            cbFont.TabIndex = 1;
            cbFont.SelectedIndexChanged += cbFont_SelectedIndexChanged;
            // 
            // ckbBold
            // 
            ckbBold.AutoSize = true;
            ckbBold.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbBold.Location = new Point(44, 132);
            ckbBold.Name = "ckbBold";
            ckbBold.Size = new Size(51, 35);
            ckbBold.TabIndex = 2;
            ckbBold.Text = "B";
            ckbBold.UseVisualStyleBackColor = true;
            ckbBold.CheckedChanged += ckbBold_CheckedChanged;
            // 
            // ckbItalic
            // 
            ckbItalic.AutoSize = true;
            ckbItalic.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ckbItalic.Location = new Point(108, 132);
            ckbItalic.Name = "ckbItalic";
            ckbItalic.Size = new Size(42, 35);
            ckbItalic.TabIndex = 3;
            ckbItalic.Text = "I";
            ckbItalic.UseVisualStyleBackColor = true;
            ckbItalic.CheckedChanged += ckbItalic_CheckedChanged;
            // 
            // ckbUnderline
            // 
            ckbUnderline.AutoSize = true;
            ckbUnderline.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ckbUnderline.Location = new Point(165, 132);
            ckbUnderline.Name = "ckbUnderline";
            ckbUnderline.Size = new Size(52, 35);
            ckbUnderline.TabIndex = 4;
            ckbUnderline.Text = "U";
            ckbUnderline.UseVisualStyleBackColor = true;
            ckbUnderline.CheckedChanged += ckbUnderline_CheckedChanged;
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            cbSize.Location = new Point(395, 74);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(93, 28);
            cbSize.TabIndex = 6;
            cbSize.SelectedIndexChanged += cbSize_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 66);
            label2.Name = "label2";
            label2.Size = new Size(83, 36);
            label2.TabIndex = 5;
            label2.Text = "Size";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbRight);
            groupBox1.Controls.Add(rbCenter);
            groupBox1.Controls.Add(rbLeft);
            groupBox1.Location = new Point(44, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Align Text";
            // 
            // rbRight
            // 
            rbRight.AutoSize = true;
            rbRight.Location = new Point(6, 86);
            rbRight.Name = "rbRight";
            rbRight.Size = new Size(65, 24);
            rbRight.TabIndex = 10;
            rbRight.TabStop = true;
            rbRight.Text = "Right";
            rbRight.UseVisualStyleBackColor = true;
            rbRight.CheckedChanged += rb_CheckedChanged;
            // 
            // rbCenter
            // 
            rbCenter.AutoSize = true;
            rbCenter.Location = new Point(6, 56);
            rbCenter.Name = "rbCenter";
            rbCenter.Size = new Size(73, 24);
            rbCenter.TabIndex = 9;
            rbCenter.TabStop = true;
            rbCenter.Text = "Center";
            rbCenter.UseVisualStyleBackColor = true;
            rbCenter.CheckedChanged += rb_CheckedChanged;
            // 
            // rbLeft
            // 
            rbLeft.AutoSize = true;
            rbLeft.Location = new Point(6, 26);
            rbLeft.Name = "rbLeft";
            rbLeft.Size = new Size(55, 24);
            rbLeft.TabIndex = 8;
            rbLeft.TabStop = true;
            rbLeft.Text = "Left";
            rbLeft.UseVisualStyleBackColor = true;
            rbLeft.CheckedChanged += rb_CheckedChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 128);
            label3.Name = "label3";
            label3.Size = new Size(83, 36);
            label3.TabIndex = 8;
            label3.Text = "Color";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(395, 135);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(57, 29);
            btnColor.TabIndex = 9;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // rtbEdit
            // 
            rtbEdit.Location = new Point(294, 191);
            rtbEdit.Name = "rtbEdit";
            rtbEdit.Size = new Size(277, 87);
            rtbEdit.TabIndex = 10;
            rtbEdit.Text = "";
            rtbEdit.SelectionChanged += rb_CheckedChanged;
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 346);
            Controls.Add(rtbEdit);
            Controls.Add(btnColor);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(cbSize);
            Controls.Add(label2);
            Controls.Add(ckbUnderline);
            Controls.Add(ckbItalic);
            Controls.Add(ckbBold);
            Controls.Add(cbFont);
            Controls.Add(label1);
            Name = "Bai04";
            Text = "Form1";
            Load += Bai04_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFont;
        private CheckBox ckbBold;
        private CheckBox ckbItalic;
        private CheckBox ckbUnderline;
        private ComboBox cbSize;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rbRight;
        private RadioButton rbCenter;
        private RadioButton rbLeft;
        private Label label3;
        private Button btnColor;
        private RichTextBox rtbEdit;
    }
}
