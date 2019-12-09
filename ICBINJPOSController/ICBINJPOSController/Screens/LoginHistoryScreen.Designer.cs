namespace ICBINJPOSController
{
    partial class LoginHistoryScreen
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
            this.loginHistLbx = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearHistBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginHistLbx
            // 
            this.loginHistLbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginHistLbx.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHistLbx.FormattingEnabled = true;
            this.loginHistLbx.ItemHeight = 19;
            this.loginHistLbx.Location = new System.Drawing.Point(17, 18);
            this.loginHistLbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginHistLbx.Name = "loginHistLbx";
            this.loginHistLbx.Size = new System.Drawing.Size(1100, 612);
            this.loginHistLbx.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Red;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(17, 648);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(188, 74);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clearHistBtn
            // 
            this.clearHistBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearHistBtn.BackColor = System.Drawing.Color.White;
            this.clearHistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearHistBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearHistBtn.Location = new System.Drawing.Point(237, 648);
            this.clearHistBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearHistBtn.Name = "clearHistBtn";
            this.clearHistBtn.Size = new System.Drawing.Size(188, 74);
            this.clearHistBtn.TabIndex = 2;
            this.clearHistBtn.Text = "Clear History";
            this.clearHistBtn.UseVisualStyleBackColor = false;
            this.clearHistBtn.Click += new System.EventHandler(this.clearHistBtn_Click);
            // 
            // LoginHistoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1125, 731);
            this.Controls.Add(this.clearHistBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.loginHistLbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginHistoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginHistoryScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginHistoryScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox loginHistLbx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearHistBtn;
    }
}