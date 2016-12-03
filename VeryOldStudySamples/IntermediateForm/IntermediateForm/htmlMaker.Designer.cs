namespace IntermediateForm
{
    partial class htmlMaker
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbFilename = new System.Windows.Forms.TextBox();
            this.btnGeneraleCode = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.stbMsg0 = new System.Windows.Forms.StatusStrip();
            this.tstbMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbMsg0.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件名";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(136, 36);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 21);
            this.txbName.TabIndex = 2;
            this.txbName.Text = "who a u";
            // 
            // txbFilename
            // 
            this.txbFilename.Location = new System.Drawing.Point(136, 69);
            this.txbFilename.Name = "txbFilename";
            this.txbFilename.Size = new System.Drawing.Size(100, 21);
            this.txbFilename.TabIndex = 3;
            this.txbFilename.Text = "who a u.html";
            // 
            // btnGeneraleCode
            // 
            this.btnGeneraleCode.Location = new System.Drawing.Point(12, 134);
            this.btnGeneraleCode.Name = "btnGeneraleCode";
            this.btnGeneraleCode.Size = new System.Drawing.Size(75, 23);
            this.btnGeneraleCode.TabIndex = 4;
            this.btnGeneraleCode.Text = "生成";
            this.btnGeneraleCode.UseVisualStyleBackColor = true;
            this.btnGeneraleCode.Click += new System.EventHandler(this.btnGeneraleCode_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(93, 134);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "清空";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(183, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // stbMsg0
            // 
            this.stbMsg0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbMsg,
            this.stbMsg});
            this.stbMsg0.Location = new System.Drawing.Point(0, 240);
            this.stbMsg0.Name = "stbMsg0";
            this.stbMsg0.Size = new System.Drawing.Size(284, 22);
            this.stbMsg0.TabIndex = 7;
            // 
            // tstbMsg
            // 
            this.tstbMsg.Name = "tstbMsg";
            this.tstbMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // stbMsg
            // 
            this.stbMsg.Name = "stbMsg";
            this.stbMsg.Size = new System.Drawing.Size(12, 17);
            this.stbMsg.Text = " ";
            // 
            // htmlMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.stbMsg0);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnGeneraleCode);
            this.Controls.Add(this.txbFilename);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "htmlMaker";
            this.Text = "定制网页";
            this.stbMsg0.ResumeLayout(false);
            this.stbMsg0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbFilename;
        private System.Windows.Forms.Button btnGeneraleCode;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip stbMsg0;
        private System.Windows.Forms.ToolStripStatusLabel tstbMsg;
        private System.Windows.Forms.ToolStripStatusLabel stbMsg;
    }
}