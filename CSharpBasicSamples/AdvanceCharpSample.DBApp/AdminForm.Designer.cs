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
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tsddbNewUser = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbtnNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnNewTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnSearchStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStudentList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTeacherList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnQuestion = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExam = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.slblAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssAdmin = new System.Windows.Forms.StatusStrip();
            this.msAdmin.SuspendLayout();
            this.tsAdmin.SuspendLayout();
            this.ssAdmin.SuspendLayout();
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
            this.tsmiSearchStudent.Click += new System.EventHandler(this.tsmiSearchStudent_Click);
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
            this.tsmiStudentList.Click += new System.EventHandler(this.tsmiStudentList_Click);
            // 
            // tsmiTeacherList
            // 
            this.tsmiTeacherList.Name = "tsmiTeacherList";
            this.tsmiTeacherList.Size = new System.Drawing.Size(142, 22);
            this.tsmiTeacherList.Text = "教员信息列表";
            this.tsmiTeacherList.Click += new System.EventHandler(this.tsmiTeacherList_Click);
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
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsAdmin
            // 
            this.tsAdmin.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbNewUser,
            this.tsbtnSearchStudent,
            this.tsbtnStudentList,
            this.tsbtnTeacherList,
            this.tsbtnQuestion,
            this.tsbtnExam});
            this.tsAdmin.Location = new System.Drawing.Point(0, 24);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(611, 31);
            this.tsAdmin.TabIndex = 1;
            this.tsAdmin.Text = "管理员工具";
            // 
            // tsddbNewUser
            // 
            this.tsddbNewUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNewStudent,
            this.tsbtnNewTeacher});
            this.tsddbNewUser.Image = ((System.Drawing.Image)(resources.GetObject("tsddbNewUser.Image")));
            this.tsddbNewUser.Name = "tsddbNewUser";
            this.tsddbNewUser.Size = new System.Drawing.Size(90, 28);
            this.tsddbNewUser.Text = "新增用户";
            // 
            // tsbtnNewStudent
            // 
            this.tsbtnNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewStudent.Image")));
            this.tsbtnNewStudent.Name = "tsbtnNewStudent";
            this.tsbtnNewStudent.Size = new System.Drawing.Size(142, 22);
            this.tsbtnNewStudent.Text = "新增学员用户";
            this.tsbtnNewStudent.Click += new System.EventHandler(this.tsmiNewStudent_Click);
            // 
            // tsbtnNewTeacher
            // 
            this.tsbtnNewTeacher.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewTeacher.Image")));
            this.tsbtnNewTeacher.Name = "tsbtnNewTeacher";
            this.tsbtnNewTeacher.Size = new System.Drawing.Size(142, 22);
            this.tsbtnNewTeacher.Text = "新增教员用户";
            // 
            // tsbtnSearchStudent
            // 
            this.tsbtnSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchStudent.Image")));
            this.tsbtnSearchStudent.Name = "tsbtnSearchStudent";
            this.tsbtnSearchStudent.Size = new System.Drawing.Size(117, 28);
            this.tsbtnSearchStudent.Text = "查询及修改学员";
            this.tsbtnSearchStudent.Click += new System.EventHandler(this.tsmiSearchStudent_Click);
            // 
            // tsbtnStudentList
            // 
            this.tsbtnStudentList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStudentList.Image")));
            this.tsbtnStudentList.Name = "tsbtnStudentList";
            this.tsbtnStudentList.Size = new System.Drawing.Size(105, 28);
            this.tsbtnStudentList.Text = "学员信息列表";
            this.tsbtnStudentList.Click += new System.EventHandler(this.tsmiStudentList_Click);
            // 
            // tsbtnTeacherList
            // 
            this.tsbtnTeacherList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTeacherList.Image")));
            this.tsbtnTeacherList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTeacherList.Name = "tsbtnTeacherList";
            this.tsbtnTeacherList.Size = new System.Drawing.Size(105, 28);
            this.tsbtnTeacherList.Text = "教员信息列表";
            this.tsbtnTeacherList.Click += new System.EventHandler(this.tsmiTeacherList_Click);
            // 
            // tsbtnQuestion
            // 
            this.tsbtnQuestion.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnQuestion.Image")));
            this.tsbtnQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuestion.Name = "tsbtnQuestion";
            this.tsbtnQuestion.Size = new System.Drawing.Size(81, 28);
            this.tsbtnQuestion.Text = "题库管理";
            // 
            // tsbtnExam
            // 
            this.tsbtnExam.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExam.Image")));
            this.tsbtnExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExam.Name = "tsbtnExam";
            this.tsbtnExam.Size = new System.Drawing.Size(81, 28);
            this.tsbtnExam.Text = "考试管理";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // slblAdmin
            // 
            this.slblAdmin.Name = "slblAdmin";
            this.slblAdmin.Size = new System.Drawing.Size(65, 17);
            this.slblAdmin.Text = "管理员窗口";
            // 
            // ssAdmin
            // 
            this.ssAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblAdmin});
            this.ssAdmin.Location = new System.Drawing.Point(0, 378);
            this.ssAdmin.Name = "ssAdmin";
            this.ssAdmin.Size = new System.Drawing.Size(611, 22);
            this.ssAdmin.TabIndex = 2;
            this.ssAdmin.Text = "管理员窗口";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 400);
            this.Controls.Add(this.ssAdmin);
            this.Controls.Add(this.tsAdmin);
            this.Controls.Add(this.msAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAdmin;
            this.Name = "AdminForm";
            this.Text = "MySchool-管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.tsAdmin.ResumeLayout(false);
            this.tsAdmin.PerformLayout();
            this.ssAdmin.ResumeLayout(false);
            this.ssAdmin.PerformLayout();
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
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStripButton tsbtnStudentList;
        private System.Windows.Forms.ToolStripButton tsbtnSearchStudent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel slblAdmin;
        private System.Windows.Forms.StatusStrip ssAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTeacher;
        private System.Windows.Forms.ToolStripButton tsbtnQuestion;
        private System.Windows.Forms.ToolStripDropDownButton tsddbNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsbtnNewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsbtnNewTeacher;
        private System.Windows.Forms.ToolStripButton tsbtnExam;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestion;
        private System.Windows.Forms.ToolStripMenuItem tsmiExam;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripButton tsbtnTeacherList;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentList;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeacherList;
    }
}

