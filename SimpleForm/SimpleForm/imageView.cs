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
    public partial class imageView : Form
    {
        public imageView()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            //打开目录对话框，选中图片文件
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "选择图片";
            fdlg.InitialDirectory = "c:\\";
            //文件过滤类型
            fdlg.Filter = "All files(*.*)|*.*|Image files(*.jpg,*.bmp,*.gif)|*.jpg;*.bmp;*.gif";
            //默认过滤文件类型
            fdlg.FilterIndex = 2;
            if (fdlg.ShowDialog() == DialogResult.OK)//DialogResult 对话框的返回值
            {
                pbPicture.Image = Image.FromFile(fdlg.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
            //关闭程序
            //Application.Exit();
        }
    }
}
