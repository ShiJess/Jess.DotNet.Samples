using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleForm
{
    public partial class noBorderApp : Form
    {
        static int frmLastWidth = 0;
        static int frmLastHeight = 0;
        static int frmWidth;
        static int frmHeight;
        static bool frmIsResizing = false;
        System.Drawing.Rectangle frmRectangle = new System.Drawing.Rectangle();
        public noBorderApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            frmRectangle.Location=new System.Drawing.Point(this.Left,this.Top);
            frmRectangle.Size = new System.Drawing.Size(frmWidth,frmHeight);
            ControlPaint.DrawReversibleFrame(frmRectangle,Color.Empty,System.Windows.Forms.FrameStyle.Thick);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            frmIsResizing = false;
            frmRectangle.Location = new System.Drawing.Point(this.Left, this.Top);
            frmRectangle.Size = new System.Drawing.Size(frmWidth, frmHeight);
            ControlPaint.DrawReversibleFrame(frmRectangle, Color.Empty, System.Windows.Forms.FrameStyle.Thick);
            this.Width = frmWidth;
            this.Height = frmHeight;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {

                int sizeageX=(MousePosition.X-this.Location.X);
                int sizeageY=(MousePosition.Y-this.Location.Y);

                if(sizeageX<120)
                {
                    sizeageX = 120;
                }
                if(sizeageY<81)
                {
                    sizeageY = 81;
                }

                frmWidth = sizeageX;
                frmHeight = sizeageY;

                if(frmLastWidth==0)
                {
                    frmLastWidth = frmWidth;

                }
                if(frmHeight==0)
                {
                    frmLastHeight = frmHeight;
                }

                if(frmIsResizing)
                {
                    frmRectangle.Location = new System.Drawing.Point(this.Left,this.Top);
                    frmRectangle.Size = new System.Drawing.Size(frmLastWidth,frmLastHeight);
                }

                frmIsResizing = true;
                ControlPaint.DrawReversibleFrame(frmRectangle,Color.Empty,System.Windows.Forms.FrameStyle.Thick);
                frmLastWidth = frmWidth;
                frmLastHeight = frmHeight;
                frmRectangle.Location = new System.Drawing.Point(this.Left,this.Top);
                frmRectangle.Size = new System.Drawing.Size(frmWidth,frmHeight);
                ControlPaint.DrawReversibleFrame(frmRectangle, Color.Empty, System.Windows.Forms.FrameStyle.Thick);

            }
        }
    }
}
