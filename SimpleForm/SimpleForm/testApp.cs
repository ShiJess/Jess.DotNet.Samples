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
    public partial class testApp : Form
    {
        public testApp()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Value.Date.ToShortDateString() + "做的事情如下：\n";
            richTextBox1.Text += "--------------------------------------\n";
        }
    }
}
