namespace MySchool
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.lblLoginId = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.lblPwdAgain = new System.Windows.Forms.Label();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblStudentNO = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtStudentNO = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.rdoInactive = new System.Windows.Forms.RadioButton();
            this.lblUserState = new System.Windows.Forms.Label();
            this.pnlState = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.tabNewStudent = new System.Windows.Forms.TabControl();
            this.tpRegisterInfo = new System.Windows.Forms.TabPage();
            this.tpBaseInfo = new System.Windows.Forms.TabPage();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.pnlState.SuspendLayout();
            this.pnlSex.SuspendLayout();
            this.tabNewStudent.SuspendLayout();
            this.tpRegisterInfo.SuspendLayout();
            this.tpBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginId
            // 
            this.lblLoginId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Location = new System.Drawing.Point(47, 46);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(41, 12);
            this.lblLoginId.TabIndex = 0;
            this.lblLoginId.Text = "用户名";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginId.Location = new System.Drawing.Point(107, 42);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(155, 21);
            this.txtLoginId.TabIndex = 1;
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(59, 94);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(29, 12);
            this.lblLoginPwd.TabIndex = 2;
            this.lblLoginPwd.Text = "密码";
            // 
            // lblPwdAgain
            // 
            this.lblPwdAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPwdAgain.AutoSize = true;
            this.lblPwdAgain.Location = new System.Drawing.Point(35, 143);
            this.lblPwdAgain.Name = "lblPwdAgain";
            this.lblPwdAgain.Size = new System.Drawing.Size(53, 12);
            this.lblPwdAgain.TabIndex = 4;
            this.lblPwdAgain.Text = "确认密码";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginPwd.Location = new System.Drawing.Point(107, 90);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(155, 21);
            this.txtLoginPwd.TabIndex = 3;
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwdAgain.Location = new System.Drawing.Point(107, 139);
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(155, 21);
            this.txtPwdAgain.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(157, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(238, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(50, 15);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(29, 12);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "姓名";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(50, 86);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "电话";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentName.Location = new System.Drawing.Point(105, 11);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(156, 21);
            this.txtStudentName.TabIndex = 1;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(19, 3);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(86, 3);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblStudentNO
            // 
            this.lblStudentNO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentNO.AutoSize = true;
            this.lblStudentNO.Location = new System.Drawing.Point(50, 51);
            this.lblStudentNO.Name = "lblStudentNO";
            this.lblStudentNO.Size = new System.Drawing.Size(29, 12);
            this.lblStudentNO.TabIndex = 2;
            this.lblStudentNO.Text = "学号";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 12);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "电子邮件";
            // 
            // txtStudentNO
            // 
            this.txtStudentNO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentNO.Location = new System.Drawing.Point(105, 47);
            this.txtStudentNO.Name = "txtStudentNO";
            this.txtStudentNO.Size = new System.Drawing.Size(156, 21);
            this.txtStudentNO.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(105, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 21);
            this.txtEmail.TabIndex = 7;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Checked = true;
            this.rdoActive.Location = new System.Drawing.Point(19, 3);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(47, 16);
            this.rdoActive.TabIndex = 0;
            this.rdoActive.TabStop = true;
            this.rdoActive.Tag = "1";
            this.rdoActive.Text = "活动";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // rdoInactive
            // 
            this.rdoInactive.AutoSize = true;
            this.rdoInactive.Location = new System.Drawing.Point(79, 3);
            this.rdoInactive.Name = "rdoInactive";
            this.rdoInactive.Size = new System.Drawing.Size(59, 16);
            this.rdoInactive.TabIndex = 1;
            this.rdoInactive.Tag = "0";
            this.rdoInactive.Text = "非活动";
            this.rdoInactive.UseVisualStyleBackColor = true;
            // 
            // lblUserState
            // 
            this.lblUserState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserState.AutoSize = true;
            this.lblUserState.Location = new System.Drawing.Point(59, 192);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(29, 12);
            this.lblUserState.TabIndex = 6;
            this.lblUserState.Text = "状态";
            // 
            // pnlState
            // 
            this.pnlState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlState.Controls.Add(this.rdoActive);
            this.pnlState.Controls.Add(this.rdoInactive);
            this.pnlState.Location = new System.Drawing.Point(107, 188);
            this.pnlState.Name = "pnlState";
            this.pnlState.Size = new System.Drawing.Size(155, 21);
            this.pnlState.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 82);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(50, 154);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "性别";
            // 
            // pnlSex
            // 
            this.pnlSex.Controls.Add(this.rdoMale);
            this.pnlSex.Controls.Add(this.rdoFemale);
            this.pnlSex.Location = new System.Drawing.Point(106, 149);
            this.pnlSex.Name = "pnlSex";
            this.pnlSex.Size = new System.Drawing.Size(155, 22);
            this.pnlSex.TabIndex = 9;
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(106, 208);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(155, 20);
            this.cboClass.TabIndex = 13;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(50, 212);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "班级";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(50, 181);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 10;
            this.lblGrade.Text = "年级";
            // 
            // tabNewStudent
            // 
            this.tabNewStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabNewStudent.Controls.Add(this.tpRegisterInfo);
            this.tabNewStudent.Controls.Add(this.tpBaseInfo);
            this.tabNewStudent.Location = new System.Drawing.Point(12, 12);
            this.tabNewStudent.Name = "tabNewStudent";
            this.tabNewStudent.SelectedIndex = 0;
            this.tabNewStudent.Size = new System.Drawing.Size(301, 279);
            this.tabNewStudent.TabIndex = 0;
            // 
            // tpRegisterInfo
            // 
            this.tpRegisterInfo.Controls.Add(this.lblUserState);
            this.tpRegisterInfo.Controls.Add(this.pnlState);
            this.tpRegisterInfo.Controls.Add(this.txtPwdAgain);
            this.tpRegisterInfo.Controls.Add(this.lblLoginId);
            this.tpRegisterInfo.Controls.Add(this.lblPwdAgain);
            this.tpRegisterInfo.Controls.Add(this.txtLoginId);
            this.tpRegisterInfo.Controls.Add(this.txtLoginPwd);
            this.tpRegisterInfo.Controls.Add(this.lblLoginPwd);
            this.tpRegisterInfo.Location = new System.Drawing.Point(4, 21);
            this.tpRegisterInfo.Name = "tpRegisterInfo";
            this.tpRegisterInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegisterInfo.Size = new System.Drawing.Size(293, 254);
            this.tpRegisterInfo.TabIndex = 0;
            this.tpRegisterInfo.Text = "用户注册信息";
            this.tpRegisterInfo.UseVisualStyleBackColor = true;
            // 
            // tpBaseInfo
            // 
            this.tpBaseInfo.Controls.Add(this.cboGrade);
            this.tpBaseInfo.Controls.Add(this.lblStudentName);
            this.tpBaseInfo.Controls.Add(this.txtPhone);
            this.tpBaseInfo.Controls.Add(this.lblPhone);
            this.tpBaseInfo.Controls.Add(this.lblSex);
            this.tpBaseInfo.Controls.Add(this.txtStudentNO);
            this.tpBaseInfo.Controls.Add(this.pnlSex);
            this.tpBaseInfo.Controls.Add(this.txtEmail);
            this.tpBaseInfo.Controls.Add(this.cboClass);
            this.tpBaseInfo.Controls.Add(this.lblEmail);
            this.tpBaseInfo.Controls.Add(this.lblClass);
            this.tpBaseInfo.Controls.Add(this.lblStudentNO);
            this.tpBaseInfo.Controls.Add(this.lblGrade);
            this.tpBaseInfo.Controls.Add(this.txtStudentName);
            this.tpBaseInfo.Location = new System.Drawing.Point(4, 21);
            this.tpBaseInfo.Name = "tpBaseInfo";
            this.tpBaseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaseInfo.Size = new System.Drawing.Size(293, 254);
            this.tpBaseInfo.TabIndex = 1;
            this.tpBaseInfo.Text = "用户基本信息";
            this.tpBaseInfo.UseVisualStyleBackColor = true;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(106, 178);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(156, 20);
            this.cboGrade.TabIndex = 11;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 329);
            this.Controls.Add(this.tabNewStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建学员用户";
            this.pnlState.ResumeLayout(false);
            this.pnlState.PerformLayout();
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            this.tabNewStudent.ResumeLayout(false);
            this.tpRegisterInfo.ResumeLayout(false);
            this.tpRegisterInfo.PerformLayout();
            this.tpBaseInfo.ResumeLayout(false);
            this.tpBaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.Label lblPwdAgain;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblStudentNO;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtStudentNO;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdoActive;
        private System.Windows.Forms.RadioButton rdoInactive;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Panel pnlState;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TabControl tabNewStudent;
        private System.Windows.Forms.TabPage tpRegisterInfo;
        private System.Windows.Forms.TabPage tpBaseInfo;
        private System.Windows.Forms.ComboBox cboGrade;
    }
}