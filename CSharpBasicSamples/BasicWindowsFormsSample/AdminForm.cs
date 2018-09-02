using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    /// <summary>
    /// 管理员主窗体
    /// </summary>
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }       

        // 用户单击退出菜单项时，退出应用程序
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // 退出应用程序           
        }   
    }
}
