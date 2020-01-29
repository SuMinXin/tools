namespace MergeTools
{
    partial class CheckWebForm
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
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.btn_GO = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.richTxt_Result = new System.Windows.Forms.RichTextBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.tool_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(48, 3);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(685, 22);
            this.txt_URL.TabIndex = 0;
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_URL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_URL.Location = new System.Drawing.Point(8, 4);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(39, 20);
            this.lbl_URL.TabIndex = 1;
            this.lbl_URL.Text = "URL";
            // 
            // btn_GO
            // 
            this.btn_GO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GO.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GO.Location = new System.Drawing.Point(738, 0);
            this.btn_GO.Name = "btn_GO";
            this.btn_GO.Size = new System.Drawing.Size(44, 28);
            this.btn_GO.TabIndex = 2;
            this.btn_GO.Text = "GO";
            this.btn_GO.UseVisualStyleBackColor = false;
            this.btn_GO.Click += new System.EventHandler(this.btn_GO_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(7, 31);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(950, 465);
            this.webBrowser.TabIndex = 3;
            // 
            // richTxt_Result
            // 
            this.richTxt_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxt_Result.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTxt_Result.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTxt_Result.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTxt_Result.Location = new System.Drawing.Point(5, 502);
            this.richTxt_Result.Name = "richTxt_Result";
            this.richTxt_Result.Size = new System.Drawing.Size(950, 193);
            this.richTxt_Result.TabIndex = 4;
            this.richTxt_Result.Text = "";
            this.richTxt_Result.TextChanged += new System.EventHandler(this.richTxt_Result_TextChanged);
            // 
            // menu_panel
            // 
            this.menu_panel.Location = new System.Drawing.Point(6, 7);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(958, 75);
            this.menu_panel.TabIndex = 5;
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.lbl_URL);
            this.tool_panel.Controls.Add(this.txt_URL);
            this.tool_panel.Controls.Add(this.richTxt_Result);
            this.tool_panel.Controls.Add(this.btn_GO);
            this.tool_panel.Controls.Add(this.webBrowser);
            this.tool_panel.Location = new System.Drawing.Point(6, 88);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(958, 698);
            this.tool_panel.TabIndex = 6;
            // 
            // CheckWebForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(969, 798);
            this.Controls.Add(this.tool_panel);
            this.Controls.Add(this.menu_panel);
            this.Name = "CheckWebForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckHtml";
            this.Load += new System.EventHandler(this.CheckWebForm_Load);
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label lbl_URL;
        private System.Windows.Forms.Button btn_GO;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.RichTextBox richTxt_Result;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel tool_panel;
    }
}

