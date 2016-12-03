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
    public partial class myfristwinapp0 : Form
    {
        public myfristwinapp0()
        {
            InitializeComponent();
        }

        private void statusStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            string prompt = "鼠标位置("+e.X.ToString()+","+e.Y.ToString()+")";
            statusStrip1.Text = prompt;
        }

        private void toolStripStatusLabel1_MouseMove(object sender, MouseEventArgs e)
        {
           // this.statusStrip1_MouseMove(sender,e);
            string prompt = "鼠标位置(" + e.X.ToString() + "," + e.Y.ToString() + ")";
            toolStripStatusLabel1.Text=prompt;
        }
    }
}
