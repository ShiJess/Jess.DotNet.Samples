namespace IntermediateForm
{
    partial class addCtrlAtRuntimeApp
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
            this.btn_addButtons = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_addButtons
            // 
            this.btn_addButtons.Location = new System.Drawing.Point(117, 12);
            this.btn_addButtons.Name = "btn_addButtons";
            this.btn_addButtons.Size = new System.Drawing.Size(155, 23);
            this.btn_addButtons.TabIndex = 0;
            this.btn_addButtons.Text = "添加按钮";
            this.btn_addButtons.UseVisualStyleBackColor = true;
            this.btn_addButtons.Click += new System.EventHandler(this.btn_addButtons_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(117, 41);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(155, 21);
            this.txt_msg.TabIndex = 1;
            // 
            // addCtrlAtRuntimeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.btn_addButtons);
            this.Name = "addCtrlAtRuntimeApp";
            this.Text = "动态添加控件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addButtons;
        private System.Windows.Forms.TextBox txt_msg;
    }
}