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
    /// 新增学员用户窗体
    /// </summary>
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        
        // 关闭当前窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }                    
        
    }
}
