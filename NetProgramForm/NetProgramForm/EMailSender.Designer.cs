namespace NetProgramForm
{
    partial class EMailSender
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
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.CCTextBox = new System.Windows.Forms.TextBox();
            this.BCCTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.AttachmentTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(73, 9);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(279, 21);
            this.FromTextBox.TabIndex = 0;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(73, 38);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(279, 21);
            this.ToTextBox.TabIndex = 1;
            // 
            // CCTextBox
            // 
            this.CCTextBox.Location = new System.Drawing.Point(73, 65);
            this.CCTextBox.Name = "CCTextBox";
            this.CCTextBox.Size = new System.Drawing.Size(279, 21);
            this.CCTextBox.TabIndex = 2;
            // 
            // BCCTextBox
            // 
            this.BCCTextBox.Location = new System.Drawing.Point(73, 93);
            this.BCCTextBox.Name = "BCCTextBox";
            this.BCCTextBox.Size = new System.Drawing.Size(279, 21);
            this.BCCTextBox.TabIndex = 3;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(73, 121);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(279, 21);
            this.SubjectTextBox.TabIndex = 4;
            // 
            // AttachmentTextBox
            // 
            this.AttachmentTextBox.Location = new System.Drawing.Point(73, 153);
            this.AttachmentTextBox.Name = "AttachmentTextBox";
            this.AttachmentTextBox.Size = new System.Drawing.Size(201, 21);
            this.AttachmentTextBox.TabIndex = 5;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(28, 182);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(324, 252);
            this.MessageTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "发自";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "发往";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "抄送";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "密送";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "主题";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "附件";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(277, 153);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 13;
            this.BrowseButton.Text = "浏览...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(73, 450);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 14;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(199, 450);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "请选择邮件附件";
            // 
            // EMailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 485);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.AttachmentTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.BCCTextBox);
            this.Controls.Add(this.CCTextBox);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Name = "EMailSender";
            this.Text = "EMailSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.TextBox CCTextBox;
        private System.Windows.Forms.TextBox BCCTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.TextBox AttachmentTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}