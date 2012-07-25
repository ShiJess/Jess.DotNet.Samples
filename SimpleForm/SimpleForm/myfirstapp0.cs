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
    public partial class myfirstapp0 : Form
    {
        public myfirstapp0()
        {
            InitializeComponent();
        }

        private void btn_catchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("抓到我了，算你聪明！","抓到了");
        }

        private void myfirstapp0_MouseMove(object sender, MouseEventArgs e)
        {
            int border = 50;
            int x = e.X;
            int y = e.Y;
            int left= btn_catchMe.Left;
            int right = btn_catchMe.Right;
            int top = btn_catchMe.Top;
            int bottom = btn_catchMe.Bottom;
            //鼠标移到按钮附近（20个像素）
            if(x>left-border&&x<right+border&&y>top-border&&y<bottom+border)
            {
                btn_catchMe.Top+=(y>top?-20:20);
                if(btn_catchMe.Top>myfirstapp0.ActiveForm.Size.Height||btn_catchMe.Bottom<0)
                {
                    btn_catchMe.Top = myfirstapp0.ActiveForm.Size.Height / 2;
                }
                btn_catchMe.Left+=(x>left?-20:20);
                if(btn_catchMe.Left>myfirstapp0.ActiveForm.Size.Width||btn_catchMe.Right<0)
                {
                    btn_catchMe.Left = myfirstapp0.ActiveForm.Size.Width / 2;
                }
            }
        }
    }
}
