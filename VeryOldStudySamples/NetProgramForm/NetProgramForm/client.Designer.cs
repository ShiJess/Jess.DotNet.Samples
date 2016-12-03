namespace NetProgramForm
{
    partial class client
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
            this.tbclient = new System.Windows.Forms.TextBox();
            this.tbinput = new System.Windows.Forms.TextBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbclient
            // 
            this.tbclient.Location = new System.Drawing.Point(25, 12);
            this.tbclient.Multiline = true;
            this.tbclient.Name = "tbclient";
            this.tbclient.Size = new System.Drawing.Size(193, 127);
            this.tbclient.TabIndex = 0;
            // 
            // tbinput
            // 
            this.tbinput.Location = new System.Drawing.Point(25, 164);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(179, 21);
            this.tbinput.TabIndex = 1;
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(46, 212);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(75, 23);
            this.btnconnect.TabIndex = 2;
            this.btnconnect.Text = "开始连接";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(128, 211);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "发送";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.tbclient);
            this.Name = "client";
            this.Text = "client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbclient;
        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btnsend;
    }
}