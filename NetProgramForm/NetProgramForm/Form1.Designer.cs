namespace NetProgramForm
{
    partial class Form1
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
            this.Exemple63 = new System.Windows.Forms.Button();
            this.Exemple64 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exemple63
            // 
            this.Exemple63.Location = new System.Drawing.Point(13, 13);
            this.Exemple63.Name = "Exemple63";
            this.Exemple63.Size = new System.Drawing.Size(259, 23);
            this.Exemple63.TabIndex = 0;
            this.Exemple63.Text = "实例63 发送SMTP邮件";
            this.Exemple63.UseVisualStyleBackColor = true;
            this.Exemple63.Click += new System.EventHandler(this.Exemple63_Click);
            // 
            // Exemple64
            // 
            this.Exemple64.Location = new System.Drawing.Point(13, 43);
            this.Exemple64.Name = "Exemple64";
            this.Exemple64.Size = new System.Drawing.Size(259, 23);
            this.Exemple64.TabIndex = 1;
            this.Exemple64.Text = "实例64 邮件提示器[不可用]";
            this.Exemple64.UseVisualStyleBackColor = true;
            this.Exemple64.Click += new System.EventHandler(this.Exemple64_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "实验65 网页上传/下载器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exemple64);
            this.Controls.Add(this.Exemple63);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exemple63;
        private System.Windows.Forms.Button Exemple64;
        private System.Windows.Forms.Button button1;

    }
}

