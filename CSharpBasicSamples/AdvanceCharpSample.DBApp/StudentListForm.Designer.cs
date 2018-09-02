namespace MySchool
{
    partial class StudentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentListForm));
            this.lblSex = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.btnReFill = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobWanted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(12, 19);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "按性别筛选";
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(92, 16);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(80, 20);
            this.cboSex.TabIndex = 2;
            this.cboSex.Tag = "";
            // 
            // btnReFill
            // 
            this.btnReFill.Location = new System.Drawing.Point(188, 14);
            this.btnReFill.Name = "btnReFill";
            this.btnReFill.Size = new System.Drawing.Size(75, 23);
            this.btnReFill.TabIndex = 3;
            this.btnReFill.Text = "筛选";
            this.btnReFill.UseVisualStyleBackColor = true;
            this.btnReFill.Click += new System.EventHandler(this.btnReFill_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(544, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentId,
            this.colLoginId,
            this.colStudentName,
            this.colStudentNO,
            this.colSex,
            this.colPhone,
            this.colAddress,
            this.colJobWanted});
            this.dgvStudent.Location = new System.Drawing.Point(13, 42);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.Size = new System.Drawing.Size(604, 244);
            this.dgvStudent.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(381, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "保存修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(463, 296);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // colStudentId
            // 
            this.colStudentId.DataPropertyName = "StudentID";
            this.colStudentId.Frozen = true;
            this.colStudentId.HeaderText = "标识";
            this.colStudentId.Name = "colStudentId";
            this.colStudentId.ReadOnly = true;
            this.colStudentId.Visible = false;
            // 
            // colLoginId
            // 
            this.colLoginId.DataPropertyName = "LoginId";
            this.colLoginId.Frozen = true;
            this.colLoginId.HeaderText = "用户名";
            this.colLoginId.Name = "colLoginId";
            this.colLoginId.Width = 80;
            // 
            // colStudentName
            // 
            this.colStudentName.DataPropertyName = "StudentName";
            this.colStudentName.Frozen = true;
            this.colStudentName.HeaderText = "姓名";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.Width = 80;
            // 
            // colStudentNO
            // 
            this.colStudentNO.DataPropertyName = "StudentNO";
            this.colStudentNO.HeaderText = "学号";
            this.colStudentNO.Name = "colStudentNO";
            this.colStudentNO.ReadOnly = true;
            this.colStudentNO.Width = 80;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.Width = 81;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "电话";
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 180;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "家庭地址";
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 280;
            // 
            // colJobWanted
            // 
            this.colJobWanted.DataPropertyName = "JobWanted";
            this.colJobWanted.HeaderText = "期望工作职位";
            this.colJobWanted.Name = "colJobWanted";
            this.colJobWanted.Width = 200;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 328);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReFill);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.lblSex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学员信息列表";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Button btnReFill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobWanted;
    }
}