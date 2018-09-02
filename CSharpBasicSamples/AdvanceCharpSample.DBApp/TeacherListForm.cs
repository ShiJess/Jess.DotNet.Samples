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
    /// 学生用书第八章示例1
    /// </summary>
    public partial class TeacherListForm : Form
    {
        private DataSet dataSet = new DataSet();　　// 声明并初始化DataSet
        private SqlDataAdapter dataAdapter;　　     // 声明DataAdapter
        
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

            // 打印数据集中 Teacher 表
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    row["TeacherId"], row["TeacherName"],row["Sex"]);
            }
        } 
    }
}