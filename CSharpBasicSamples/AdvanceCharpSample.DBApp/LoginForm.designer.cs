namespace MySchool
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtLogInId = new System.Windows.Forms.TextBox();
            this.txtLogInPwd = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboLogInType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLogInId
            // 
            this.txtLogInId.Location = new System.Drawing.Point(214, 148);
            this.txtLogInId.Name = "txtLogInId";
            this.txtLogInId.Size = new System.Drawing.Size(122, 21);
            this.txtLogInId.TabIndex = 0;
            // 
            // txtLogInPwd
            // 
            this.txtLogInPwd.Location = new System.Drawing.Point(214, 182);
            this.txtLogInPwd.Name = "txtLogInPwd";
            this.txtLogInPwd.PasswordChar = '*';
            this.txtLogInPwd.Size = new System.Drawing.Size(122, 21);
            this.txtLogInPwd.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogIn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogIn.Location = new System.Drawing.Point(142, 262);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(86, 30);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "登　录";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(244, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取　消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboLogInType
            // 
            this.cboLogInType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLogInType.FormattingEnabled = true;
            this.cboLogInType.Items.AddRange(new object[] {
            "管理员",
            "学员",
            "教员"});
            this.cboLogInType.Location = new System.Drawing.Point(214, 217);
            this.cboLogInType.Name = "cboLogInType";
            this.cboLogInType.Size = new System.Drawing.Size(122, 20);
            this.cboLogInType.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(496, 300);
            this.Controls.Add(this.cboLogInType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtLogInPwd);
            this.Controls.Add(this.txtLogInId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogInId;
        private System.Windows.Forms.TextBox txtLogInPwd;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboLogInType;
    }
}