namespace MySchool
{
    partial class AdminForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTeacherList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.tsmiQuestion,
            this.tsmiExam,
            this.tsmiWindows,
            this.tsmiHelp});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.MdiWindowListItem = this.tsmiWindows;
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(611, 24);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "管理员菜单";
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewUser,
            this.tsmiSearchStudent,
            this.tsmiUserList,
            this.toolStripSeparator,
            this.tsmiExit});
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(65, 20);
            this.tsmiUser.Text = "用户管理";
            // 
            // tsmiNewUser
            // 
            this.tsmiNewUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewStudent,
            this.tsmiNewTeacher});
            this.tsmiNewUser.Name = "tsmiNewUser";
            this.tsmiNewUser.Size = new System.Drawing.Size(154, 22);
            this.tsmiNewUser.Text = "新增用户";
            // 
            // tsmiNewStudent
            // 
            this.tsmiNewStudent.Name = "tsmiNewStudent";
            this.tsmiNewStudent.Size = new System.Drawing.Size(142, 22);
            this.tsmiNewStudent.Text = "新增学员用户";
            this.tsmiNewStudent.Click += new System.EventHandler(this.tsmiNewStudent_Click);
            // 
            // tsmiNewTeacher
            // 
            this.tsmiNewTeacher.Name = "tsmiNewTeacher";
            this.tsmiNewTeacher.Size = new System.Drawing.Size(142, 22);
            this.tsmiNewTeacher.Text = "新增教员用户";
            // 
            // tsmiSearchStudent
            // 
            this.tsmiSearchStudent.Name = "tsmiSearchStudent";
            this.tsmiSearchStudent.Size = new System.Drawing.Size(154, 22);
            this.tsmiSearchStudent.Text = "查询及修改学员";
            // 
            // tsmiUserList
            // 
            this.tsmiUserList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStudentList,
            this.tsmiTeacherList});
            this.tsmiUserList.Name = "tsmiUserList";
            this.tsmiUserList.Size = new System.Drawing.Size(154, 22);
            this.tsmiUserList.Text = "用户信息列表";
            // 
            // tsmiStudentList
            // 
            this.tsmiStudentList.Name = "tsmiStudentList";
            this.tsmiStudentList.Size = new System.Drawing.Size(142, 22);
            this.tsmiStudentList.Text = "学员信息列表";
            // 
            // tsmiTeacherList
            // 
            this.tsmiTeacherList.Name = "tsmiTeacherList";
            this.tsmiTeacherList.Size = new System.Drawing.Size(142, 22);
            this.tsmiTeacherList.Text = "教员信息列表";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(151, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(154, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiQuestion
            // 
            this.tsmiQuestion.Name = "tsmiQuestion";
            this.tsmiQuestion.Size = new System.Drawing.Size(65, 20);
            this.tsmiQuestion.Text = "题库管理";
            // 
            // tsmiExam
            // 
            this.tsmiExam.Name = "tsmiExam";
            this.tsmiExam.Size = new System.Drawing.Size(65, 20);
            this.tsmiExam.Text = "考试管理";
            // 
            // tsmiWindows
            // 
            this.tsmiWindows.Name = "tsmiWindows";
            this.tsmiWindows.Size = new System.Drawing.Size(41, 20);
            this.tsmiWindows.Text = "窗口";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(41, 20);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(166, 22);
            this.tsmiAbout.Text = "关于考试管理系统";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 400);
            this.Controls.Add(this.msAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAdmin;
            this.Name = "AdminForm";
            this.Text = "MySchool-管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserList;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindows;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTeacher;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestion;
        private System.Windows.Forms.ToolStripMenuItem tsmiExam;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentList;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeacherList;
    }
}

