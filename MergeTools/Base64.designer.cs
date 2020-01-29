namespace MergeTools
{
    partial class Base64Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Trans = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.tool_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.AddExtension = false;
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Title = "請選擇檔案";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(446, 9);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 0;
            this.btn_SelectFile.Text = "選擇檔案";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(3, 9);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(437, 22);
            this.txt_Path.TabIndex = 1;
            // 
            // btn_Trans
            // 
            this.btn_Trans.Location = new System.Drawing.Point(446, 51);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(75, 23);
            this.btn_Trans.TabIndex = 2;
            this.btn_Trans.Text = "轉換並匯出";
            this.btn_Trans.UseVisualStyleBackColor = true;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(5, 54);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_Name.TabIndex = 3;
            this.txt_Name.Visible = false;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_output.Location = new System.Drawing.Point(5, 62);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(53, 12);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "執行結果";
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.txt_Path);
            this.tool_panel.Controls.Add(this.btn_Trans);
            this.tool_panel.Controls.Add(this.lbl_output);
            this.tool_panel.Controls.Add(this.btn_SelectFile);
            this.tool_panel.Controls.Add(this.txt_Name);
            this.tool_panel.Location = new System.Drawing.Point(0, 92);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(524, 100);
            this.tool_panel.TabIndex = 5;
            // 
            // menu_panel
            // 
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(524, 86);
            this.menu_panel.TabIndex = 6;
            // 
            // Base64Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(527, 200);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.tool_panel);
            this.Name = "Base64Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "轉Base64";
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_Trans;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.Panel menu_panel;
    }
}

