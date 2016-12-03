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
    public partial class floatingForm : Form
    {
        public floatingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = new Point(this.DesktopLocation.X+1,this.DesktopLocation.Y);
            this.DesktopLocation = p;
            if(p.X==this.DesktopBounds.Width)
            {
                Point p2 = new Point(0,370);
                this.DesktopLocation = p2;
            }
        }

        private void floatingForm_Load(object sender, EventArgs e)
        {
            Point p = new Point(0,370);
            this.DesktopLocation = p;
        }
    }
}
