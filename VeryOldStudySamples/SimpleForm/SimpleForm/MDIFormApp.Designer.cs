namespace SimpleForm
{
    partial class MDIFormApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Window = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Window});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew,
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // FileNew
            // 
            this.FileNew.Name = "FileNew";
            this.FileNew.Size = new System.Drawing.Size(152, 22);
            this.FileNew.Text = "新建(&N)";
            this.FileNew.Click += new System.EventHandler(this.FileNew_Click);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(152, 22);
            this.FileExit.Text = "退出(&E)";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // Window
            // 
            this.Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascade,
            this.WindowHorizontal,
            this.WindowVertical});
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(64, 21);
            this.Window.Text = "窗口(&W)";
            // 
            // WindowCascade
            // 
            this.WindowCascade.Name = "WindowCascade";
            this.WindowCascade.Size = new System.Drawing.Size(152, 22);
            this.WindowCascade.Text = "层叠(&C)";
            this.WindowCascade.Click += new System.EventHandler(this.WindowCascade_Click);
            // 
            // WindowHorizontal
            // 
            this.WindowHorizontal.Name = "WindowHorizontal";
            this.WindowHorizontal.Size = new System.Drawing.Size(152, 22);
            this.WindowHorizontal.Text = "水平排列(&H)";
            this.WindowHorizontal.Click += new System.EventHandler(this.WindowHorizontal_Click);
            // 
            // WindowVertical
            // 
            this.WindowVertical.Name = "WindowVertical";
            this.WindowVertical.Size = new System.Drawing.Size(152, 22);
            this.WindowVertical.Text = "竖直排列(&V)";
            this.WindowVertical.Click += new System.EventHandler(this.WindowVertical_Click);
            // 
            // MDIFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIFormApp";
            this.Text = "多窗口应用程序";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileNew;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem Window;
        private System.Windows.Forms.ToolStripMenuItem WindowCascade;
        private System.Windows.Forms.ToolStripMenuItem WindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem WindowVertical;
    }
}