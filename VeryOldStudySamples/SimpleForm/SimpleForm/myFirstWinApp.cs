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
    public partial class myFirstWinApp : Form
    {
        public myFirstWinApp()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("朋友，你好！","Hello");
            MessageBox.Show(txt_input.Text,"Hello");
        }
    }
}
