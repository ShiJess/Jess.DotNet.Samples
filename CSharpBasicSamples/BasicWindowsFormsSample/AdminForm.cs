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

        // 用户单击创建用户菜单项时，出现新建用户窗口
        private void tsmiNewStudent_Click(object sender, EventArgs e)
        {
            // 创建新建用户窗体
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();  // 显示新建用户窗体
        }         
    }
}
