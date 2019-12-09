namespace ICBINJPOSController
{
    partial class CreditProcessing
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
            this.labelCardNum = new System.Windows.Forms.Label();
            this.tbxEnterCardNum = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCardNum
            // 
            this.labelCardNum.AutoSize = true;
            this.labelCardNum.BackColor = System.Drawing.SystemColors.Menu;
            this.labelCardNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCardNum.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNum.Location = new System.Drawing.Point(130, 128);
            this.labelCardNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCardNum.Name = "labelCardNum";
            this.labelCardNum.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.labelCardNum.Size = new System.Drawing.Size(157, 24);
            this.labelCardNum.TabIndex = 0;
            this.labelCardNum.Text = "Enter Card Number:";
            // 
            // tbxEnterCardNum
            // 
            this.tbxEnterCardNum.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxEnterCardNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEnterCardNum.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEnterCardNum.Location = new System.Drawing.Point(308, 126);
            this.tbxEnterCardNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEnterCardNum.Name = "tbxEnterCardNum";
            this.tbxEnterCardNum.Size = new System.Drawing.Size(148, 27);
            this.tbxEnterCardNum.TabIndex = 1;
            this.tbxEnterCardNum.TextChanged += new System.EventHandler(this.tbxEnterCardNum_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(145, 201);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(142, 57);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(306, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 57);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(265, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 75);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Menu;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.FlatAppearance.BorderSize = 2;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(182, 273);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(76, 75);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Menu;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(265, 354);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(76, 75);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Menu;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.FlatAppearance.BorderSize = 2;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(347, 515);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(76, 75);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Menu;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.FlatAppearance.BorderSize = 2;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(265, 515);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(76, 75);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Menu;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(265, 435);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(76, 75);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Menu;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(347, 435);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(76, 75);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Menu;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.FlatAppearance.BorderSize = 2;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(182, 515);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(76, 75);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Menu;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(347, 354);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(76, 75);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Menu;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(182, 435);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(76, 75);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Menu;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(182, 354);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(76, 75);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.BackColor = System.Drawing.SystemColors.Menu;
            this.lblExpiration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExpiration.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiration.Location = new System.Drawing.Point(155, 164);
            this.lblExpiration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.lblExpiration.Size = new System.Drawing.Size(132, 24);
            this.lblExpiration.TabIndex = 0;
            this.lblExpiration.Text = "Enter Expiration:";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCharge.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharge.Location = new System.Drawing.Point(308, 93);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Padding = new System.Windows.Forms.Padding(2);
            this.lblTotalCharge.Size = new System.Drawing.Size(100, 24);
            this.lblTotalCharge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Charged:";
            // 
            // tbxYear
            // 
            this.tbxYear.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxYear.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxYear.Location = new System.Drawing.Point(373, 161);
            this.tbxYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbxYear.MaxLength = 2;
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(35, 27);
            this.tbxYear.TabIndex = 3;
            // 
            // tbxMonth
            // 
            this.tbxMonth.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMonth.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMonth.Location = new System.Drawing.Point(308, 161);
            this.tbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMonth.MaxLength = 2;
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(35, 27);
            this.tbxMonth.TabIndex = 2;
            this.tbxMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMonth.TextChanged += new System.EventHandler(this.tbxMonth_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(340, 161);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 27);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "/20";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(140, 38);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(308, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please enter the credit card information:";
            // 
            // CreditProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(619, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.labelCardNum);
            this.Controls.Add(this.tbxEnterCardNum);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxMonth);
            this.Controls.Add(this.textBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreditProcessing";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Credit Card Processing";
            this.Load += new System.EventHandler(this.CreditProcessing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCardNum;
        private System.Windows.Forms.TextBox tbxEnterCardNum;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}