namespace IntermediateForm
{
    partial class imageConvert
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
            this.cmbOpenFiletype = new System.Windows.Forms.ComboBox();
            this.cmbSaveFiletype = new System.Windows.Forms.ComboBox();
            this.btnOpenfile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOpenFiletype
            // 
            this.cmbOpenFiletype.FormattingEnabled = true;
            this.cmbOpenFiletype.Items.AddRange(new object[] {
            "*.bmp",
            "*.jpg",
            "*.gif",
            "*.tiff"});
            this.cmbOpenFiletype.Location = new System.Drawing.Point(23, 38);
            this.cmbOpenFiletype.Name = "cmbOpenFiletype";
            this.cmbOpenFiletype.Size = new System.Drawing.Size(75, 20);
            this.cmbOpenFiletype.TabIndex = 0;
            // 
            // cmbSaveFiletype
            // 
            this.cmbSaveFiletype.FormattingEnabled = true;
            this.cmbSaveFiletype.Items.AddRange(new object[] {
            "*.bmp",
            "*.jpg",
            "*.gif",
            "*.tiff"});
            this.cmbSaveFiletype.Location = new System.Drawing.Point(23, 182);
            this.cmbSaveFiletype.Name = "cmbSaveFiletype";
            this.cmbSaveFiletype.Size = new System.Drawing.Size(75, 20);
            this.cmbSaveFiletype.TabIndex = 1;
            // 
            // btnOpenfile
            // 
            this.btnOpenfile.Location = new System.Drawing.Point(23, 86);
            this.btnOpenfile.Name = "btnOpenfile";
            this.btnOpenfile.Size = new System.Drawing.Size(75, 51);
            this.btnOpenfile.TabIndex = 2;
            this.btnOpenfile.Text = "打开...";
            this.btnOpenfile.UseVisualStyleBackColor = true;
            this.btnOpenfile.Click += new System.EventHandler(this.btnOpenfile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "转换...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbOpenFiletype);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbSaveFiletype);
            this.panel1.Controls.Add(this.btnOpenfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(380, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 356);
            this.panel1.TabIndex = 5;
            // 
            // imageConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "imageConvert";
            this.Text = "图像转换器";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpenFiletype;
        private System.Windows.Forms.ComboBox cmbSaveFiletype;
        private System.Windows.Forms.Button btnOpenfile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}