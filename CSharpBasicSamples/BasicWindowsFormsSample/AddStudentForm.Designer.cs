namespace MySchool
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPswAgain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPswAgain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.radInactive = new System.Windows.Forms.RadioButton();
            this.lblState = new System.Windows.Forms.Label();
            this.pnlState = new System.Windows.Forms.Panel();
            this.lstGrade = new System.Windows.Forms.ListBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.grpBasee = new System.Windows.Forms.GroupBox();
            this.pnlState.SuspendLayout();
            this.pnlSex.SuspendLayout();
            this.grpRegister.SuspendLayout();
            this.grpBasee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(39, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 12);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Location = new System.Drawing.Point(99, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 47);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 12);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "密码";
            // 
            // lblPswAgain
            // 
            this.lblPswAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPswAgain.AutoSize = true;
            this.lblPswAgain.Location = new System.Drawing.Point(27, 73);
            this.lblPswAgain.Name = "lblPswAgain";
            this.lblPswAgain.Size = new System.Drawing.Size(53, 12);
            this.lblPswAgain.TabIndex = 6;
            this.lblPswAgain.Text = "确认密码";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(99, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtPswAgain
            // 
            this.txtPswAgain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPswAgain.Location = new System.Drawing.Point(99, 69);
            this.txtPswAgain.Name = "txtPswAgain";
            this.txtPswAgain.PasswordChar = '*';
            this.txtPswAgain.Size = new System.Drawing.Size(155, 21);
            this.txtPswAgain.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(130, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(211, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "姓名";
            // 
            // lblTel
            // 
            this.lblTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(43, 78);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(29, 12);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "电话";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(99, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 21);
            this.txtName.TabIndex = 0;
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
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(44, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "地址";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 12);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "电子邮件";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Location = new System.Drawing.Point(99, 47);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 21);
            this.txtAddress.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(99, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 21);
            this.txtEmail.TabIndex = 3;
            // 
            // radActive
            // 
            this.radActive.AutoSize = true;
            this.radActive.Checked = true;
            this.radActive.Location = new System.Drawing.Point(19, 3);
            this.radActive.Name = "radActive";
            this.radActive.Size = new System.Drawing.Size(47, 16);
            this.radActive.TabIndex = 0;
            this.radActive.TabStop = true;
            this.radActive.Tag = "1";
            this.radActive.Text = "活动";
            this.radActive.UseVisualStyleBackColor = true;
            // 
            // radInactive
            // 
            this.radInactive.AutoSize = true;
            this.radInactive.Location = new System.Drawing.Point(79, 3);
            this.radInactive.Name = "radInactive";
            this.radInactive.Size = new System.Drawing.Size(59, 16);
            this.radInactive.TabIndex = 1;
            this.radInactive.Tag = "0";
            this.radInactive.Text = "非活动";
            this.radInactive.UseVisualStyleBackColor = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(51, 103);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(29, 12);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "状态";
            // 
            // pnlState
            // 
            this.pnlState.Controls.Add(this.radActive);
            this.pnlState.Controls.Add(this.radInactive);
            this.pnlState.Location = new System.Drawing.Point(99, 96);
            this.pnlState.Name = "pnlState";
            this.pnlState.Size = new System.Drawing.Size(155, 21);
            this.pnlState.TabIndex = 7;
            // 
            // lstGrade
            // 
            this.lstGrade.FormattingEnabled = true;
            this.lstGrade.ItemHeight = 12;
            this.lstGrade.Items.AddRange(new object[] {
            "S1",
            "S2",
            "Y2"});
            this.lstGrade.Location = new System.Drawing.Point(100, 158);
            this.lstGrade.Name = "lstGrade";
            this.lstGrade.Size = new System.Drawing.Size(155, 16);
            this.lstGrade.TabIndex = 16;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(99, 74);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(156, 21);
            this.txtTel.TabIndex = 15;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(44, 135);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 14;
            this.lblSex.Text = "性别";
            // 
            // pnlSex
            // 
            this.pnlSex.Controls.Add(this.rdoMale);
            this.pnlSex.Controls.Add(this.rdoFemale);
            this.pnlSex.Location = new System.Drawing.Point(100, 130);
            this.pnlSex.Name = "pnlSex";
            this.pnlSex.Size = new System.Drawing.Size(155, 22);
            this.pnlSex.TabIndex = 13;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(100, 180);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(155, 20);
            this.cboClass.TabIndex = 6;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(44, 184);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "班级";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(44, 160);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 11;
            this.lblGrade.Text = "年级";
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.lblState);
            this.grpRegister.Controls.Add(this.lblUserName);
            this.grpRegister.Controls.Add(this.pnlState);
            this.grpRegister.Controls.Add(this.lblPassword);
            this.grpRegister.Controls.Add(this.txtPswAgain);
            this.grpRegister.Controls.Add(this.txtPassword);
            this.grpRegister.Controls.Add(this.txtUserName);
            this.grpRegister.Controls.Add(this.lblPswAgain);
            this.grpRegister.Location = new System.Drawing.Point(17, 14);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(271, 134);
            this.grpRegister.TabIndex = 5;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "用户注册信息";
            // 
            // grpBasee
            // 
            this.grpBasee.Controls.Add(this.lstGrade);
            this.grpBasee.Controls.Add(this.lblName);
            this.grpBasee.Controls.Add(this.txtName);
            this.grpBasee.Controls.Add(this.txtTel);
            this.grpBasee.Controls.Add(this.lblGrade);
            this.grpBasee.Controls.Add(this.lblTel);
            this.grpBasee.Controls.Add(this.lblAddress);
            this.grpBasee.Controls.Add(this.lblSex);
            this.grpBasee.Controls.Add(this.lblClass);
            this.grpBasee.Controls.Add(this.txtAddress);
            this.grpBasee.Controls.Add(this.lblEmail);
            this.grpBasee.Controls.Add(this.pnlSex);
            this.grpBasee.Controls.Add(this.cboClass);
            this.grpBasee.Controls.Add(this.txtEmail);
            this.grpBasee.Location = new System.Drawing.Point(16, 156);
            this.grpBasee.Name = "grpBasee";
            this.grpBasee.Size = new System.Drawing.Size(272, 215);
            this.grpBasee.TabIndex = 6;
            this.grpBasee.TabStop = false;
            this.grpBasee.Text = "用户基本信息";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 414);
            this.Controls.Add(this.grpBasee);
            this.Controls.Add(this.grpRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建学员用户";
            this.pnlState.ResumeLayout(false);
            this.pnlState.PerformLayout();
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.grpBasee.ResumeLayout(false);
            this.grpBasee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPswAgain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPswAgain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton radActive;
        private System.Windows.Forms.RadioButton radInactive;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Panel pnlState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ListBox lstGrade;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.GroupBox grpBasee;
    }
}