namespace MySchool
{
    partial class SearchStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudentForm));
            this.lblLoginId = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.chLoginID = new System.Windows.Forms.ColumnHeader();
            this.chStudentName = new System.Windows.Forms.ColumnHeader();
            this.chStudentNO = new System.Windows.Forms.ColumnHeader();
            this.chUserState = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblLoginId
            // 
            this.lblLoginId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Location = new System.Drawing.Point(12, 20);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(41, 12);
            this.lblLoginId.TabIndex = 0;
            this.lblLoginId.Text = "用户名";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginId.Location = new System.Drawing.Point(68, 17);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(164, 21);
            this.txtLoginId.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(352, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(441, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblComment
            // 
            this.lblComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(238, 20);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(89, 12);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "(支持模糊查找)";
            // 
            // lvStudent
            // 
            this.lvStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLoginID,
            this.chStudentName,
            this.chStudentNO,
            this.chUserState});
            this.lvStudent.FullRowSelect = true;
            this.lvStudent.GridLines = true;
            this.lvStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStudent.Location = new System.Drawing.Point(14, 57);
            this.lvStudent.MultiSelect = false;
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(491, 167);
            this.lvStudent.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvStudent.TabIndex = 4;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            // 
            // chLoginID
            // 
            this.chLoginID.Text = "用户名";
            this.chLoginID.Width = 134;
            // 
            // chStudentName
            // 
            this.chStudentName.Text = "姓名";
            this.chStudentName.Width = 141;
            // 
            // chStudentNO
            // 
            this.chStudentNO.Text = "学号";
            this.chStudentNO.Width = 122;
            // 
            // chUserState
            // 
            this.chUserState.Text = "用户状态";
            this.chUserState.Width = 90;
            // 
            // SearchStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 263);
            this.Controls.Add(this.lvStudent);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblLoginId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLoginId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找学员用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.ColumnHeader chStudentName;
        private System.Windows.Forms.ColumnHeader chLoginID;
        private System.Windows.Forms.ColumnHeader chStudentNO;
        private System.Windows.Forms.ColumnHeader chUserState;
    }
}