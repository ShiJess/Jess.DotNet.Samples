using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("用户名不存在","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
        }
    }
}
