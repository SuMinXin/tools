namespace MergeTools
{
    partial class FormatForm
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
            this.txt_ExportName = new System.Windows.Forms.TextBox();
            this.btn_ExportTxt = new System.Windows.Forms.Button();
            this.btn_ExportXml = new System.Windows.Forms.Button();
            this.txt_Split = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.radioBtn_Encrypt = new System.Windows.Forms.RadioButton();
            this.txtHiddenCount = new System.Windows.Forms.TextBox();
            this.txtHiddenKey = new System.Windows.Forms.TextBox();
            this.richtxt_Output = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioBtn_Compress = new System.Windows.Forms.RadioButton();
            this.radioBtn_Format = new System.Windows.Forms.RadioButton();
            this.btn_DeCompress = new System.Windows.Forms.Button();
            this.btn_Compress = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_toJson = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SaveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Tran = new System.Windows.Forms.Button();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.tool_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ExportName
            // 
            this.txt_ExportName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ExportName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExportName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ExportName.Location = new System.Drawing.Point(468, 763);
            this.txt_ExportName.Name = "txt_ExportName";
            this.txt_ExportName.Size = new System.Drawing.Size(281, 33);
            this.txt_ExportName.TabIndex = 26;
            // 
            // btn_ExportTxt
            // 
            this.btn_ExportTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ExportTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ExportTxt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ExportTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_ExportTxt.Location = new System.Drawing.Point(757, 760);
            this.btn_ExportTxt.Name = "btn_ExportTxt";
            this.btn_ExportTxt.Size = new System.Drawing.Size(110, 40);
            this.btn_ExportTxt.TabIndex = 25;
            this.btn_ExportTxt.Text = "匯出TXT";
            this.btn_ExportTxt.UseVisualStyleBackColor = false;
            this.btn_ExportTxt.Click += new System.EventHandler(this.btn_ExportTxt_Click);
            // 
            // btn_ExportXml
            // 
            this.btn_ExportXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportXml.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ExportXml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ExportXml.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ExportXml.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_ExportXml.Location = new System.Drawing.Point(870, 760);
            this.btn_ExportXml.Name = "btn_ExportXml";
            this.btn_ExportXml.Size = new System.Drawing.Size(110, 40);
            this.btn_ExportXml.TabIndex = 24;
            this.btn_ExportXml.Text = "匯出XML";
            this.btn_ExportXml.UseVisualStyleBackColor = false;
            this.btn_ExportXml.Click += new System.EventHandler(this.btn_ExportXml_Click);
            // 
            // txt_Split
            // 
            this.txt_Split.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Split.Location = new System.Drawing.Point(75, 5);
            this.txt_Split.Name = "txt_Split";
            this.txt_Split.Size = new System.Drawing.Size(27, 29);
            this.txt_Split.TabIndex = 23;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Decrypt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Decrypt.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Decrypt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Decrypt.Location = new System.Drawing.Point(1010, 55);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(121, 45);
            this.btn_Decrypt.TabIndex = 22;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Visible = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Encrypt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Encrypt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Encrypt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Encrypt.Location = new System.Drawing.Point(1010, 5);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(121, 45);
            this.btn_Encrypt.TabIndex = 21;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = false;
            this.btn_Encrypt.Visible = false;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // radioBtn_Encrypt
            // 
            this.radioBtn_Encrypt.AutoSize = true;
            this.radioBtn_Encrypt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtn_Encrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioBtn_Encrypt.Location = new System.Drawing.Point(3, 69);
            this.radioBtn_Encrypt.Name = "radioBtn_Encrypt";
            this.radioBtn_Encrypt.Size = new System.Drawing.Size(98, 28);
            this.radioBtn_Encrypt.TabIndex = 20;
            this.radioBtn_Encrypt.TabStop = true;
            this.radioBtn_Encrypt.Text = "Encrypt";
            this.radioBtn_Encrypt.UseVisualStyleBackColor = true;
            this.radioBtn_Encrypt.CheckedChanged += new System.EventHandler(this.radioBtn_Encrypt_CheckedChanged);
            // 
            // txtHiddenCount
            // 
            this.txtHiddenCount.Location = new System.Drawing.Point(25, 122);
            this.txtHiddenCount.Name = "txtHiddenCount";
            this.txtHiddenCount.Size = new System.Drawing.Size(100, 22);
            this.txtHiddenCount.TabIndex = 19;
            this.txtHiddenCount.Visible = false;
            // 
            // txtHiddenKey
            // 
            this.txtHiddenKey.Location = new System.Drawing.Point(23, 94);
            this.txtHiddenKey.Name = "txtHiddenKey";
            this.txtHiddenKey.Size = new System.Drawing.Size(100, 22);
            this.txtHiddenKey.TabIndex = 18;
            this.txtHiddenKey.Visible = false;
            // 
            // richtxt_Output
            // 
            this.richtxt_Output.AutoSize = true;
            this.richtxt_Output.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richtxt_Output.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richtxt_Output.Location = new System.Drawing.Point(9, 157);
            this.richtxt_Output.Name = "richtxt_Output";
            this.richtxt_Output.Size = new System.Drawing.Size(1117, 600);
            this.richtxt_Output.TabIndex = 17;
            this.richtxt_Output.Text = "";
            this.richtxt_Output.TextChanged += new System.EventHandler(this.richtxt_Output_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearch.Location = new System.Drawing.Point(923, 170);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 25);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radioBtn_Compress
            // 
            this.radioBtn_Compress.AutoSize = true;
            this.radioBtn_Compress.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtn_Compress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioBtn_Compress.Location = new System.Drawing.Point(3, 37);
            this.radioBtn_Compress.Name = "radioBtn_Compress";
            this.radioBtn_Compress.Size = new System.Drawing.Size(120, 28);
            this.radioBtn_Compress.TabIndex = 15;
            this.radioBtn_Compress.TabStop = true;
            this.radioBtn_Compress.Text = "Compress";
            this.radioBtn_Compress.UseVisualStyleBackColor = true;
            this.radioBtn_Compress.CheckedChanged += new System.EventHandler(this.radioBtn_Compress_CheckedChanged);
            // 
            // radioBtn_Format
            // 
            this.radioBtn_Format.AutoSize = true;
            this.radioBtn_Format.Checked = true;
            this.radioBtn_Format.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtn_Format.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioBtn_Format.Location = new System.Drawing.Point(3, 3);
            this.radioBtn_Format.Name = "radioBtn_Format";
            this.radioBtn_Format.Size = new System.Drawing.Size(66, 28);
            this.radioBtn_Format.TabIndex = 14;
            this.radioBtn_Format.TabStop = true;
            this.radioBtn_Format.Text = "排版";
            this.radioBtn_Format.UseVisualStyleBackColor = true;
            this.radioBtn_Format.CheckedChanged += new System.EventHandler(this.radioBtn_Format_CheckedChanged);
            // 
            // btn_DeCompress
            // 
            this.btn_DeCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeCompress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DeCompress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DeCompress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DeCompress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_DeCompress.Location = new System.Drawing.Point(1010, 55);
            this.btn_DeCompress.Name = "btn_DeCompress";
            this.btn_DeCompress.Size = new System.Drawing.Size(121, 45);
            this.btn_DeCompress.TabIndex = 13;
            this.btn_DeCompress.Text = "DeCompress";
            this.btn_DeCompress.UseVisualStyleBackColor = false;
            this.btn_DeCompress.Visible = false;
            this.btn_DeCompress.Click += new System.EventHandler(this.btn_DeCompress_Click);
            // 
            // btn_Compress
            // 
            this.btn_Compress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Compress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Compress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Compress.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Compress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Compress.Location = new System.Drawing.Point(1010, 5);
            this.btn_Compress.Name = "btn_Compress";
            this.btn_Compress.Size = new System.Drawing.Size(121, 45);
            this.btn_Compress.TabIndex = 12;
            this.btn_Compress.Text = "Compress";
            this.btn_Compress.UseVisualStyleBackColor = false;
            this.btn_Compress.Visible = false;
            this.btn_Compress.Click += new System.EventHandler(this.btn_Compress_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Copy.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Copy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Copy.Location = new System.Drawing.Point(1018, 760);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(110, 40);
            this.btn_Copy.TabIndex = 10;
            this.btn_Copy.Text = "複製";
            this.btn_Copy.UseVisualStyleBackColor = false;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_toJson
            // 
            this.btn_toJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toJson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_toJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_toJson.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_toJson.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_toJson.Location = new System.Drawing.Point(1010, 55);
            this.btn_toJson.Name = "btn_toJson";
            this.btn_toJson.Size = new System.Drawing.Size(121, 45);
            this.btn_toJson.TabIndex = 9;
            this.btn_toJson.Text = "ToFormat";
            this.btn_toJson.UseVisualStyleBackColor = false;
            this.btn_toJson.Click += new System.EventHandler(this.btn_toJson_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Clear.Location = new System.Drawing.Point(1010, 105);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(121, 45);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // SaveImageToolStripMenuItem
            // 
            this.SaveImageToolStripMenuItem.Name = "SaveImageToolStripMenuItem";
            this.SaveImageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.SaveImageToolStripMenuItem.Text = "Save image";
            // 
            // btn_Tran
            // 
            this.btn_Tran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tran.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Tran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Tran.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Tran.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Tran.Location = new System.Drawing.Point(1010, 5);
            this.btn_Tran.Name = "btn_Tran";
            this.btn_Tran.Size = new System.Drawing.Size(121, 45);
            this.btn_Tran.TabIndex = 6;
            this.btn_Tran.Text = "ToString";
            this.btn_Tran.UseVisualStyleBackColor = false;
            this.btn_Tran.Click += new System.EventHandler(this.btn_Tran_Click);
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Input.Location = new System.Drawing.Point(129, 6);
            this.txt_Input.MaxLength = 5000000;
            this.txt_Input.Multiline = true;
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(873, 145);
            this.txt_Input.TabIndex = 1;
            this.txt_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menu_panel
            // 
            this.menu_panel.Location = new System.Drawing.Point(12, 8);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1131, 59);
            this.menu_panel.TabIndex = 27;
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.radioBtn_Format);
            this.tool_panel.Controls.Add(this.radioBtn_Compress);
            this.tool_panel.Controls.Add(this.btn_Copy);
            this.tool_panel.Controls.Add(this.btn_ExportXml);
            this.tool_panel.Controls.Add(this.btn_ExportTxt);
            this.tool_panel.Controls.Add(this.txt_ExportName);
            this.tool_panel.Controls.Add(this.radioBtn_Encrypt);
            this.tool_panel.Controls.Add(this.txt_Split);
            this.tool_panel.Controls.Add(this.txt_Input);
            this.tool_panel.Controls.Add(this.btn_DeCompress);
            this.tool_panel.Controls.Add(this.richtxt_Output);
            this.tool_panel.Controls.Add(this.btn_Clear);
            this.tool_panel.Controls.Add(this.btn_toJson);
            this.tool_panel.Controls.Add(this.btn_Decrypt);
            this.tool_panel.Controls.Add(this.txtHiddenKey);
            this.tool_panel.Controls.Add(this.btn_Encrypt);
            this.tool_panel.Controls.Add(this.btn_Compress);
            this.tool_panel.Controls.Add(this.txtHiddenCount);
            this.tool_panel.Controls.Add(this.txtSearch);
            this.tool_panel.Controls.Add(this.btn_Tran);
            this.tool_panel.Location = new System.Drawing.Point(12, 73);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(1132, 805);
            this.tool_panel.TabIndex = 28;
            // 
            // FormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1149, 865);
            this.Controls.Add(this.tool_panel);
            this.Controls.Add(this.menu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format&Compress";
            this.Load += new System.EventHandler(this.Format_Load);
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ExportName;
        private System.Windows.Forms.Button btn_ExportTxt;
        private System.Windows.Forms.Button btn_ExportXml;
        private System.Windows.Forms.TextBox txt_Split;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.RadioButton radioBtn_Encrypt;
        private System.Windows.Forms.TextBox txtHiddenCount;
        private System.Windows.Forms.TextBox txtHiddenKey;
        private System.Windows.Forms.RichTextBox richtxt_Output;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioBtn_Compress;
        private System.Windows.Forms.RadioButton radioBtn_Format;
        private System.Windows.Forms.Button btn_DeCompress;
        private System.Windows.Forms.Button btn_Compress;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_toJson;
        private System.Windows.Forms.Button btn_Clear;
        internal System.Windows.Forms.ToolStripMenuItem SaveImageToolStripMenuItem;
        private System.Windows.Forms.Button btn_Tran;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel tool_panel;
    }
}

