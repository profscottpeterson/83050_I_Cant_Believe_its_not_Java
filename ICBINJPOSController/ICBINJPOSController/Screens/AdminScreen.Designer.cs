namespace ICBINJPOSController
{
    partial class AdminScreen
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
            this.priceMaintGrp = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.medPriceLbl = new System.Windows.Forms.Label();
            this.mediumPriceTxt = new System.Windows.Forms.TextBox();
            this.largePriceLbl = new System.Windows.Forms.Label();
            this.largePriceTxt = new System.Windows.Forms.TextBox();
            this.itemLbx = new System.Windows.Forms.ListBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.smallPriceLbl = new System.Windows.Forms.Label();
            this.smallPriceTxt = new System.Windows.Forms.TextBox();
            this.modifyItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.itemDescLbl = new System.Windows.Forms.Label();
            this.clearTextBtn = new System.Windows.Forms.Button();
            this.userMaintGrp = new System.Windows.Forms.GroupBox();
            this.selectUserLbl = new System.Windows.Forms.Label();
            this.setUserLbl = new System.Windows.Forms.Label();
            this.setPasswordLbl = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.userSelectComboBox = new System.Windows.Forms.ComboBox();
            this.modifyUserBtn = new System.Windows.Forms.Button();
            this.setUserIdLbl = new System.Windows.Forms.Label();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.clearUserBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.loginHistBtn = new System.Windows.Forms.Button();
            this.priceMaintGrp.SuspendLayout();
            this.userMaintGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceMaintGrp
            // 
            this.priceMaintGrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceMaintGrp.BackColor = System.Drawing.Color.LightGray;
            this.priceMaintGrp.Controls.Add(this.SaveBtn);
            this.priceMaintGrp.Controls.Add(this.deleteItemBtn);
            this.priceMaintGrp.Controls.Add(this.medPriceLbl);
            this.priceMaintGrp.Controls.Add(this.mediumPriceTxt);
            this.priceMaintGrp.Controls.Add(this.largePriceLbl);
            this.priceMaintGrp.Controls.Add(this.largePriceTxt);
            this.priceMaintGrp.Controls.Add(this.itemLbx);
            this.priceMaintGrp.Controls.Add(this.descLbl);
            this.priceMaintGrp.Controls.Add(this.smallPriceLbl);
            this.priceMaintGrp.Controls.Add(this.smallPriceTxt);
            this.priceMaintGrp.Controls.Add(this.modifyItemBtn);
            this.priceMaintGrp.Controls.Add(this.addItemBtn);
            this.priceMaintGrp.Controls.Add(this.itemDescLbl);
            this.priceMaintGrp.Controls.Add(this.clearTextBtn);
            this.priceMaintGrp.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceMaintGrp.Location = new System.Drawing.Point(748, 67);
            this.priceMaintGrp.Name = "priceMaintGrp";
            this.priceMaintGrp.Size = new System.Drawing.Size(740, 622);
            this.priceMaintGrp.TabIndex = 0;
            this.priceMaintGrp.TabStop = false;
            this.priceMaintGrp.Text = "Price Maintenance";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Coral;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(524, 547);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(165, 57);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.AllowDrop = true;
            this.deleteItemBtn.BackColor = System.Drawing.Color.Coral;
            this.deleteItemBtn.Enabled = false;
            this.deleteItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteItemBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemBtn.Location = new System.Drawing.Point(524, 381);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(165, 57);
            this.deleteItemBtn.TabIndex = 14;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = false;
            // 
            // medPriceLbl
            // 
            this.medPriceLbl.AutoSize = true;
            this.medPriceLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medPriceLbl.Location = new System.Drawing.Point(14, 127);
            this.medPriceLbl.Name = "medPriceLbl";
            this.medPriceLbl.Size = new System.Drawing.Size(114, 19);
            this.medPriceLbl.TabIndex = 0;
            this.medPriceLbl.Text = "Medium Price:";
            // 
            // mediumPriceTxt
            // 
            this.mediumPriceTxt.BackColor = System.Drawing.Color.White;
            this.mediumPriceTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumPriceTxt.Location = new System.Drawing.Point(356, 124);
            this.mediumPriceTxt.Name = "mediumPriceTxt";
            this.mediumPriceTxt.Size = new System.Drawing.Size(276, 27);
            this.mediumPriceTxt.TabIndex = 10;
            // 
            // largePriceLbl
            // 
            this.largePriceLbl.AutoSize = true;
            this.largePriceLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largePriceLbl.Location = new System.Drawing.Point(14, 163);
            this.largePriceLbl.Name = "largePriceLbl";
            this.largePriceLbl.Size = new System.Drawing.Size(94, 19);
            this.largePriceLbl.TabIndex = 0;
            this.largePriceLbl.Text = "Large Price:";
            // 
            // largePriceTxt
            // 
            this.largePriceTxt.BackColor = System.Drawing.Color.White;
            this.largePriceTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largePriceTxt.Location = new System.Drawing.Point(356, 160);
            this.largePriceTxt.Name = "largePriceTxt";
            this.largePriceTxt.Size = new System.Drawing.Size(276, 27);
            this.largePriceTxt.TabIndex = 11;
            // 
            // itemLbx
            // 
            this.itemLbx.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbx.FormattingEnabled = true;
            this.itemLbx.ItemHeight = 19;
            this.itemLbx.Location = new System.Drawing.Point(18, 209);
            this.itemLbx.Name = "itemLbx";
            this.itemLbx.Size = new System.Drawing.Size(466, 384);
            this.itemLbx.TabIndex = 0;
            this.itemLbx.SelectedIndexChanged += new System.EventHandler(this.itemLbx_SelectedIndexChanged);
            // 
            // descLbl
            // 
            this.descLbl.BackColor = System.Drawing.Color.White;
            this.descLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(357, 51);
            this.descLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(276, 28);
            this.descLbl.TabIndex = 0;
            // 
            // smallPriceLbl
            // 
            this.smallPriceLbl.AutoSize = true;
            this.smallPriceLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallPriceLbl.Location = new System.Drawing.Point(14, 92);
            this.smallPriceLbl.Name = "smallPriceLbl";
            this.smallPriceLbl.Size = new System.Drawing.Size(92, 19);
            this.smallPriceLbl.TabIndex = 0;
            this.smallPriceLbl.Text = "Small Price:";
            // 
            // smallPriceTxt
            // 
            this.smallPriceTxt.BackColor = System.Drawing.Color.White;
            this.smallPriceTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallPriceTxt.Location = new System.Drawing.Point(356, 89);
            this.smallPriceTxt.Name = "smallPriceTxt";
            this.smallPriceTxt.Size = new System.Drawing.Size(276, 27);
            this.smallPriceTxt.TabIndex = 9;
            // 
            // modifyItemBtn
            // 
            this.modifyItemBtn.BackColor = System.Drawing.Color.Coral;
            this.modifyItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyItemBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyItemBtn.Location = new System.Drawing.Point(524, 214);
            this.modifyItemBtn.Name = "modifyItemBtn";
            this.modifyItemBtn.Size = new System.Drawing.Size(165, 57);
            this.modifyItemBtn.TabIndex = 12;
            this.modifyItemBtn.Text = "Modify Item";
            this.modifyItemBtn.UseVisualStyleBackColor = false;
            this.modifyItemBtn.Click += new System.EventHandler(this.modifyItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.AllowDrop = true;
            this.addItemBtn.BackColor = System.Drawing.Color.Coral;
            this.addItemBtn.Enabled = false;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(524, 296);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(165, 57);
            this.addItemBtn.TabIndex = 13;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = false;
            // 
            // itemDescLbl
            // 
            this.itemDescLbl.AutoSize = true;
            this.itemDescLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescLbl.Location = new System.Drawing.Point(15, 53);
            this.itemDescLbl.Name = "itemDescLbl";
            this.itemDescLbl.Size = new System.Drawing.Size(136, 19);
            this.itemDescLbl.TabIndex = 0;
            this.itemDescLbl.Text = "Item Description:";
            // 
            // clearTextBtn
            // 
            this.clearTextBtn.BackColor = System.Drawing.Color.Coral;
            this.clearTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearTextBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTextBtn.Location = new System.Drawing.Point(524, 463);
            this.clearTextBtn.Name = "clearTextBtn";
            this.clearTextBtn.Size = new System.Drawing.Size(165, 57);
            this.clearTextBtn.TabIndex = 15;
            this.clearTextBtn.Text = "Clear Text";
            this.clearTextBtn.UseVisualStyleBackColor = false;
            this.clearTextBtn.Click += new System.EventHandler(this.clearTextBtn_Click);
            // 
            // userMaintGrp
            // 
            this.userMaintGrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userMaintGrp.BackColor = System.Drawing.Color.LightGray;
            this.userMaintGrp.Controls.Add(this.selectUserLbl);
            this.userMaintGrp.Controls.Add(this.setUserLbl);
            this.userMaintGrp.Controls.Add(this.setPasswordLbl);
            this.userMaintGrp.Controls.Add(this.userNameTxt);
            this.userMaintGrp.Controls.Add(this.passwordTxt);
            this.userMaintGrp.Controls.Add(this.addUserBtn);
            this.userMaintGrp.Controls.Add(this.deleteUserBtn);
            this.userMaintGrp.Controls.Add(this.userSelectComboBox);
            this.userMaintGrp.Controls.Add(this.modifyUserBtn);
            this.userMaintGrp.Controls.Add(this.setUserIdLbl);
            this.userMaintGrp.Controls.Add(this.userIdTxt);
            this.userMaintGrp.Controls.Add(this.clearUserBtn);
            this.userMaintGrp.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMaintGrp.Location = new System.Drawing.Point(12, 67);
            this.userMaintGrp.Name = "userMaintGrp";
            this.userMaintGrp.Size = new System.Drawing.Size(715, 622);
            this.userMaintGrp.TabIndex = 0;
            this.userMaintGrp.TabStop = false;
            this.userMaintGrp.Text = "User Maintenance";
            // 
            // selectUserLbl
            // 
            this.selectUserLbl.AutoSize = true;
            this.selectUserLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectUserLbl.Location = new System.Drawing.Point(34, 123);
            this.selectUserLbl.Name = "selectUserLbl";
            this.selectUserLbl.Size = new System.Drawing.Size(131, 19);
            this.selectUserLbl.TabIndex = 0;
            this.selectUserLbl.Text = "Select User Type";
            // 
            // setUserLbl
            // 
            this.setUserLbl.AutoSize = true;
            this.setUserLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUserLbl.Location = new System.Drawing.Point(34, 313);
            this.setUserLbl.Name = "setUserLbl";
            this.setUserLbl.Size = new System.Drawing.Size(121, 19);
            this.setUserLbl.TabIndex = 0;
            this.setUserLbl.Text = "Set User Name:";
            // 
            // setPasswordLbl
            // 
            this.setPasswordLbl.AutoSize = true;
            this.setPasswordLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordLbl.Location = new System.Drawing.Point(34, 372);
            this.setPasswordLbl.Name = "setPasswordLbl";
            this.setPasswordLbl.Size = new System.Drawing.Size(110, 19);
            this.setPasswordLbl.TabIndex = 0;
            this.setPasswordLbl.Text = "Set Password:";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(312, 310);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(385, 27);
            this.userNameTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(312, 369);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(385, 27);
            this.passwordTxt.TabIndex = 4;
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.Coral;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Location = new System.Drawing.Point(38, 446);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(147, 91);
            this.addUserBtn.TabIndex = 5;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.AllowDrop = true;
            this.deleteUserBtn.BackColor = System.Drawing.Color.Coral;
            this.deleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.Location = new System.Drawing.Point(210, 446);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(147, 91);
            this.deleteUserBtn.TabIndex = 6;
            this.deleteUserBtn.Text = "Delete User";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // userSelectComboBox
            // 
            this.userSelectComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Cashier",
            "Manager",
            "Administrator"});
            this.userSelectComboBox.BackColor = System.Drawing.Color.Coral;
            this.userSelectComboBox.DisplayMember = "(none)";
            this.userSelectComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSelectComboBox.FormattingEnabled = true;
            this.userSelectComboBox.Items.AddRange(new object[] {
            "Cashier",
            "Manager",
            "Administrator"});
            this.userSelectComboBox.Location = new System.Drawing.Point(113, 163);
            this.userSelectComboBox.MaxDropDownItems = 3;
            this.userSelectComboBox.Name = "userSelectComboBox";
            this.userSelectComboBox.Size = new System.Drawing.Size(319, 27);
            this.userSelectComboBox.TabIndex = 1;
            // 
            // modifyUserBtn
            // 
            this.modifyUserBtn.BackColor = System.Drawing.Color.Coral;
            this.modifyUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyUserBtn.Location = new System.Drawing.Point(379, 446);
            this.modifyUserBtn.Name = "modifyUserBtn";
            this.modifyUserBtn.Size = new System.Drawing.Size(147, 91);
            this.modifyUserBtn.TabIndex = 7;
            this.modifyUserBtn.Text = "Modify User";
            this.modifyUserBtn.UseVisualStyleBackColor = false;
            this.modifyUserBtn.Click += new System.EventHandler(this.modifyUserBtn_Click);
            // 
            // setUserIdLbl
            // 
            this.setUserIdLbl.AutoSize = true;
            this.setUserIdLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUserIdLbl.Location = new System.Drawing.Point(34, 248);
            this.setUserIdLbl.Name = "setUserIdLbl";
            this.setUserIdLbl.Size = new System.Drawing.Size(95, 19);
            this.setUserIdLbl.TabIndex = 0;
            this.setUserIdLbl.Text = "Set User ID:";
            // 
            // userIdTxt
            // 
            this.userIdTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTxt.Location = new System.Drawing.Point(312, 245);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(385, 27);
            this.userIdTxt.TabIndex = 2;
            // 
            // clearUserBtn
            // 
            this.clearUserBtn.BackColor = System.Drawing.Color.Coral;
            this.clearUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearUserBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearUserBtn.Location = new System.Drawing.Point(550, 446);
            this.clearUserBtn.Name = "clearUserBtn";
            this.clearUserBtn.Size = new System.Drawing.Size(147, 91);
            this.clearUserBtn.TabIndex = 8;
            this.clearUserBtn.Text = "Clear All";
            this.clearUserBtn.UseVisualStyleBackColor = false;
            this.clearUserBtn.Click += new System.EventHandler(this.clearUserBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.BackColor = System.Drawing.Color.Red;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(99, 695);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(147, 91);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // signOutBtn
            // 
            this.signOutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signOutBtn.BackColor = System.Drawing.Color.Snow;
            this.signOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signOutBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutBtn.Location = new System.Drawing.Point(271, 695);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(147, 91);
            this.signOutBtn.TabIndex = 18;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = false;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // loginHistBtn
            // 
            this.loginHistBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginHistBtn.BackColor = System.Drawing.Color.Snow;
            this.loginHistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginHistBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHistBtn.Location = new System.Drawing.Point(444, 695);
            this.loginHistBtn.Name = "loginHistBtn";
            this.loginHistBtn.Size = new System.Drawing.Size(210, 91);
            this.loginHistBtn.TabIndex = 19;
            this.loginHistBtn.Text = "Login History";
            this.loginHistBtn.UseVisualStyleBackColor = false;
            this.loginHistBtn.Click += new System.EventHandler(this.loginHistBtn_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.loginHistBtn);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.priceMaintGrp);
            this.Controls.Add(this.userMaintGrp);
            this.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.priceMaintGrp.ResumeLayout(false);
            this.priceMaintGrp.PerformLayout();
            this.userMaintGrp.ResumeLayout(false);
            this.userMaintGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox priceMaintGrp;
        private System.Windows.Forms.ListBox itemLbx;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label smallPriceLbl;
        private System.Windows.Forms.TextBox smallPriceTxt;
        private System.Windows.Forms.Button modifyItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label itemDescLbl;
        private System.Windows.Forms.Button clearTextBtn;
        private System.Windows.Forms.GroupBox userMaintGrp;
        private System.Windows.Forms.Label selectUserLbl;
        private System.Windows.Forms.Label setUserLbl;
        private System.Windows.Forms.Label setPasswordLbl;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.ComboBox userSelectComboBox;
        private System.Windows.Forms.Button modifyUserBtn;
        private System.Windows.Forms.Label setUserIdLbl;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.Button clearUserBtn;
        private System.Windows.Forms.Label medPriceLbl;
        private System.Windows.Forms.TextBox mediumPriceTxt;
        private System.Windows.Forms.Label largePriceLbl;
        private System.Windows.Forms.TextBox largePriceTxt;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button loginHistBtn;
    }
}