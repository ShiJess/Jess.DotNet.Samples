namespace SimpleForm
{
    partial class myfirstapp0
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
            this.btn_catchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_catchMe
            // 
            this.btn_catchMe.Location = new System.Drawing.Point(97, 91);
            this.btn_catchMe.Name = "btn_catchMe";
            this.btn_catchMe.Size = new System.Drawing.Size(75, 23);
            this.btn_catchMe.TabIndex = 0;
            this.btn_catchMe.Text = "来抓我呀";
            this.btn_catchMe.UseVisualStyleBackColor = true;
            this.btn_catchMe.Click += new System.EventHandler(this.btn_catchMe_Click);
            // 
            // myfirstapp0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_catchMe);
            this.Name = "myfirstapp0";
            this.Text = "点不中的按钮";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myfirstapp0_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_catchMe;
    }
}