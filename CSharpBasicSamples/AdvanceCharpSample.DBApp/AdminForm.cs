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

        // 设置状态栏的标签的文本，显示当前登录的用户名
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.slblAdmin.Text = this.slblAdmin.Text + "-" + UserHelper.loginId;
        }

        // 关闭窗体时，退出应用程序
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // 用户单击退出菜单项时，退出应用程序
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult choice;　　// 用户的选择
            choice = MessageBox.Show("确定要退出吗？", "退出系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (choice == DialogResult.OK)
            {
                Application.Exit();  // 退出应用程序
            }            
        }

        // 用户单击创建用户菜单项时，出现新建用户窗口
        private void tsmiNewStudent_Click(object sender, EventArgs e)
        {
            // 创建新建用户窗体
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.MdiParent = this;  // 设置父窗体
            addStudentForm.Show();            // 显示新建用户窗体
        }

        // “关于MySchool”菜单项的Click事件处理
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();   // 打开关于窗体，显示为模式窗口
        }
        
        // 单击时，打开查询学员用户窗体
        private void tsmiSearchStudent_Click(object sender, EventArgs e)
        {
            SearchStudentForm searchStudentForm = new SearchStudentForm();//创建窗体对象
            searchStudentForm.MdiParent = this;  // 设置MDI父窗体
            searchStudentForm.Show();            // 显示窗体
        }

        // 用户单击查看教师信息时，显示教师信息列表窗体    
        private void tsmiTeacherList_Click(object sender, EventArgs e)
        {
            TeacherListForm teacherListForm = new TeacherListForm(); // 创建教师信息窗体
            teacherListForm.MdiParent = this;  // 指定 MDI 父窗体
            teacherListForm.Show();            // 显示窗体
        }    
    }
}
