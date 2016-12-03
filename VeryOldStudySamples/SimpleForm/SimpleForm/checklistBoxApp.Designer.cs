namespace SimpleForm
{
    partial class checklistBoxApp
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.OldValue = new System.Windows.Forms.TextBox();
            this.NewValue = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ShowValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(8, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(264, 132);
            this.checkedListBox1.TabIndex = 0;
            // 
            // OldValue
            // 
            this.OldValue.Enabled = false;
            this.OldValue.Location = new System.Drawing.Point(24, 160);
            this.OldValue.Name = "OldValue";
            this.OldValue.Size = new System.Drawing.Size(100, 21);
            this.OldValue.TabIndex = 1;
            // 
            // NewValue
            // 
            this.NewValue.Location = new System.Drawing.Point(144, 160);
            this.NewValue.Name = "NewValue";
            this.NewValue.Size = new System.Drawing.Size(100, 21);
            this.NewValue.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(8, 200);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "添加(&A)";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(96, 200);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "删除(&D)";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ShowValues
            // 
            this.ShowValues.Location = new System.Drawing.Point(192, 200);
            this.ShowValues.Name = "ShowValues";
            this.ShowValues.Size = new System.Drawing.Size(75, 23);
            this.ShowValues.TabIndex = 5;
            this.ShowValues.Text = "显示(&S)";
            this.ShowValues.UseVisualStyleBackColor = true;
            this.ShowValues.Click += new System.EventHandler(this.ShowValues_Click);
            // 
            // checklistBoxApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.ShowValues);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.NewValue);
            this.Controls.Add(this.OldValue);
            this.Controls.Add(this.checkedListBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "checklistBoxApp";
            this.Text = "使用checklistBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox OldValue;
        private System.Windows.Forms.TextBox NewValue;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ShowValues;
    }
}