namespace NetProgramForm
{
    partial class Webbrowse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.txtbrowse = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnres = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.rddownload = new System.Windows.Forms.RadioButton();
            this.rdupload = new System.Windows.Forms.RadioButton();
            this.rddataload = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "存为";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(100, 28);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(208, 21);
            this.textbox1.TabIndex = 2;
            // 
            // txtbrowse
            // 
            this.txtbrowse.Location = new System.Drawing.Point(100, 124);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(208, 21);
            this.txtbrowse.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(110, 65);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "开始下载";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnres
            // 
            this.btnres.Location = new System.Drawing.Point(206, 65);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(75, 23);
            this.btnres.TabIndex = 5;
            this.btnres.Text = "初始化";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(347, 122);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 6;
            this.btnbrowse.Text = "浏览...";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // rddownload
            // 
            this.rddownload.AutoSize = true;
            this.rddownload.Location = new System.Drawing.Point(347, 33);
            this.rddownload.Name = "rddownload";
            this.rddownload.Size = new System.Drawing.Size(47, 16);
            this.rddownload.TabIndex = 7;
            this.rddownload.TabStop = true;
            this.rddownload.Text = "下载";
            this.rddownload.UseVisualStyleBackColor = true;
            this.rddownload.Click += new System.EventHandler(this.rddownload_Click);
            // 
            // rdupload
            // 
            this.rdupload.AutoSize = true;
            this.rdupload.Location = new System.Drawing.Point(347, 55);
            this.rdupload.Name = "rdupload";
            this.rdupload.Size = new System.Drawing.Size(47, 16);
            this.rdupload.TabIndex = 8;
            this.rdupload.TabStop = true;
            this.rdupload.Text = "上载";
            this.rdupload.UseVisualStyleBackColor = true;
            // 
            // rddataload
            // 
            this.rddataload.AutoSize = true;
            this.rddataload.Location = new System.Drawing.Point(347, 77);
            this.rddataload.Name = "rddataload";
            this.rddataload.Size = new System.Drawing.Size(71, 16);
            this.rddataload.TabIndex = 9;
            this.rddataload.TabStop = true;
            this.rddataload.Text = "数据下载";
            this.rddataload.UseVisualStyleBackColor = true;
            // 
            // Webbrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 201);
            this.Controls.Add(this.rddataload);
            this.Controls.Add(this.rdupload);
            this.Controls.Add(this.rddownload);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtbrowse);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Webbrowse";
            this.Text = "Webbrowse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox txtbrowse;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.RadioButton rddownload;
        private System.Windows.Forms.RadioButton rdupload;
        private System.Windows.Forms.RadioButton rddataload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}