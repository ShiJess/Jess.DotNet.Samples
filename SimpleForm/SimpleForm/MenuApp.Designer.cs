namespace SimpleForm
{
    partial class MenuApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripFileExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripViewRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripViewYellow = new System.Windows.Forms.ToolStripButton();
            this.toolStripViewBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHelpAbout = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(152, 22);
            this.FileExit.Text = "退出(&E)";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewRed,
            this.ViewYellow,
            this.ViewBlue});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(60, 21);
            this.View.Text = "视图(&V)";
            // 
            // ViewRed
            // 
            this.ViewRed.Name = "ViewRed";
            this.ViewRed.Size = new System.Drawing.Size(152, 22);
            this.ViewRed.Text = "红色(&R)";
            this.ViewRed.Click += new System.EventHandler(this.ViewRed_Click);
            // 
            // ViewYellow
            // 
            this.ViewYellow.Name = "ViewYellow";
            this.ViewYellow.Size = new System.Drawing.Size(152, 22);
            this.ViewYellow.Text = "黄色(&Y)";
            this.ViewYellow.Click += new System.EventHandler(this.ViewYellow_Click);
            // 
            // ViewBlue
            // 
            this.ViewBlue.Name = "ViewBlue";
            this.ViewBlue.Size = new System.Drawing.Size(152, 22);
            this.ViewBlue.Text = "蓝色(B)";
            this.ViewBlue.Click += new System.EventHandler(this.ViewBlue_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(152, 22);
            this.HelpAbout.Text = "关于...";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileExit,
            this.toolStripSeparator1,
            this.toolStripViewRed,
            this.toolStripViewYellow,
            this.toolStripViewBlue,
            this.toolStripSeparator2,
            this.toolStripHelpAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripFileExit
            // 
            this.toolStripFileExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFileExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFileExit.Image")));
            this.toolStripFileExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFileExit.Name = "toolStripFileExit";
            this.toolStripFileExit.Size = new System.Drawing.Size(36, 22);
            this.toolStripFileExit.Text = "退出";
            this.toolStripFileExit.ToolTipText = "退出程序";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripViewRed
            // 
            this.toolStripViewRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripViewRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripViewRed.Image")));
            this.toolStripViewRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripViewRed.Name = "toolStripViewRed";
            this.toolStripViewRed.Size = new System.Drawing.Size(24, 22);
            this.toolStripViewRed.Text = "红";
            this.toolStripViewRed.ToolTipText = "把窗体设置为红色";
            // 
            // toolStripViewYellow
            // 
            this.toolStripViewYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripViewYellow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripViewYellow.Image")));
            this.toolStripViewYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripViewYellow.Name = "toolStripViewYellow";
            this.toolStripViewYellow.Size = new System.Drawing.Size(24, 22);
            this.toolStripViewYellow.Text = "黄";
            this.toolStripViewYellow.ToolTipText = "把窗体设置为黄色";
            // 
            // toolStripViewBlue
            // 
            this.toolStripViewBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripViewBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripViewBlue.Image")));
            this.toolStripViewBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripViewBlue.Name = "toolStripViewBlue";
            this.toolStripViewBlue.Size = new System.Drawing.Size(24, 22);
            this.toolStripViewBlue.Text = "蓝";
            this.toolStripViewBlue.ToolTipText = "把窗体设置为蓝色";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripHelpAbout
            // 
            this.toolStripHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHelpAbout.Image")));
            this.toolStripHelpAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelpAbout.Name = "toolStripHelpAbout";
            this.toolStripHelpAbout.Size = new System.Drawing.Size(36, 22);
            this.toolStripHelpAbout.Text = "关于";
            this.toolStripHelpAbout.ToolTipText = "帮助信息";
            // 
            // MenuApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuApp";
            this.Text = "使用菜单";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem ViewRed;
        private System.Windows.Forms.ToolStripMenuItem ViewYellow;
        private System.Windows.Forms.ToolStripMenuItem ViewBlue;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripViewRed;
        private System.Windows.Forms.ToolStripButton toolStripViewYellow;
        private System.Windows.Forms.ToolStripButton toolStripViewBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripHelpAbout;
    }
}