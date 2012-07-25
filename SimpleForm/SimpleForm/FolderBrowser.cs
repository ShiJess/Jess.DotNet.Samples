using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SimpleForm
{
    public partial class FolderDialog : Form
    {
        public FolderDialog()
        {
            InitializeComponent();
        }

        private void FloderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.ToString() != "我的电脑")//判断是否为根节点
                EnumDirectories(e.Node);
            else
                EnumDrives(e.Node);
            
        }

        //添加根目录节点
        private void EnumDrives(TreeNode ParentNode)
        {
            if(ParentNode.Nodes.Count==0)
            {
                foreach(string drive in Directory.GetLogicalDrives())
                {
                    FolderTree.SelectedNode = ParentNode;
                    TreeNode TempNode = new TreeNode();
                    TempNode.Text = drive.Substring(0,drive.Length-1);
                    TempNode.Tag = drive;
                    TempNode.ImageIndex = 1;
                    TempNode.SelectedImageIndex = 1;
                    FolderTree.SelectedNode.Nodes.Add(TempNode);
                    FolderTree.SelectedNode.Nodes[FolderTree.SelectedNode.Nodes.Count-1].EnsureVisible();
                }
            }
        }

        //添加非根目录节点
        private void EnumDirectories(TreeNode ParentNode)
        {
            FolderTree.SelectedNode = ParentNode;
            string DirectoryPath = ParentNode.Tag.ToString();
            if(ParentNode.Nodes.Count==0)
            {
                if(DirectoryPath.Substring(DirectoryPath.Length-1)!=@"\")
                    DirectoryPath+=@"\";
                try
                {
                    foreach(string directory in Directory.GetDirectories(DirectoryPath))
                    {
                        TreeNode TempNode = new TreeNode();
                        TempNode.Text = directory.Substring(directory.LastIndexOf(@"\")+1);
                        TempNode.Tag = directory;
                        TempNode.ImageIndex = 3;
                        TempNode.SelectedImageIndex = 2;
                        TempNode.SelectedImageIndex = 2;
                        FolderTree.SelectedNode.Nodes.Add(TempNode);
                        FolderTree.SelectedNode.Nodes[FolderTree.SelectedNode.Nodes.Count-1].EnsureVisible();
                    }
                }
                catch(Exception)
                {
                }
            }
        }
    }
}
