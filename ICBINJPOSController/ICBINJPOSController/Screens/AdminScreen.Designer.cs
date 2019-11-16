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
            this.userSelectComboBox = new System.Windows.Forms.ComboBox();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.setPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.setUserTxtBox = new System.Windows.Forms.TextBox();
            this.setPasswordLbl = new System.Windows.Forms.Label();
            this.setUserLbl = new System.Windows.Forms.Label();
            this.selectUserLbl = new System.Windows.Forms.Label();
            this.modifyUserBtn = new System.Windows.Forms.Button();
            this.setUserIdLbl = new System.Windows.Forms.Label();
            this.setUserIdTxtBox = new System.Windows.Forms.TextBox();
            this.clearUserBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceMaintGbx = new System.Windows.Forms.GroupBox();
            this.showItemsBtn = new System.Windows.Forms.Button();
            this.itemLbx = new System.Windows.Forms.ListBox();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.itemPriceLbl = new System.Windows.Forms.Label();
            this.itemSizeLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.modifyItemBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.itemDescLbl = new System.Windows.Forms.Label();
            this.clearItemBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.priceMaintGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSelectComboBox
            // 
            this.userSelectComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Cashier",
            "Manager",
            "Administrator"});
            this.userSelectComboBox.BackColor = System.Drawing.Color.Coral;
            this.userSelectComboBox.DisplayMember = "(none)";
            this.userSelectComboBox.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSelectComboBox.FormattingEnabled = true;
            this.userSelectComboBox.Items.AddRange(new object[] {
            "Cashier",
            "Manager",
            "Administrator"});
            this.userSelectComboBox.Location = new System.Drawing.Point(38, 181);
            this.userSelectComboBox.MaxDropDownItems = 3;
            this.userSelectComboBox.Name = "userSelectComboBox";
            this.userSelectComboBox.Size = new System.Drawing.Size(319, 31);
            this.userSelectComboBox.TabIndex = 9;
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.AllowDrop = true;
            this.deleteUserBtn.BackColor = System.Drawing.Color.Coral;
            this.deleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUserBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.Location = new System.Drawing.Point(210, 683);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(147, 91);
            this.deleteUserBtn.TabIndex = 13;
            this.deleteUserBtn.Text = "Delete User";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.Coral;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUserBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Location = new System.Drawing.Point(38, 683);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(147, 91);
            this.addUserBtn.TabIndex = 12;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            // 
            // setPasswordTxtBox
            // 
            this.setPasswordTxtBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordTxtBox.Location = new System.Drawing.Point(312, 480);
            this.setPasswordTxtBox.Name = "setPasswordTxtBox";
            this.setPasswordTxtBox.Size = new System.Drawing.Size(385, 27);
            this.setPasswordTxtBox.TabIndex = 11;
            // 
            // setUserTxtBox
            // 
            this.setUserTxtBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUserTxtBox.Location = new System.Drawing.Point(312, 421);
            this.setUserTxtBox.Name = "setUserTxtBox";
            this.setUserTxtBox.Size = new System.Drawing.Size(385, 27);
            this.setUserTxtBox.TabIndex = 10;
            // 
            // setPasswordLbl
            // 
            this.setPasswordLbl.AutoSize = true;
            this.setPasswordLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordLbl.Location = new System.Drawing.Point(34, 483);
            this.setPasswordLbl.Name = "setPasswordLbl";
            this.setPasswordLbl.Size = new System.Drawing.Size(249, 23);
            this.setPasswordLbl.TabIndex = 7;
            this.setPasswordLbl.Text = "Set Password:";
            // 
            // setUserLbl
            // 
            this.setUserLbl.AutoSize = true;
            this.setUserLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUserLbl.Location = new System.Drawing.Point(34, 424);
            this.setUserLbl.Name = "setUserLbl";
            this.setUserLbl.Size = new System.Drawing.Size(165, 23);
            this.setUserLbl.TabIndex = 8;
            this.setUserLbl.Text = "Set User:";
            // 
            // selectUserLbl
            // 
            this.selectUserLbl.AutoSize = true;
            this.selectUserLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectUserLbl.Location = new System.Drawing.Point(34, 123);
            this.selectUserLbl.Name = "selectUserLbl";
            this.selectUserLbl.Size = new System.Drawing.Size(314, 23);
            this.selectUserLbl.TabIndex = 14;
            this.selectUserLbl.Text = "Select User Type:";
            // 
            // modifyUserBtn
            // 
            this.modifyUserBtn.BackColor = System.Drawing.Color.Coral;
            this.modifyUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyUserBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyUserBtn.Location = new System.Drawing.Point(379, 683);
            this.modifyUserBtn.Name = "modifyUserBtn";
            this.modifyUserBtn.Size = new System.Drawing.Size(147, 91);
            this.modifyUserBtn.TabIndex = 15;
            this.modifyUserBtn.Text = "Modify User";
            this.modifyUserBtn.UseVisualStyleBackColor = false;
            // 
            // setUserIdLbl
            // 
            this.setUserIdLbl.AutoSize = true;
            this.setUserIdLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUserIdLbl.Location = new System.Drawing.Point(34, 359);
            this.setUserIdLbl.Name = "setUserIdLbl";
            this.setUserIdLbl.Size = new System.Drawing.Size(210, 23);
            this.setUserIdLbl.TabIndex = 16;
            this.setUserIdLbl.Text = "Set User ID:";
            // 
            // setUserIdTxtBox
            // 
            this.setUserIdTxtBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setUserIdTxtBox.Location = new System.Drawing.Point(312, 356);
            this.setUserIdTxtBox.Name = "setUserIdTxtBox";
            this.setUserIdTxtBox.Size = new System.Drawing.Size(385, 27);
            this.setUserIdTxtBox.TabIndex = 17;
            // 
            // clearUserBtn
            // 
            this.clearUserBtn.BackColor = System.Drawing.Color.Coral;
            this.clearUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearUserBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearUserBtn.Location = new System.Drawing.Point(550, 683);
            this.clearUserBtn.Name = "clearUserBtn";
            this.clearUserBtn.Size = new System.Drawing.Size(147, 91);
            this.clearUserBtn.TabIndex = 18;
            this.clearUserBtn.Text = "Clear All";
            this.clearUserBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.selectUserLbl);
            this.groupBox2.Controls.Add(this.setUserLbl);
            this.groupBox2.Controls.Add(this.setPasswordLbl);
            this.groupBox2.Controls.Add(this.setUserTxtBox);
            this.groupBox2.Controls.Add(this.setPasswordTxtBox);
            this.groupBox2.Controls.Add(this.addUserBtn);
            this.groupBox2.Controls.Add(this.deleteUserBtn);
            this.groupBox2.Controls.Add(this.userSelectComboBox);
            this.groupBox2.Controls.Add(this.modifyUserBtn);
            this.groupBox2.Controls.Add(this.setUserIdLbl);
            this.groupBox2.Controls.Add(this.setUserIdTxtBox);
            this.groupBox2.Controls.Add(this.clearUserBtn);
            this.groupBox2.Location = new System.Drawing.Point(23, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1061, 1075);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // priceMaintGbx
            // 
            this.priceMaintGbx.BackColor = System.Drawing.Color.LightGray;
            this.priceMaintGbx.Controls.Add(this.showItemsBtn);
            this.priceMaintGbx.Controls.Add(this.itemLbx);
            this.priceMaintGbx.Controls.Add(this.sizeLbl);
            this.priceMaintGbx.Controls.Add(this.descLbl);
            this.priceMaintGbx.Controls.Add(this.itemPriceLbl);
            this.priceMaintGbx.Controls.Add(this.itemSizeLbl);
            this.priceMaintGbx.Controls.Add(this.priceTxt);
            this.priceMaintGbx.Controls.Add(this.modifyItemBtn);
            this.priceMaintGbx.Controls.Add(this.deleteItemBtn);
            this.priceMaintGbx.Controls.Add(this.itemDescLbl);
            this.priceMaintGbx.Controls.Add(this.clearItemBtn);
            this.priceMaintGbx.Location = new System.Drawing.Point(1131, 25);
            this.priceMaintGbx.Name = "priceMaintGbx";
            this.priceMaintGbx.Size = new System.Drawing.Size(1135, 1075);
            this.priceMaintGbx.TabIndex = 31;
            this.priceMaintGbx.TabStop = false;
            this.priceMaintGbx.Text = "Price Maintenance";
            // 
            // showItemsBtn
            // 
            this.showItemsBtn.BackColor = System.Drawing.Color.Coral;
            this.showItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showItemsBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showItemsBtn.Location = new System.Drawing.Point(791, 24);
            this.showItemsBtn.Name = "showItemsBtn";
            this.showItemsBtn.Size = new System.Drawing.Size(147, 91);
            this.showItemsBtn.TabIndex = 102;
            this.showItemsBtn.Text = "Show Items";
            this.showItemsBtn.UseVisualStyleBackColor = false;
            this.showItemsBtn.Click += new System.EventHandler(this.showItemsBtn_Click);
            // 
            // itemLbx
            // 
            this.itemLbx.FormattingEnabled = true;
            this.itemLbx.ItemHeight = 18;
            this.itemLbx.Location = new System.Drawing.Point(36, 248);
            this.itemLbx.Name = "itemLbx";
            this.itemLbx.Size = new System.Drawing.Size(686, 580);
            this.itemLbx.TabIndex = 101;
            this.itemLbx.SelectedIndexChanged += new System.EventHandler(this.itemLbx_SelectedIndexChanged);
            // 
            // sizeLbl
            // 
            this.sizeLbl.BackColor = System.Drawing.Color.White;
            this.sizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLbl.Location = new System.Drawing.Point(379, 179);
            this.sizeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(208, 28);
            this.sizeLbl.TabIndex = 100;
            // 
            // descLbl
            // 
            this.descLbl.BackColor = System.Drawing.Color.White;
            this.descLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(379, 65);
            this.descLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(208, 28);
            this.descLbl.TabIndex = 99;
            // 
            // itemPriceLbl
            // 
            this.itemPriceLbl.AutoSize = true;
            this.itemPriceLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceLbl.Location = new System.Drawing.Point(147, 123);
            this.itemPriceLbl.Name = "itemPriceLbl";
            this.itemPriceLbl.Size = new System.Drawing.Size(210, 23);
            this.itemPriceLbl.TabIndex = 8;
            this.itemPriceLbl.Text = "Item Price:";
            // 
            // itemSizeLbl
            // 
            this.itemSizeLbl.AutoSize = true;
            this.itemSizeLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSizeLbl.Location = new System.Drawing.Point(169, 181);
            this.itemSizeLbl.Name = "itemSizeLbl";
            this.itemSizeLbl.Size = new System.Drawing.Size(188, 23);
            this.itemSizeLbl.TabIndex = 7;
            this.itemSizeLbl.Text = "Item Size:";
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.Color.White;
            this.priceTxt.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(379, 120);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(208, 27);
            this.priceTxt.TabIndex = 10;
            // 
            // modifyItemBtn
            // 
            this.modifyItemBtn.BackColor = System.Drawing.Color.Coral;
            this.modifyItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyItemBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyItemBtn.Location = new System.Drawing.Point(791, 264);
            this.modifyItemBtn.Name = "modifyItemBtn";
            this.modifyItemBtn.Size = new System.Drawing.Size(147, 91);
            this.modifyItemBtn.TabIndex = 12;
            this.modifyItemBtn.Text = "Modify Item";
            this.modifyItemBtn.UseVisualStyleBackColor = false;
            this.modifyItemBtn.Click += new System.EventHandler(this.modifyItemBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.AllowDrop = true;
            this.deleteItemBtn.BackColor = System.Drawing.Color.Coral;
            this.deleteItemBtn.Enabled = false;
            this.deleteItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteItemBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemBtn.Location = new System.Drawing.Point(791, 415);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(147, 91);
            this.deleteItemBtn.TabIndex = 13;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = false;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // itemDescLbl
            // 
            this.itemDescLbl.AutoSize = true;
            this.itemDescLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescLbl.Location = new System.Drawing.Point(32, 67);
            this.itemDescLbl.Name = "itemDescLbl";
            this.itemDescLbl.Size = new System.Drawing.Size(325, 23);
            this.itemDescLbl.TabIndex = 16;
            this.itemDescLbl.Text = "Item Description:";
            // 
            // clearItemBtn
            // 
            this.clearItemBtn.BackColor = System.Drawing.Color.Coral;
            this.clearItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearItemBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearItemBtn.Location = new System.Drawing.Point(791, 566);
            this.clearItemBtn.Name = "clearItemBtn";
            this.clearItemBtn.Size = new System.Drawing.Size(147, 91);
            this.clearItemBtn.TabIndex = 18;
            this.clearItemBtn.Text = "Clear All";
            this.clearItemBtn.UseVisualStyleBackColor = false;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2300, 1125);
            this.Controls.Add(this.priceMaintGbx);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.priceMaintGbx.ResumeLayout(false);
            this.priceMaintGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox userSelectComboBox;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.TextBox setPasswordTxtBox;
        private System.Windows.Forms.TextBox setUserTxtBox;
        private System.Windows.Forms.Label setPasswordLbl;
        private System.Windows.Forms.Label setUserLbl;
        private System.Windows.Forms.Label selectUserLbl;
        private System.Windows.Forms.Button modifyUserBtn;
        private System.Windows.Forms.Label setUserIdLbl;
        private System.Windows.Forms.TextBox setUserIdTxtBox;
        private System.Windows.Forms.Button clearUserBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox priceMaintGbx;
        private System.Windows.Forms.Label itemPriceLbl;
        private System.Windows.Forms.Label itemSizeLbl;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Button modifyItemBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Label itemDescLbl;
        private System.Windows.Forms.Button clearItemBtn;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.ListBox itemLbx;
        private System.Windows.Forms.Button showItemsBtn;
    }
}