namespace SimpleForm
{
    partial class FolderDialog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("我的电脑");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderDialog));
            this.FolderTree = new System.Windows.Forms.TreeView();
            this.fileIconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // FolderTree
            // 
            this.FolderTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTree.ImageIndex = 0;
            this.FolderTree.ImageList = this.fileIconList;
            this.FolderTree.Location = new System.Drawing.Point(0, 0);
            this.FolderTree.Name = "FolderTree";
            treeNode1.Name = "节点0";
            treeNode1.Text = "我的电脑";
            this.FolderTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.FolderTree.SelectedImageIndex = 0;
            this.FolderTree.Size = new System.Drawing.Size(470, 350);
            this.FolderTree.TabIndex = 0;
            this.FolderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FloderTree_AfterSelect);
            // 
            // fileIconList
            // 
            this.fileIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIconList.ImageStream")));
            this.fileIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIconList.Images.SetKeyName(0, "0.ico");
            this.fileIconList.Images.SetKeyName(1, "1.ico");
            this.fileIconList.Images.SetKeyName(2, "2.ico");
            this.fileIconList.Images.SetKeyName(3, "3.ico");
            this.fileIconList.Images.SetKeyName(4, "4.ico");
            this.fileIconList.Images.SetKeyName(5, "5.ico");
            this.fileIconList.Images.SetKeyName(6, "6.ico");
            this.fileIconList.Images.SetKeyName(7, "7.ico");
            this.fileIconList.Images.SetKeyName(8, "8.ico");
            this.fileIconList.Images.SetKeyName(9, "9.ico");
            this.fileIconList.Images.SetKeyName(10, "10.ico");
            this.fileIconList.Images.SetKeyName(11, "11.ico");
            this.fileIconList.Images.SetKeyName(12, "12.ico");
            this.fileIconList.Images.SetKeyName(13, "13.ico");
            this.fileIconList.Images.SetKeyName(14, "14.ico");
            this.fileIconList.Images.SetKeyName(15, "15.ico");
            this.fileIconList.Images.SetKeyName(16, "16.ico");
            this.fileIconList.Images.SetKeyName(17, "17.ico");
            this.fileIconList.Images.SetKeyName(18, "18.ico");
            this.fileIconList.Images.SetKeyName(19, "19.ico");
            // 
            // FolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 342);
            this.Controls.Add(this.FolderTree);
            this.Name = "FolderDialog";
            this.Text = "浏览我的电脑";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FolderTree;
        private System.Windows.Forms.ImageList fileIconList;
    }
}