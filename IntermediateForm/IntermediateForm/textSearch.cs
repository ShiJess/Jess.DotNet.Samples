using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Security;

namespace IntermediateForm
{
    public partial class textSearch : Form
    {

        ArrayList m_arrFiles = new ArrayList();


        public textSearch()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
           
            fdlg.Title = "Select a file";
            //fdlg.InitialDirectory = DirectoryInfo.CurrentDirectory;
            fdlg.Filter = "All files (*.*)|*.*";
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                String strPath = fdlg.FileName;
                //File Extension
                String strExt;
                //Get the Directory and file extension
                FileInfo f = new FileInfo(strPath);
                txtDir.Text = f.DirectoryName;
                strExt = f.Extension;
                //Eliminate the first '.'
                if (strExt != "")
                    strExt = strExt.Substring(1);
                txtFiles.Text = strExt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        protected void Search()
        {
            String strDir = txtDir.Text;
            //Check First if the Selected Directory exists
            DirectoryInfo dir = new DirectoryInfo(strDir);
            if (!dir.Exists)
                MessageBox.Show("Directory doesn't exist!", "Win Grep Error");
            else
            {
                Text = "文件内容搜索器 " + strDir;
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                //File Extension
                String strExt = txtFiles.Text;
                if (strExt != "")
                    if (strExt.StartsWith("."))
                    {
                        //Eliminate the first '.'
                        strExt = strExt.Substring(1);
                    }
                //First empty the list
                m_arrFiles.Clear();
                //Create recursively a list with all the files complying with the criteria
                GetFiles(strDir, strExt, ckInclude.Checked);
                //Now all the Files are in the ArrayList, open each one
                //iteratively and look for the search string
                String strSearch = txtSearchText.Text;
                String strResults = "";
                String strLine;
                int iLine;
                IEnumerator enm = m_arrFiles.GetEnumerator();
                while (enm.MoveNext())
                {
                    try
                    {
                        StreamReader sr = File.OpenText((string)enm.Current);
                        iLine = 0;
                        string strResultsInThisFile = "";
                        while ((strLine = sr.ReadLine()) != null)
                        {
                            iLine++;
                            //Search the Line for the Search Text
                            if (strLine.IndexOf(strSearch) != -1)
                            {
                                //Add the Line to Results string
                                strResultsInThisFile += "  " + iLine + ": " + strLine + "\r\n";
                            }
                        }
                        sr.Close();

                        if (chkNotListAll.Checked)
                        {
                            if (strResultsInThisFile.Length > 0)
                            {
                                strResults += "\r\n" + (string)enm.Current + ":\r\n";
                                strResults += strResultsInThisFile;
                            }
                        }
                        else
                        {
                            strResults += "\r\n" + (string)enm.Current + ":\r\n";
                            strResults += strResultsInThisFile;
                        }
                    }
                    catch (SecurityException)
                    {
                        strResults += "\r\n" + (string)enm.Current + ": Security Exception\r\n\r\n";
                    }
                    //catch(AccessException)
                    //{
                    //	strResults += "\r\n" + (string)enm.Current + ": Access Exception\r\n";
                    //}
                }
                txtResults.Text = strResults;
                Cursor = System.Windows.Forms.Cursors.Arrow;
            }
        }

        protected void GetFiles(String strDir, String strExt, bool bRecursive)
        {
            DirectoryInfo dir = new DirectoryInfo(strDir);
            FileInfo[] fileList = dir.GetFiles("*." + strExt);
            for (int i = 0; i < fileList.Length; i++)
            {
                if (fileList[i].Exists)
                    m_arrFiles.Add(strDir + "\\" + fileList[i].Name);
            }
            if (bRecursive == true)
            {
                //Get recursively from subdirectories
                DirectoryInfo[] dirList = dir.GetDirectories();
                for (int i = 0; i < dirList.Length; i++)
                {
                    GetFiles(strDir + "\\" + dirList[i].Name, strExt, bRecursive);
                }
            }
        }

        private void txtFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnSearch.Enabled == true)
            {
                Search();
            }
        }

        private void txtDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnSearch.Enabled == true)
            {
                Search();
            }
        }

        private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnSearch.Enabled == true)
            {
                Search();
            }
        }


        protected void VerifySearchBtn()
        {
            if (txtDir.Text != "" && txtSearchText.Text != "")
            {
                btnSearch.Enabled = true;
            }
            else
                btnSearch.Enabled = false;
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {
            VerifySearchBtn();
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            VerifySearchBtn();
        }


    }
}
