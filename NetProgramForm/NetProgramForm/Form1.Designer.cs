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
            this.Exemple51 = new System.Windows.Forms.Button();
            this.Exemple52 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exemple51
            // 
            this.Exemple51.Location = new System.Drawing.Point(13, 13);
            this.Exemple51.Name = "Exemple51";
            this.Exemple51.Size = new System.Drawing.Size(259, 23);
            this.Exemple51.TabIndex = 0;
            this.Exemple51.Text = "实例51 用Socket建立服务器程序";
            this.Exemple51.UseVisualStyleBackColor = true;
            this.Exemple51.Click += new System.EventHandler(this.Exemple51_Click);
            // 
            // Exemple52
            // 
            this.Exemple52.Location = new System.Drawing.Point(13, 43);
            this.Exemple52.Name = "Exemple52";
            this.Exemple52.Size = new System.Drawing.Size(259, 23);
            this.Exemple52.TabIndex = 1;
            this.Exemple52.Text = "实例52 用Socket建立客户端程序";
            this.Exemple52.UseVisualStyleBackColor = true;
            this.Exemple52.Click += new System.EventHandler(this.Exemple52_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Exemple52);
            this.Controls.Add(this.Exemple51);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exemple51;
        private System.Windows.Forms.Button Exemple52;

    }
}

