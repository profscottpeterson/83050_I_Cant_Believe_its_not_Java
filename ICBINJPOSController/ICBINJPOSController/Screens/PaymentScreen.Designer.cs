namespace ICBINJPOSController
{
    partial class PaymentScreen
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTendered = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblChangeSwitch = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn20Dollars = new System.Windows.Forms.Button();
            this.btn10Dollars = new System.Windows.Forms.Button();
            this.btn5Dollars = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDecPt = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.qty2Btn = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblStillDue = new System.Windows.Forms.Label();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(226, 579);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 57);
            this.btnClose.TabIndex = 98;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(45, 579);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 57);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 24);
            this.label7.TabIndex = 96;
            this.label7.Text = "Please enter amount then select payment type.";
            // 
            // lblTendered
            // 
            this.lblTendered.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendered.Location = new System.Drawing.Point(183, 134);
            this.lblTendered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTendered.Name = "lblTendered";
            this.lblTendered.Size = new System.Drawing.Size(112, 32);
            this.lblTendered.TabIndex = 95;
            this.lblTendered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDue
            // 
            this.lblDue.BackColor = System.Drawing.Color.Transparent;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(183, 175);
            this.lblDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(112, 32);
            this.lblDue.TabIndex = 94;
            this.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDue.UseMnemonic = false;
            // 
            // lblChangeSwitch
            // 
            this.lblChangeSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeSwitch.Location = new System.Drawing.Point(37, 175);
            this.lblChangeSwitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeSwitch.Name = "lblChangeSwitch";
            this.lblChangeSwitch.Size = new System.Drawing.Size(138, 32);
            this.lblChangeSwitch.TabIndex = 93;
            this.lblChangeSwitch.Text = "Change Due:";
            this.lblChangeSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(185, 49);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 32);
            this.lblTotal.TabIndex = 92;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 91;
            this.label2.Text = "Amount Tendered:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTot
            // 
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(39, 49);
            this.lblTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(138, 32);
            this.lblTot.TabIndex = 90;
            this.lblTot.Text = "Transaction Total:";
            this.lblTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCredit
            // 
            this.btnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.Location = new System.Drawing.Point(393, 321);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(142, 57);
            this.btnCredit.TabIndex = 89;
            this.btnCredit.Text = "Credit";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(393, 241);
            this.btnCash.Margin = new System.Windows.Forms.Padding(4);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(142, 57);
            this.btnCash.TabIndex = 88;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(292, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 75);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn20Dollars
            // 
            this.btn20Dollars.BackColor = System.Drawing.Color.White;
            this.btn20Dollars.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn20Dollars.FlatAppearance.BorderSize = 2;
            this.btn20Dollars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn20Dollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20Dollars.Location = new System.Drawing.Point(292, 392);
            this.btn20Dollars.Name = "btn20Dollars";
            this.btn20Dollars.Size = new System.Drawing.Size(76, 75);
            this.btn20Dollars.TabIndex = 86;
            this.btn20Dollars.Text = "$20";
            this.btn20Dollars.UseVisualStyleBackColor = false;
            this.btn20Dollars.Click += new System.EventHandler(this.btn20Dollars_Click);
            // 
            // btn10Dollars
            // 
            this.btn10Dollars.BackColor = System.Drawing.Color.White;
            this.btn10Dollars.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn10Dollars.FlatAppearance.BorderSize = 2;
            this.btn10Dollars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10Dollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10Dollars.Location = new System.Drawing.Point(292, 312);
            this.btn10Dollars.Name = "btn10Dollars";
            this.btn10Dollars.Size = new System.Drawing.Size(76, 75);
            this.btn10Dollars.TabIndex = 85;
            this.btn10Dollars.Text = "$10";
            this.btn10Dollars.UseVisualStyleBackColor = false;
            this.btn10Dollars.Click += new System.EventHandler(this.btn10Dollars_Click);
            // 
            // btn5Dollars
            // 
            this.btn5Dollars.BackColor = System.Drawing.Color.White;
            this.btn5Dollars.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5Dollars.FlatAppearance.BorderSize = 2;
            this.btn5Dollars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5Dollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Dollars.Location = new System.Drawing.Point(292, 231);
            this.btn5Dollars.Name = "btn5Dollars";
            this.btn5Dollars.Size = new System.Drawing.Size(76, 75);
            this.btn5Dollars.TabIndex = 84;
            this.btn5Dollars.Text = "$5";
            this.btn5Dollars.UseVisualStyleBackColor = false;
            this.btn5Dollars.Click += new System.EventHandler(this.btn5Dollars_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(45, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 75);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.FlatAppearance.BorderSize = 2;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(128, 472);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(76, 75);
            this.btn0.TabIndex = 82;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(128, 231);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(76, 75);
            this.btn2.TabIndex = 81;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnDecPt
            // 
            this.btnDecPt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDecPt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDecPt.FlatAppearance.BorderSize = 2;
            this.btnDecPt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecPt.Location = new System.Drawing.Point(210, 472);
            this.btnDecPt.Name = "btnDecPt";
            this.btnDecPt.Size = new System.Drawing.Size(76, 75);
            this.btnDecPt.TabIndex = 80;
            this.btnDecPt.Text = ".";
            this.btnDecPt.UseVisualStyleBackColor = false;
            this.btnDecPt.Click += new System.EventHandler(this.btnDecPt_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.FlatAppearance.BorderSize = 2;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(210, 392);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(76, 75);
            this.btn9.TabIndex = 79;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.FlatAppearance.BorderSize = 2;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(128, 392);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(76, 75);
            this.btn8.TabIndex = 78;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(128, 312);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(76, 75);
            this.btn5.TabIndex = 77;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(210, 312);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(76, 75);
            this.btn6.TabIndex = 76;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.FlatAppearance.BorderSize = 2;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(45, 392);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(76, 75);
            this.btn7.TabIndex = 75;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // qty2Btn
            // 
            this.qty2Btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qty2Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.qty2Btn.FlatAppearance.BorderSize = 2;
            this.qty2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.qty2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty2Btn.Location = new System.Drawing.Point(531, -89);
            this.qty2Btn.Name = "qty2Btn";
            this.qty2Btn.Size = new System.Drawing.Size(76, 75);
            this.qty2Btn.TabIndex = 74;
            this.qty2Btn.Text = "2";
            this.qty2Btn.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(210, 231);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(76, 75);
            this.btn3.TabIndex = 73;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(45, 312);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(76, 75);
            this.btn4.TabIndex = 72;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(45, 231);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(76, 75);
            this.btn1.TabIndex = 71;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblStillDue
            // 
            this.lblStillDue.AutoSize = true;
            this.lblStillDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStillDue.ForeColor = System.Drawing.Color.Red;
            this.lblStillDue.Location = new System.Drawing.Point(305, 99);
            this.lblStillDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStillDue.Name = "lblStillDue";
            this.lblStillDue.Size = new System.Drawing.Size(78, 24);
            this.lblStillDue.TabIndex = 99;
            this.lblStillDue.Text = "Still Due";
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.BackColor = System.Drawing.Color.Transparent;
            this.lblBalanceDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDue.Location = new System.Drawing.Point(185, 92);
            this.lblBalanceDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(112, 32);
            this.lblBalanceDue.TabIndex = 101;
            this.lblBalanceDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBalanceDue.UseMnemonic = false;
            // 
            // lblBal
            // 
            this.lblBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.Location = new System.Drawing.Point(39, 92);
            this.lblBal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(138, 32);
            this.lblBal.TabIndex = 100;
            this.lblBal.Text = "Balance Due:";
            this.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayments
            // 
            this.lblPayments.BackColor = System.Drawing.SystemColors.Info;
            this.lblPayments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayments.Location = new System.Drawing.Point(405, 80);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(130, 127);
            this.lblPayments.TabIndex = 102;
            this.lblPayments.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 103;
            this.label1.Text = "Payments Made:";
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.lblBalanceDue);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.lblStillDue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTendered);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lblChangeSwitch);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn20Dollars);
            this.Controls.Add(this.btn10Dollars);
            this.Controls.Add(this.btn5Dollars);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnDecPt);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.qty2Btn);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentScreen";
            this.Text = "PaymentScreen";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTendered;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblChangeSwitch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn20Dollars;
        private System.Windows.Forms.Button btn10Dollars;
        private System.Windows.Forms.Button btn5Dollars;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnDecPt;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button qty2Btn;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblStillDue;
        private System.Windows.Forms.Label lblBalanceDue;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label label1;
    }
}