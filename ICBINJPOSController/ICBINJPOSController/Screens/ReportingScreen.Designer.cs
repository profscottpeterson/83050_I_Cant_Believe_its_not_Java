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
            this.userShowReportBtn = new System.Windows.Forms.Button();
            this.userLbx = new System.Windows.Forms.ListBox();
            this.showDailyReportBtn = new System.Windows.Forms.Button();
            this.cuLabel = new System.Windows.Forms.Label();
            this.uttLabel = new System.Windows.Forms.Label();
            this.utcsLabel = new System.Windows.Forms.Label();
            this.utcrsLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.userTotalTaxLabel = new System.Windows.Forms.Label();
            this.userTotalCashSalesLabel = new System.Windows.Forms.Label();
            this.userTotalCreditSalesLabel = new System.Windows.Forms.Label();
            this.dttLabel = new System.Windows.Forms.Label();
            this.dailyTotalTaxLabel = new System.Windows.Forms.Label();
            this.dtcsLabel = new System.Windows.Forms.Label();
            this.dailyTotalCashSalesLabel = new System.Windows.Forms.Label();
            this.dailyTotalCreditSalesLabel = new System.Windows.Forms.Label();
            this.dtcrsLabel = new System.Windows.Forms.Label();
            this.rtnotLabel = new System.Windows.Forms.Label();
            this.userTotalNumOfTransLabel = new System.Windows.Forms.Label();
            this.dtnotLabel = new System.Windows.Forms.Label();
            this.dailyTotalNumOfTransLabel = new System.Windows.Forms.Label();
            this.printUserReportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDailyReport = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userShowReportBtn
            // 
            this.userShowReportBtn.Location = new System.Drawing.Point(90, 231);
            this.userShowReportBtn.Name = "userShowReportBtn";
            this.userShowReportBtn.Size = new System.Drawing.Size(191, 42);
            this.userShowReportBtn.TabIndex = 0;
            this.userShowReportBtn.Text = "Show User Report";
            this.userShowReportBtn.UseVisualStyleBackColor = true;
            this.userShowReportBtn.Click += new System.EventHandler(this.userShowReportBtn_Click);
            // 
            // userLbx
            // 
            this.userLbx.FormattingEnabled = true;
            this.userLbx.Location = new System.Drawing.Point(68, 55);
            this.userLbx.Name = "userLbx";
            this.userLbx.Size = new System.Drawing.Size(232, 147);
            this.userLbx.TabIndex = 1;
            // 
            // showDailyReportBtn
            // 
            this.showDailyReportBtn.Location = new System.Drawing.Point(605, 231);
            this.showDailyReportBtn.Name = "showDailyReportBtn";
            this.showDailyReportBtn.Size = new System.Drawing.Size(243, 42);
            this.showDailyReportBtn.TabIndex = 0;
            this.showDailyReportBtn.Text = "Show Daily Report";
            this.showDailyReportBtn.UseVisualStyleBackColor = true;
            this.showDailyReportBtn.Click += new System.EventHandler(this.dailyShowReportBtn_Click);
            // 
            // cuLabel
            // 
            this.cuLabel.AutoSize = true;
            this.cuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuLabel.Location = new System.Drawing.Point(179, 308);
            this.cuLabel.Name = "cuLabel";
            this.cuLabel.Size = new System.Drawing.Size(121, 24);
            this.cuLabel.TabIndex = 2;
            this.cuLabel.Text = "Current User:";
            // 
            // uttLabel
            // 
            this.uttLabel.AutoSize = true;
            this.uttLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uttLabel.Location = new System.Drawing.Point(207, 418);
            this.uttLabel.Name = "uttLabel";
            this.uttLabel.Size = new System.Drawing.Size(93, 24);
            this.uttLabel.TabIndex = 2;
            this.uttLabel.Text = "Total Tax:";
            // 
            // utcsLabel
            // 
            this.utcsLabel.AutoSize = true;
            this.utcsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utcsLabel.Location = new System.Drawing.Point(145, 478);
            this.utcsLabel.Name = "utcsLabel";
            this.utcsLabel.Size = new System.Drawing.Size(155, 24);
            this.utcsLabel.TabIndex = 2;
            this.utcsLabel.Text = "Total Cash Sales:";
            // 
            // utcrsLabel
            // 
            this.utcrsLabel.AutoSize = true;
            this.utcrsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utcrsLabel.Location = new System.Drawing.Point(139, 534);
            this.utcrsLabel.Name = "utcrsLabel";
            this.utcrsLabel.Size = new System.Drawing.Size(161, 24);
            this.utcrsLabel.TabIndex = 2;
            this.utcrsLabel.Text = "Total Credit Sales:";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(319, 308);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(25, 24);
            this.currentUserLabel.TabIndex = 2;
            this.currentUserLabel.Text = "   ";
            // 
            // userTotalTaxLabel
            // 
            this.userTotalTaxLabel.AutoSize = true;
            this.userTotalTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTotalTaxLabel.Location = new System.Drawing.Point(319, 418);
            this.userTotalTaxLabel.Name = "userTotalTaxLabel";
            this.userTotalTaxLabel.Size = new System.Drawing.Size(25, 24);
            this.userTotalTaxLabel.TabIndex = 2;
            this.userTotalTaxLabel.Text = "   ";
            // 
            // userTotalCashSalesLabel
            // 
            this.userTotalCashSalesLabel.AutoSize = true;
            this.userTotalCashSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTotalCashSalesLabel.Location = new System.Drawing.Point(319, 478);
            this.userTotalCashSalesLabel.Name = "userTotalCashSalesLabel";
            this.userTotalCashSalesLabel.Size = new System.Drawing.Size(25, 24);
            this.userTotalCashSalesLabel.TabIndex = 2;
            this.userTotalCashSalesLabel.Text = "   ";
            // 
            // userTotalCreditSalesLabel
            // 
            this.userTotalCreditSalesLabel.AutoSize = true;
            this.userTotalCreditSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTotalCreditSalesLabel.Location = new System.Drawing.Point(319, 534);
            this.userTotalCreditSalesLabel.Name = "userTotalCreditSalesLabel";
            this.userTotalCreditSalesLabel.Size = new System.Drawing.Size(25, 24);
            this.userTotalCreditSalesLabel.TabIndex = 2;
            this.userTotalCreditSalesLabel.Text = "   ";
            // 
            // dttLabel
            // 
            this.dttLabel.AutoSize = true;
            this.dttLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttLabel.Location = new System.Drawing.Point(722, 418);
            this.dttLabel.Name = "dttLabel";
            this.dttLabel.Size = new System.Drawing.Size(93, 24);
            this.dttLabel.TabIndex = 2;
            this.dttLabel.Text = "Total Tax:";
            // 
            // dailyTotalTaxLabel
            // 
            this.dailyTotalTaxLabel.AutoSize = true;
            this.dailyTotalTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyTotalTaxLabel.Location = new System.Drawing.Point(834, 418);
            this.dailyTotalTaxLabel.Name = "dailyTotalTaxLabel";
            this.dailyTotalTaxLabel.Size = new System.Drawing.Size(25, 24);
            this.dailyTotalTaxLabel.TabIndex = 2;
            this.dailyTotalTaxLabel.Text = "   ";
            // 
            // dtcsLabel
            // 
            this.dtcsLabel.AutoSize = true;
            this.dtcsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcsLabel.Location = new System.Drawing.Point(660, 478);
            this.dtcsLabel.Name = "dtcsLabel";
            this.dtcsLabel.Size = new System.Drawing.Size(155, 24);
            this.dtcsLabel.TabIndex = 2;
            this.dtcsLabel.Text = "Total Cash Sales:";
            // 
            // dailyTotalCashSalesLabel
            // 
            this.dailyTotalCashSalesLabel.AutoSize = true;
            this.dailyTotalCashSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyTotalCashSalesLabel.Location = new System.Drawing.Point(834, 478);
            this.dailyTotalCashSalesLabel.Name = "dailyTotalCashSalesLabel";
            this.dailyTotalCashSalesLabel.Size = new System.Drawing.Size(25, 24);
            this.dailyTotalCashSalesLabel.TabIndex = 2;
            this.dailyTotalCashSalesLabel.Text = "   ";
            // 
            // dailyTotalCreditSalesLabel
            // 
            this.dailyTotalCreditSalesLabel.AutoSize = true;
            this.dailyTotalCreditSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyTotalCreditSalesLabel.Location = new System.Drawing.Point(834, 534);
            this.dailyTotalCreditSalesLabel.Name = "dailyTotalCreditSalesLabel";
            this.dailyTotalCreditSalesLabel.Size = new System.Drawing.Size(25, 24);
            this.dailyTotalCreditSalesLabel.TabIndex = 2;
            this.dailyTotalCreditSalesLabel.Text = "   ";
            // 
            // dtcrsLabel
            // 
            this.dtcrsLabel.AutoSize = true;
            this.dtcrsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcrsLabel.Location = new System.Drawing.Point(654, 534);
            this.dtcrsLabel.Name = "dtcrsLabel";
            this.dtcrsLabel.Size = new System.Drawing.Size(161, 24);
            this.dtcrsLabel.TabIndex = 2;
            this.dtcrsLabel.Text = "Total Credit Sales:";
            // 
            // rtnotLabel
            // 
            this.rtnotLabel.AutoSize = true;
            this.rtnotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtnotLabel.Location = new System.Drawing.Point(34, 362);
            this.rtnotLabel.Name = "rtnotLabel";
            this.rtnotLabel.Size = new System.Drawing.Size(266, 24);
            this.rtnotLabel.TabIndex = 2;
            this.rtnotLabel.Text = "Total Number Of Transactions:";
            // 
            // userTotalNumOfTransLabel
            // 
            this.userTotalNumOfTransLabel.AutoSize = true;
            this.userTotalNumOfTransLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTotalNumOfTransLabel.Location = new System.Drawing.Point(319, 362);
            this.userTotalNumOfTransLabel.Name = "userTotalNumOfTransLabel";
            this.userTotalNumOfTransLabel.Size = new System.Drawing.Size(25, 24);
            this.userTotalNumOfTransLabel.TabIndex = 2;
            this.userTotalNumOfTransLabel.Text = "   ";
            // 
            // dtnotLabel
            // 
            this.dtnotLabel.AutoSize = true;
            this.dtnotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtnotLabel.Location = new System.Drawing.Point(549, 359);
            this.dtnotLabel.Name = "dtnotLabel";
            this.dtnotLabel.Size = new System.Drawing.Size(266, 24);
            this.dtnotLabel.TabIndex = 2;
            this.dtnotLabel.Text = "Total Number Of Transactions:";
            // 
            // dailyTotalNumOfTransLabel
            // 
            this.dailyTotalNumOfTransLabel.AutoSize = true;
            this.dailyTotalNumOfTransLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyTotalNumOfTransLabel.Location = new System.Drawing.Point(834, 359);
            this.dailyTotalNumOfTransLabel.Name = "dailyTotalNumOfTransLabel";
            this.dailyTotalNumOfTransLabel.Size = new System.Drawing.Size(25, 24);
            this.dailyTotalNumOfTransLabel.TabIndex = 2;
            this.dailyTotalNumOfTransLabel.Text = "   ";
            // 
            // printUserReportBtn
            // 
            this.printUserReportBtn.Location = new System.Drawing.Point(68, 630);
            this.printUserReportBtn.Name = "printUserReportBtn";
            this.printUserReportBtn.Size = new System.Drawing.Size(243, 42);
            this.printUserReportBtn.TabIndex = 4;
            this.printUserReportBtn.Text = "Print User Report";
            this.printUserReportBtn.UseVisualStyleBackColor = true;
            this.printUserReportBtn.Click += new System.EventHandler(this.printUserReportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a user\'s report:";
            // 
            // printDailyReport
            // 
            this.printDailyReport.Location = new System.Drawing.Point(605, 630);
            this.printDailyReport.Name = "printDailyReport";
            this.printDailyReport.Size = new System.Drawing.Size(243, 42);
            this.printDailyReport.TabIndex = 6;
            this.printDailyReport.Text = "Print Daily Report";
            this.printDailyReport.UseVisualStyleBackColor = true;
            this.printDailyReport.Click += new System.EventHandler(this.printDailyReport_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(375, 778);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(150, 56);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(413, 700);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ReportingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.printDailyReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printUserReportBtn);
            this.Controls.Add(this.dtcrsLabel);
            this.Controls.Add(this.dailyTotalCreditSalesLabel);
            this.Controls.Add(this.utcrsLabel);
            this.Controls.Add(this.dailyTotalCashSalesLabel);
            this.Controls.Add(this.userTotalCreditSalesLabel);
            this.Controls.Add(this.dtcsLabel);
            this.Controls.Add(this.dailyTotalNumOfTransLabel);
            this.Controls.Add(this.userTotalNumOfTransLabel);
            this.Controls.Add(this.userTotalCashSalesLabel);
            this.Controls.Add(this.dailyTotalTaxLabel);
            this.Controls.Add(this.dtnotLabel);
            this.Controls.Add(this.rtnotLabel);
            this.Controls.Add(this.utcsLabel);
            this.Controls.Add(this.dttLabel);
            this.Controls.Add(this.userTotalTaxLabel);
            this.Controls.Add(this.uttLabel);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.cuLabel);
            this.Controls.Add(this.userLbx);
            this.Controls.Add(this.showDailyReportBtn);
            this.Controls.Add(this.userShowReportBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "ReportingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManagementScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userShowReportBtn;
        private System.Windows.Forms.ListBox userLbx;
        private System.Windows.Forms.Button showDailyReportBtn;
        private System.Windows.Forms.Label cuLabel;
        private System.Windows.Forms.Label uttLabel;
        private System.Windows.Forms.Label utcsLabel;
        private System.Windows.Forms.Label utcrsLabel;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label userTotalTaxLabel;
        private System.Windows.Forms.Label userTotalCashSalesLabel;
        private System.Windows.Forms.Label userTotalCreditSalesLabel;
        private System.Windows.Forms.Label dttLabel;
        private System.Windows.Forms.Label dailyTotalTaxLabel;
        private System.Windows.Forms.Label dtcsLabel;
        private System.Windows.Forms.Label dailyTotalCashSalesLabel;
        private System.Windows.Forms.Label dailyTotalCreditSalesLabel;
        private System.Windows.Forms.Label dtcrsLabel;
        private System.Windows.Forms.Label rtnotLabel;
        private System.Windows.Forms.Label userTotalNumOfTransLabel;
        private System.Windows.Forms.Label dtnotLabel;
        private System.Windows.Forms.Label dailyTotalNumOfTransLabel;
        private System.Windows.Forms.Button printUserReportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printDailyReport;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}