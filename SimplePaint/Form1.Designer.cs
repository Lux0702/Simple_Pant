
namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbShapes = new System.Windows.Forms.GroupBox();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnRetangle = new System.Windows.Forms.Button();
            this.btnEllipes = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFill = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbColorBrush = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbColorPen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plMain = new System.Windows.Forms.Panel();
            this.btnEraser = new System.Windows.Forms.Button();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDashStyle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHatchStyle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbShapes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorBrush)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // grbShapes
            // 
            this.grbShapes.BackColor = System.Drawing.Color.Transparent;
            this.grbShapes.Controls.Add(this.btnPaint);
            this.grbShapes.Controls.Add(this.btnRetangle);
            this.grbShapes.Controls.Add(this.btnEllipes);
            this.grbShapes.Controls.Add(this.btnPolygon);
            this.grbShapes.Controls.Add(this.btnLine);
            this.grbShapes.Controls.Add(this.btnCurve);
            this.grbShapes.Controls.Add(this.btnCircle);
            this.grbShapes.Controls.Add(this.btnSquare);
            this.grbShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShapes.Location = new System.Drawing.Point(12, 12);
            this.grbShapes.Name = "grbShapes";
            this.grbShapes.Size = new System.Drawing.Size(174, 108);
            this.grbShapes.TabIndex = 2;
            this.grbShapes.TabStop = false;
            this.grbShapes.Text = "Shapes";
            // 
            // btnPaint
            // 
            this.btnPaint.BackgroundImage = global::SimplePaint.Properties.Resources.pencil__1_;
            this.btnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaint.Location = new System.Drawing.Point(131, 64);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(33, 33);
            this.btnPaint.TabIndex = 0;
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnRetangle
            // 
            this.btnRetangle.BackgroundImage = global::SimplePaint.Properties.Resources.rectangular_shape_outline;
            this.btnRetangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetangle.Location = new System.Drawing.Point(53, 26);
            this.btnRetangle.Name = "btnRetangle";
            this.btnRetangle.Size = new System.Drawing.Size(33, 32);
            this.btnRetangle.TabIndex = 0;
            this.btnRetangle.UseVisualStyleBackColor = true;
            this.btnRetangle.Click += new System.EventHandler(this.btnRetangle_Click);
            // 
            // btnEllipes
            // 
            this.btnEllipes.BackgroundImage = global::SimplePaint.Properties.Resources.ellipse;
            this.btnEllipes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipes.Location = new System.Drawing.Point(92, 26);
            this.btnEllipes.Name = "btnEllipes";
            this.btnEllipes.Size = new System.Drawing.Size(33, 32);
            this.btnEllipes.TabIndex = 0;
            this.btnEllipes.UseVisualStyleBackColor = true;
            this.btnEllipes.Click += new System.EventHandler(this.btnEllipes_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackgroundImage = global::SimplePaint.Properties.Resources.polygon;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.Location = new System.Drawing.Point(92, 64);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(33, 33);
            this.btnPolygon.TabIndex = 0;
            this.btnPolygon.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = global::SimplePaint.Properties.Resources.diagonal_line;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Location = new System.Drawing.Point(53, 64);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(33, 32);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackgroundImage = global::SimplePaint.Properties.Resources.circumflex_accent;
            this.btnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurve.Location = new System.Drawing.Point(131, 26);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(33, 32);
            this.btnCurve.TabIndex = 0;
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnCurve_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = global::SimplePaint.Properties.Resources.dry_clean;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCircle.Location = new System.Drawing.Point(15, 64);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(33, 32);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackgroundImage = global::SimplePaint.Properties.Resources.square;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquare.Location = new System.Drawing.Point(15, 26);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(33, 32);
            this.btnSquare.TabIndex = 0;
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(192, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbHatchStyle);
            this.groupBox3.Controls.Add(this.cbFill);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pcbColorBrush);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(754, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brush";
            // 
            // cbFill
            // 
            this.cbFill.AutoSize = true;
            this.cbFill.Location = new System.Drawing.Point(85, 20);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(18, 17);
            this.cbFill.TabIndex = 6;
            this.cbFill.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fill :";
            // 
            // pcbColorBrush
            // 
            this.pcbColorBrush.BackColor = System.Drawing.Color.Black;
            this.pcbColorBrush.Location = new System.Drawing.Point(85, 50);
            this.pcbColorBrush.Name = "pcbColorBrush";
            this.pcbColorBrush.Size = new System.Drawing.Size(23, 23);
            this.pcbColorBrush.TabIndex = 3;
            this.pcbColorBrush.TabStop = false;
            this.pcbColorBrush.Click += new System.EventHandler(this.pcbColorBrush_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbDashStyle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numWidth);
            this.groupBox1.Controls.Add(this.pcbColorPen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(471, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen";
            // 
            // pcbColorPen
            // 
            this.pcbColorPen.BackColor = System.Drawing.Color.Black;
            this.pcbColorPen.Location = new System.Drawing.Point(129, 85);
            this.pcbColorPen.Name = "pcbColorPen";
            this.pcbColorPen.Size = new System.Drawing.Size(23, 23);
            this.pcbColorPen.TabIndex = 1;
            this.pcbColorPen.TabStop = false;
            this.pcbColorPen.Click += new System.EventHandler(this.pcbColorPen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color :";
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.White;
            this.plMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plMain.Location = new System.Drawing.Point(0, 127);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1484, 531);
            this.plMain.TabIndex = 6;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImage = global::SimplePaint.Properties.Resources.eraser;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEraser.Location = new System.Drawing.Point(1078, 21);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(90, 99);
            this.btnEraser.TabIndex = 7;
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(129, 53);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(91, 27);
            this.numWidth.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width";
            // 
            // cmbDashStyle
            // 
            this.cmbDashStyle.FormattingEnabled = true;
            this.cmbDashStyle.Location = new System.Drawing.Point(130, 19);
            this.cmbDashStyle.Name = "cmbDashStyle";
            this.cmbDashStyle.Size = new System.Drawing.Size(133, 28);
            this.cmbDashStyle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dash Style:";
            // 
            // cmbHatchStyle
            // 
            this.cmbHatchStyle.FormattingEnabled = true;
            this.cmbHatchStyle.Location = new System.Drawing.Point(143, 75);
            this.cmbHatchStyle.Name = "cmbHatchStyle";
            this.cmbHatchStyle.Size = new System.Drawing.Size(153, 28);
            this.cmbHatchStyle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hatch style:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 658);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.grbShapes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbShapes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorBrush)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColorPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbShapes;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnRetangle;
        private System.Windows.Forms.Button btnEllipes;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbColorBrush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbColorPen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbFill;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHatchStyle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDashStyle;
        private System.Windows.Forms.Label label4;
    }
}

