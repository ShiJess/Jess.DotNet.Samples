namespace IntermediateForm
{
    partial class textSearch
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
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ckInclude = new System.Windows.Forms.CheckBox();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.chkNotListAll = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(12, 35);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(352, 21);
            this.txtDir.TabIndex = 0;
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            this.txtDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDir_KeyDown);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(384, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "浏览...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ckInclude
            // 
            this.ckInclude.AutoSize = true;
            this.ckInclude.Location = new System.Drawing.Point(280, 13);
            this.ckInclude.Name = "ckInclude";
            this.ckInclude.Size = new System.Drawing.Size(84, 16);
            this.ckInclude.TabIndex = 2;
            this.ckInclude.Text = "包含子目录";
            this.ckInclude.UseVisualStyleBackColor = true;
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(12, 86);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(93, 21);
            this.txtFiles.TabIndex = 3;
            this.txtFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiles_KeyDown);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(126, 86);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(135, 21);
            this.txtSearchText.TabIndex = 4;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
            // 
            // txtResults
            // 
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(0, 161);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(471, 183);
            this.txtResults.TabIndex = 5;
            // 
            // chkNotListAll
            // 
            this.chkNotListAll.AutoSize = true;
            this.chkNotListAll.Location = new System.Drawing.Point(93, 136);
            this.chkNotListAll.Name = "chkNotListAll";
            this.chkNotListAll.Size = new System.Drawing.Size(168, 16);
            this.chkNotListAll.TabIndex = 6;
            this.chkNotListAll.Text = "只显示包含搜索文字的文件";
            this.chkNotListAll.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(289, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "文件扩展名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "搜索文字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "结果";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 161);
            this.panel1.TabIndex = 12;
            // 
            // textSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkNotListAll);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.ckInclude);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.panel1);
            this.Name = "textSearch";
            this.Text = "文本搜索器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox ckInclude;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.CheckBox chkNotListAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}