using System.Windows.Forms;

namespace MergeTools
{
    partial class MongoForm
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
            this.panel_Btn = new System.Windows.Forms.Panel();
            this.richTxt_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Btn
            // 
            this.panel_Btn.AutoScroll = true;
            this.panel_Btn.AutoSize = true;
            this.panel_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Btn.Location = new System.Drawing.Point(3, 3);
            this.panel_Btn.Name = "panel_Btn";
            this.panel_Btn.Size = new System.Drawing.Size(0, 0);
            this.panel_Btn.TabIndex = 0;
            // 
            // richTxt_Output
            // 
            this.richTxt_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTxt_Output.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTxt_Output.ForeColor = System.Drawing.Color.YellowGreen;
            this.richTxt_Output.Location = new System.Drawing.Point(-2, -2);
            this.richTxt_Output.Name = "richTxt_Output";
            this.richTxt_Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTxt_Output.Size = new System.Drawing.Size(416, 259);
            this.richTxt_Output.TabIndex = 0;
            this.richTxt_Output.Text = "";
            this.richTxt_Output.WordWrap = false;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Copy.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Copy.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)), true);
            this.btn_Copy.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Copy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Copy.Location = new System.Drawing.Point(382, 274);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(60, 31);
            this.btn_Copy.TabIndex = 1;
            this.btn_Copy.Text = "複製";
            this.btn_Copy.UseVisualStyleBackColor = false;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Name.Location = new System.Drawing.Point(3, 47);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(68, 17);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Mongo JS";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.btn_Copy);
            this.panel1.Controls.Add(this.panel_Btn);
            this.panel1.Controls.Add(this.richTxt_Output);
            this.panel1.Location = new System.Drawing.Point(4, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 400);
            this.panel1.TabIndex = 3;
            // 
            // menu_panel
            // 
            this.menu_panel.Location = new System.Drawing.Point(5, 4);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(572, 60);
            this.menu_panel.TabIndex = 3;
            // 
            // MongoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(599, 485);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.panel1);
            this.Name = "MongoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mongo查詢語法";
            this.Load += new System.EventHandler(this.MongoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Btn;
        private System.Windows.Forms.RichTextBox richTxt_Output;
        private Button btn_Copy;
        private Label lbl_Name;
        private Panel panel1;
        private Panel menu_panel;
    }
}

