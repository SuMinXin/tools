namespace MergeTools
{
    partial class ConnectForm
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
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_MD5 = new System.Windows.Forms.Button();
            this.lbl_Dec = new System.Windows.Forms.Label();
            this.lbl_Enc = new System.Windows.Forms.Label();
            this.richTxt_Dec = new System.Windows.Forms.RichTextBox();
            this.richTxt_Enc = new System.Windows.Forms.RichTextBox();
            this.rBtn_TKT = new System.Windows.Forms.RadioButton();
            this.rBtn_newGDS = new System.Windows.Forms.RadioButton();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.rBtn_SERP = new System.Windows.Forms.RadioButton();
            this.tool_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(583, 179);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 0;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseMnemonic = false;
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(583, 72);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 2;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_MD5
            // 
            this.btn_MD5.Location = new System.Drawing.Point(583, 207);
            this.btn_MD5.Name = "btn_MD5";
            this.btn_MD5.Size = new System.Drawing.Size(75, 23);
            this.btn_MD5.TabIndex = 4;
            this.btn_MD5.Text = "MD5 Encrypt";
            this.btn_MD5.UseVisualStyleBackColor = true;
            this.btn_MD5.Visible = false;
            this.btn_MD5.Click += new System.EventHandler(this.btn_MD5_Click);
            // 
            // lbl_Dec
            // 
            this.lbl_Dec.AutoSize = true;
            this.lbl_Dec.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Dec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Dec.Location = new System.Drawing.Point(21, 49);
            this.lbl_Dec.Name = "lbl_Dec";
            this.lbl_Dec.Size = new System.Drawing.Size(41, 20);
            this.lbl_Dec.TabIndex = 5;
            this.lbl_Dec.Text = "明碼";
            // 
            // lbl_Enc
            // 
            this.lbl_Enc.AutoSize = true;
            this.lbl_Enc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Enc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Enc.Location = new System.Drawing.Point(21, 155);
            this.lbl_Enc.Name = "lbl_Enc";
            this.lbl_Enc.Size = new System.Drawing.Size(41, 20);
            this.lbl_Enc.TabIndex = 6;
            this.lbl_Enc.Text = "密碼";
            // 
            // richTxt_Dec
            // 
            this.richTxt_Dec.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTxt_Dec.Location = new System.Drawing.Point(23, 72);
            this.richTxt_Dec.Name = "richTxt_Dec";
            this.richTxt_Dec.Size = new System.Drawing.Size(554, 52);
            this.richTxt_Dec.TabIndex = 7;
            this.richTxt_Dec.Text = "";
            // 
            // richTxt_Enc
            // 
            this.richTxt_Enc.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTxt_Enc.Location = new System.Drawing.Point(23, 178);
            this.richTxt_Enc.Name = "richTxt_Enc";
            this.richTxt_Enc.Size = new System.Drawing.Size(554, 52);
            this.richTxt_Enc.TabIndex = 8;
            this.richTxt_Enc.Text = "";
            // 
            // rBtn_TKT
            // 
            this.rBtn_TKT.AutoSize = true;
            this.rBtn_TKT.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn_TKT.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rBtn_TKT.Location = new System.Drawing.Point(25, 5);
            this.rBtn_TKT.Name = "rBtn_TKT";
            this.rBtn_TKT.Size = new System.Drawing.Size(62, 28);
            this.rBtn_TKT.TabIndex = 9;
            this.rBtn_TKT.TabStop = true;
            this.rBtn_TKT.Text = "TKT";
            this.rBtn_TKT.UseVisualStyleBackColor = true;
            this.rBtn_TKT.CheckedChanged += new System.EventHandler(this.rBtn_TKT_CheckedChanged);
            // 
            // rBtn_newGDS
            // 
            this.rBtn_newGDS.AutoSize = true;
            this.rBtn_newGDS.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn_newGDS.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rBtn_newGDS.Location = new System.Drawing.Point(100, 5);
            this.rBtn_newGDS.Name = "rBtn_newGDS";
            this.rBtn_newGDS.Size = new System.Drawing.Size(106, 28);
            this.rBtn_newGDS.TabIndex = 10;
            this.rBtn_newGDS.TabStop = true;
            this.rBtn_newGDS.Text = "newGDS";
            this.rBtn_newGDS.UseVisualStyleBackColor = true;
            this.rBtn_newGDS.CheckedChanged += new System.EventHandler(this.rBtn_newGDS_CheckedChanged);
            // 
            // menu_panel
            // 
            this.menu_panel.Location = new System.Drawing.Point(2, 11);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(674, 42);
            this.menu_panel.TabIndex = 11;
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.rBtn_SERP);
            this.tool_panel.Controls.Add(this.rBtn_TKT);
            this.tool_panel.Controls.Add(this.rBtn_newGDS);
            this.tool_panel.Controls.Add(this.btn_MD5);
            this.tool_panel.Controls.Add(this.richTxt_Enc);
            this.tool_panel.Controls.Add(this.btn_Decrypt);
            this.tool_panel.Controls.Add(this.btn_Encrypt);
            this.tool_panel.Controls.Add(this.lbl_Dec);
            this.tool_panel.Controls.Add(this.lbl_Enc);
            this.tool_panel.Controls.Add(this.richTxt_Dec);
            this.tool_panel.Location = new System.Drawing.Point(2, 59);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(674, 243);
            this.tool_panel.TabIndex = 0;
            // 
            // rBtn_SERP
            // 
            this.rBtn_SERP.AutoSize = true;
            this.rBtn_SERP.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rBtn_SERP.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rBtn_SERP.Location = new System.Drawing.Point(225, 5);
            this.rBtn_SERP.Name = "rBtn_SERP";
            this.rBtn_SERP.Size = new System.Drawing.Size(75, 28);
            this.rBtn_SERP.TabIndex = 11;
            this.rBtn_SERP.TabStop = true;
            this.rBtn_SERP.Text = "SERP";
            this.rBtn_SERP.UseVisualStyleBackColor = true;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 310);
            this.Controls.Add(this.tool_panel);
            this.Controls.Add(this.menu_panel);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "連線字串";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_MD5;
        private System.Windows.Forms.Label lbl_Dec;
        private System.Windows.Forms.Label lbl_Enc;
        private System.Windows.Forms.RichTextBox richTxt_Dec;
        private System.Windows.Forms.RichTextBox richTxt_Enc;
        private System.Windows.Forms.RadioButton rBtn_TKT;
        private System.Windows.Forms.RadioButton rBtn_newGDS;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.RadioButton rBtn_SERP;
    }
}

