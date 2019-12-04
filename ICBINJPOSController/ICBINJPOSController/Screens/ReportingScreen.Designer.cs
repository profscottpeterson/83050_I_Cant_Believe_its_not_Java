namespace ICBINJPOSController
{
    partial class ReportingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingScreen));
            this.userReportBtn = new System.Windows.Forms.Button();
            this.userLbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // userReportBtn
            // 
            this.userReportBtn.Location = new System.Drawing.Point(33, 217);
            this.userReportBtn.Name = "userReportBtn";
            this.userReportBtn.Size = new System.Drawing.Size(243, 42);
            this.userReportBtn.TabIndex = 0;
            this.userReportBtn.Text = "Run User Report";
            this.userReportBtn.UseVisualStyleBackColor = true;
            this.userReportBtn.Click += new System.EventHandler(this.userReportBtn_Click);
            // 
            // userLbx
            // 
            this.userLbx.FormattingEnabled = true;
            this.userLbx.Location = new System.Drawing.Point(33, 79);
            this.userLbx.Name = "userLbx";
            this.userLbx.Size = new System.Drawing.Size(120, 95);
            this.userLbx.TabIndex = 1;
            // 
            // ReportingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.userLbx);
            this.Controls.Add(this.userReportBtn);
            this.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "ReportingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManagementScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportingScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userReportBtn;
        private System.Windows.Forms.ListBox userLbx;
    }
}