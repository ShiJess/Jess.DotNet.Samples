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
    /// 教员信息列表窗体
    /// 学生用书第八章示例3
    /// </summary>
    public partial class TeacherListForm : Form
    {
        private DataSet dataSet = new DataSet();　　// 声明并初始化DataSet
        private SqlDataAdapter dataAdapter;　　　　 // 声明DataAdapter
        
        public TeacherListForm()
        {
            InitializeComponent();
        }

        // 窗体加载时填充数据
        private void TeacherListForm_Load(object sender, EventArgs e)
        {
            // 查询用的 sql 语句
            string teacherSql = "SELECT TeacherID,LoginId,LoginPwd,TeacherName,Sex,BirthDay FROM Teacher";
            
            // 初始化 DataAdapter
            dataAdapter = new SqlDataAdapter(teacherSql, DBHelper.connection);          

            // 填充 DataSet
            dataAdapter.Fill(dataSet, "Teacher");

            // 绑定DataGridView的数据源
            dgvTeacher.DataSource = dataSet.Tables["Teacher"];
        }        

        // 单击“保存修改”按钮时，将数据集的更改提交到数据库
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确实要将修改保存到数据库吗?","操作提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dataSet, "Teacher");
            }            
        }

        // 单击“关闭”按钮时,关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}