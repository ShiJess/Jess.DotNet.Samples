using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    /// <summary>
    /// 创建学员用户主窗体
    /// </summary>
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        
        // 关闭当前窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
