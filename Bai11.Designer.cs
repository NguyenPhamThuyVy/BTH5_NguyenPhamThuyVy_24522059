namespace BTH5_BT11
{
    partial class Bai11
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
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            rbLiGra = new RadioButton();
            rbTexture = new RadioButton();
            rbHatch = new RadioButton();
            rbSolid = new RadioButton();
            groupBox2 = new GroupBox();
            btnColor = new Button();
            txtWidth = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbEllipse = new RadioButton();
            rbRect = new RadioButton();
            rbLine = new RadioButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 514);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbLiGra);
            groupBox3.Controls.Add(rbTexture);
            groupBox3.Controls.Add(rbHatch);
            groupBox3.Controls.Add(rbSolid);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(12, 274);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(202, 240);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Brushes";
            // 
            // rbLiGra
            // 
            rbLiGra.AutoSize = true;
            rbLiGra.ForeColor = SystemColors.ControlText;
            rbLiGra.Location = new Point(19, 170);
            rbLiGra.Name = "rbLiGra";
            rbLiGra.Size = new Size(163, 24);
            rbLiGra.TabIndex = 5;
            rbLiGra.TabStop = true;
            rbLiGra.Text = "LinearGradientBrush";
            rbLiGra.UseVisualStyleBackColor = true;
            // 
            // rbTexture
            // 
            rbTexture.AutoSize = true;
            rbTexture.ForeColor = SystemColors.ControlText;
            rbTexture.Location = new Point(19, 126);
            rbTexture.Name = "rbTexture";
            rbTexture.Size = new Size(114, 24);
            rbTexture.TabIndex = 4;
            rbTexture.TabStop = true;
            rbTexture.Text = "TextureBrush";
            rbTexture.UseVisualStyleBackColor = true;
            // 
            // rbHatch
            // 
            rbHatch.AutoSize = true;
            rbHatch.ForeColor = SystemColors.ControlText;
            rbHatch.Location = new Point(19, 79);
            rbHatch.Name = "rbHatch";
            rbHatch.Size = new Size(105, 24);
            rbHatch.TabIndex = 3;
            rbHatch.TabStop = true;
            rbHatch.Text = "HatchBrush";
            rbHatch.UseVisualStyleBackColor = true;
            // 
            // rbSolid
            // 
            rbSolid.AutoSize = true;
            rbSolid.ForeColor = SystemColors.ControlText;
            rbSolid.Location = new Point(19, 38);
            rbSolid.Name = "rbSolid";
            rbSolid.Size = new Size(100, 24);
            rbSolid.TabIndex = 2;
            rbSolid.TabStop = true;
            rbSolid.Text = "SolidBrush";
            rbSolid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnColor);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(12, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pen";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(52, 65);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(125, 29);
            btnColor.TabIndex = 0;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(67, 26);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(9, 34);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Width:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(rbEllipse);
            groupBox1.Controls.Add(rbRect);
            groupBox1.Controls.Add(rbLine);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shapes";
            // 
            // rbEllipse
            // 
            rbEllipse.AutoSize = true;
            rbEllipse.ForeColor = SystemColors.ControlText;
            rbEllipse.Location = new Point(19, 86);
            rbEllipse.Name = "rbEllipse";
            rbEllipse.Size = new Size(73, 24);
            rbEllipse.TabIndex = 8;
            rbEllipse.TabStop = true;
            rbEllipse.Text = "Ellipse";
            rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbRect
            // 
            rbRect.AutoSize = true;
            rbRect.ForeColor = SystemColors.ControlText;
            rbRect.Location = new Point(19, 56);
            rbRect.Name = "rbRect";
            rbRect.Size = new Size(96, 24);
            rbRect.TabIndex = 7;
            rbRect.TabStop = true;
            rbRect.Text = "Rectangle";
            rbRect.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            rbLine.AutoSize = true;
            rbLine.ForeColor = SystemColors.ControlText;
            rbLine.Location = new Point(19, 26);
            rbLine.Name = "rbLine";
            rbLine.Size = new Size(57, 24);
            rbLine.TabIndex = 6;
            rbLine.TabStop = true;
            rbLine.Text = "Line";
            rbLine.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(234, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 514);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Bai11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Bai11";
            Text = "Bai Thi";
            Load += Bai11_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txtWidth;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnColor;
        private RadioButton rbLiGra;
        private RadioButton rbTexture;
        private RadioButton rbHatch;
        private RadioButton rbSolid;
        private RadioButton rbEllipse;
        private RadioButton rbRect;
        private RadioButton rbLine;
        private PictureBox pictureBox1;
    }
}
