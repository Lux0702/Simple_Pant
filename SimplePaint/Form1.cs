using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        Graphics gp;
        int Choose ;
        Pen myPen,Eraser;
        Color myColor;
        Point P1, P2;
        int? initX = null;
        int? intiY = null;
        
        //Point[] points;
        bool isStart=false;
        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            myColor = Color.Black;
            myPen = new Pen(myColor, 5);
            Eraser = new Pen(Color.White, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbHatchStyle.Items.AddRange(new object[] {
                "None",
                "BackwardDiagonal",
                "Cross",
                "DarkDownwardDiagonal",
                "DarkHorizontal",
                "DarkUpwardDiagonal",
                "ZigZag"
            });

            this.cmbDashStyle.Items.AddRange(new object[] {
                "Solid",
                "Dot",
                "Dash",
                "DashDot",
                "DashDotDot"
            });
        }

        private void pcbColorPen_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pcbColorPen.BackColor = c.Color;
            }
        }

        private void pcbColorBrush_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pcbColorBrush.BackColor = c.Color;
            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            isStart = false;
            if(Choose==1)
            {
                this.P2 = e.Location;
            }   
            if(Choose==3)
            {
                this.P2 = e.Location;
            }    
            //P2 = e.Location;
            
            

        }

        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isStart== true)
            {
                if (this.Choose == 0)
                {
                    P1 = e.Location;
                    myPen = new Pen(pcbColorPen.BackColor, 5);
                    myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    gp.DrawLine(myPen, P1.X, P1.Y,
                        P2.X, P2.Y);
                    P2 = P1;
                }
                else if(this.Choose==-1)
                {
                    P1 = e.Location;
                    gp.DrawLine(Eraser, P1.X, P1.Y, P2.X, P2.Y);
                    P2 = e.Location;
                }
                else if (this.Choose == 1)
                {
                    this.P1 = e.Location;
                    myPen = new Pen(pcbColorPen.BackColor, 5);
                    gp.DrawLine(myPen, P2, P1);
                    P2 = e.Location;


                }
                else if(this.Choose==3)
                {
                    P2 = e.Location;
                    int X = Math.Min(P1.X, P2.X);
                    int Y = Math.Min(P1.Y, P2.Y);
                    int width = Math.Abs(P1.X - P2.X);
                    int height = Math.Abs(P1.Y - P2.Y);
                    Rectangle rec = new Rectangle(X, Y, width, height);
                    gp.DrawEllipse(myPen, rec);

                }
                Choose = -1000;
            }
            
           
        }

        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            isStart = true;
            if (this.Choose==0)
            {
                P2 = e.Location;
            }    
            if (this.Choose == 1)
            {
                P1 = e.Location;
                

            }
            else if (this.Choose==3)
            {
                P1 = e.Location;
               
            }
            

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.Choose = 1;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.Choose = 2;
        }

        private void btnEllipes_Click(object sender, EventArgs e)
        {
            this.Choose = 3;
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            if (Choose==1)
            {
                myPen = new Pen(pcbColorPen.BackColor, 5);
                gp.DrawLine(myPen, P1, P2);
                P2 = P1;

            }
            else if (Choose == 3)
            {
                
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            this.Choose = 4;
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            this.Choose = 5;
        }

        private void btnRetangle_Click(object sender, EventArgs e)
        {
            this.Choose = 6;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            this.Choose = -1;
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            this.Choose = 0;
        }
    }
}
