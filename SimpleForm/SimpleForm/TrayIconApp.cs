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
    public partial class TrayIcon : Form
    {
        public TrayIcon()
        {
            InitializeComponent();
        }

        private void maximize(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            if(!this.Visible)
            {
                this.Show();
            }
        }

        private void minimise(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                this.Hide();
            }
        }

        private void helpme(object sender, EventArgs e)
        {
            MessageBox.Show("版权所有:XXX 2001");
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
