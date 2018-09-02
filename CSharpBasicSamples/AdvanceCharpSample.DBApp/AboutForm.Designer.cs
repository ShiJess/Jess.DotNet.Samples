namespace MySchool
{
    partial class AboutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ilAnimation = new System.Windows.Forms.ImageList(this.components);
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.picAnimation = new System.Windows.Forms.PictureBox();
            this.picOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            this.SuspendLayout();
            // 
            // ilAnimation
            // 
            this.ilAnimation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAnimation.ImageStream")));
            this.ilAnimation.TransparentColor = System.Drawing.Color.White;
            this.ilAnimation.Images.SetKeyName(0, "ya1.gif");
            this.ilAnimation.Images.SetKeyName(1, "ya2.gif");
            this.ilAnimation.Images.SetKeyName(2, "ya3.gif");
            this.ilAnimation.Images.SetKeyName(3, "ya4.gif");
            this.ilAnimation.Images.SetKeyName(4, "ya5.gif");
            this.ilAnimation.Images.SetKeyName(5, "ya6.gif");
            this.ilAnimation.Images.SetKeyName(6, "ya7.gif");
            this.ilAnimation.Images.SetKeyName(7, "ya8.gif");
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Enabled = true;
            this.tmrAnimation.Interval = 200;
            this.tmrAnimation.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // picAnimation
            // 
            this.picAnimation.BackColor = System.Drawing.Color.Transparent;
            this.picAnimation.Location = new System.Drawing.Point(52, 81);
            this.picAnimation.Name = "picAnimation";
            this.picAnimation.Size = new System.Drawing.Size(93, 64);
            this.picAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAnimation.TabIndex = 0;
            this.picAnimation.TabStop = false;
            // 
            // picOK
            // 
            this.picOK.BackColor = System.Drawing.Color.Transparent;
            this.picOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOK.Location = new System.Drawing.Point(297, 199);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(79, 22);
            this.picOK.TabIndex = 1;
            this.picOK.TabStop = false;
            this.picOK.Click += new System.EventHandler(this.picOK_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 276);
            this.Controls.Add(this.picOK);
            this.Controls.Add(this.picAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于我们";
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnimation;
        private System.Windows.Forms.ImageList ilAnimation;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.PictureBox picOK;
    }
}