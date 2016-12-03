namespace csharpconnectoracle
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
            this.btnselect = new System.Windows.Forms.Button();
            this.tboracle = new System.Windows.Forms.TextBox();
            this.btnselect1 = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(180, 12);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 78);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "查询";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // tboracle
            // 
            this.tboracle.Location = new System.Drawing.Point(27, 12);
            this.tboracle.Multiline = true;
            this.tboracle.Name = "tboracle";
            this.tboracle.Size = new System.Drawing.Size(134, 335);
            this.tboracle.TabIndex = 1;
            // 
            // btnselect1
            // 
            this.btnselect1.Location = new System.Drawing.Point(180, 115);
            this.btnselect1.Name = "btnselect1";
            this.btnselect1.Size = new System.Drawing.Size(75, 67);
            this.btnselect1.TabIndex = 2;
            this.btnselect1.Text = "查询1";
            this.btnselect1.UseVisualStyleBackColor = true;
            this.btnselect1.Click += new System.EventHandler(this.btnselect1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSett";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 359);
            this.Controls.Add(this.btnselect1);
            this.Controls.Add(this.tboracle);
            this.Controls.Add(this.btnselect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox tboracle;
        private System.Windows.Forms.Button btnselect1;
        private System.Data.DataSet dataSet1;
    }
}

