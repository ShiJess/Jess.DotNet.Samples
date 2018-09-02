namespace MySchool
{
    partial class TeacherListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherListForm));
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToResizeColumns = false;
            this.dgvTeacher.AllowUserToResizeRows = false;
            this.dgvTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLoginId,
            this.colLoginPwd,
            this.colTeacherName,
            this.colSex,
            this.colBirthday});
            this.dgvTeacher.Location = new System.Drawing.Point(12, 12);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowTemplate.Height = 23;
            this.dgvTeacher.Size = new System.Drawing.Size(606, 278);
            this.dgvTeacher.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "TeacherID";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colLoginId
            // 
            this.colLoginId.DataPropertyName = "LoginId";
            this.colLoginId.HeaderText = "用户名";
            this.colLoginId.Name = "colLoginId";
            // 
            // colLoginPwd
            // 
            this.colLoginPwd.DataPropertyName = "LoginPwd";
            this.colLoginPwd.HeaderText = "密码";
            this.colLoginPwd.Name = "colLoginPwd";
            // 
            // colTeacherName
            // 
            this.colTeacherName.DataPropertyName = "TeacherName";
            this.colTeacherName.HeaderText = "姓名";
            this.colTeacherName.Name = "colTeacherName";
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBirthday
            // 
            this.colBirthday.DataPropertyName = "Birthday";
            this.colBirthday.HeaderText = "生日";
            this.colBirthday.Name = "colBirthday";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(463, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "保存修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(544, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TeacherListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(630, 330);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教员信息列表";
            this.Load += new System.EventHandler(this.TeacherListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthday;
    }
}