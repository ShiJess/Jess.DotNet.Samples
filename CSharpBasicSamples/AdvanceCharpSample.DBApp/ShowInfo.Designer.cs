namespace ConnectionAccess
{
    partial class ShowInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInfo));
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picPhotos = new System.Windows.Forms.PictureBox();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluserStateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colLoginID,
            this.colLoginPwd,
            this.coluserStateID,
            this.colClassID,
            this.colStudentNo,
            this.colStudentName,
            this.colSex,
            this.colMajor,
            this.colPhone,
            this.colAddress,
            this.colEmail,
            this.colPhotos});
            this.dgvShow.Location = new System.Drawing.Point(1, 51);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(744, 320);
            this.dgvShow.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(173, 12);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "输入用户登录名种所含的字符：";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(184, 12);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(100, 21);
            this.txtFont.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(543, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(650, 378);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "关闭";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(299, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picPhotos
            // 
            this.picPhotos.Image = ((System.Drawing.Image)(resources.GetObject("picPhotos.Image")));
            this.picPhotos.Location = new System.Drawing.Point(748, 51);
            this.picPhotos.Name = "picPhotos";
            this.picPhotos.Size = new System.Drawing.Size(290, 320);
            this.picPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhotos.TabIndex = 6;
            this.picPhotos.TabStop = false;
            // 
            // colStudentID
            // 
            this.colStudentID.DataPropertyName = "StudentID";
            this.colStudentID.HeaderText = "ID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Visible = false;
            // 
            // colLoginID
            // 
            this.colLoginID.DataPropertyName = "LoginID";
            this.colLoginID.HeaderText = "账号";
            this.colLoginID.Name = "colLoginID";
            // 
            // colLoginPwd
            // 
            this.colLoginPwd.DataPropertyName = "LoginPwd";
            this.colLoginPwd.HeaderText = "密码";
            this.colLoginPwd.Name = "colLoginPwd";
            // 
            // coluserStateID
            // 
            this.coluserStateID.DataPropertyName = "userStateID";
            this.coluserStateID.HeaderText = "用户状态";
            this.coluserStateID.Name = "coluserStateID";
            // 
            // colClassID
            // 
            this.colClassID.DataPropertyName = "ClassID";
            this.colClassID.HeaderText = "班级";
            this.colClassID.Name = "colClassID";
            // 
            // colStudentNo
            // 
            this.colStudentNo.DataPropertyName = "StudentNO";
            this.colStudentNo.HeaderText = "学号";
            this.colStudentNo.Name = "colStudentNo";
            // 
            // colStudentName
            // 
            this.colStudentName.DataPropertyName = "StudentName";
            this.colStudentName.HeaderText = "姓名";
            this.colStudentName.Name = "colStudentName";
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            // 
            // colMajor
            // 
            this.colMajor.DataPropertyName = "Major";
            this.colMajor.HeaderText = "职业";
            this.colMajor.Name = "colMajor";
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "电话";
            this.colPhone.Name = "colPhone";
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "住址";
            this.colAddress.Name = "colAddress";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "电子邮箱";
            this.colEmail.Name = "colEmail";
            // 
            // colPhotos
            // 
            this.colPhotos.DataPropertyName = "Photos";
            this.colPhotos.HeaderText = "头像";
            this.colPhotos.Name = "colPhotos";
            this.colPhotos.Visible = false;
            // 
            // ShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 413);
            this.Controls.Add(this.picPhotos);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowInfo";
            this.Text = "显示用户的登录信息";
            this.Load += new System.EventHandler(this.ShowInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picPhotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluserStateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhotos;
    }
}

