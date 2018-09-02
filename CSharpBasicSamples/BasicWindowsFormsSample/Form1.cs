using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体的鼠标移动事件处理程序
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = string.Format("扑捉到鼠标了!({0},{1})", e.X, e.Y);
        }
    }
}