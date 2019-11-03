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
            this.itemTypeTxtBox = new System.Windows.Forms.TextBox();
            this.itemTypeLbl = new System.Windows.Forms.Label();
            this.itemPriceTxtBox = new System.Windows.Forms.TextBox();
            this.itemSizeTxtBox = new System.Windows.Forms.TextBox();
            this.itemPriceLbl = new System.Windows.Forms.Label();
            this.itemSizeLbl = new System.Windows.Forms.Label();
            this.clearItemBtn = new System.Windows.Forms.Button();
            this.modifyItemBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectItemLbl = new System.Windows.Forms.Label();
            this.selectItemComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // itemTypeTxtBox
            // 
            this.itemTypeTxtBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeTxtBox.Location = new System.Drawing.Point(326, 356);
            this.itemTypeTxtBox.Name = "itemTypeTxtBox";
            this.itemTypeTxtBox.Size = new System.Drawing.Size(385, 27);
            this.itemTypeTxtBox.TabIndex = 24;
            // 
            // itemTypeLbl
            // 
            this.itemTypeLbl.AutoSize = true;
            this.itemTypeLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLbl.Location = new System.Drawing.Point(30, 359);
            this.itemTypeLbl.Name = "itemTypeLbl";
            this.itemTypeLbl.Size = new System.Drawing.Size(264, 23);
            this.itemTypeLbl.TabIndex = 23;
            this.itemTypeLbl.Text = "Set Item Type:";
            // 
            // itemPriceTxtBox
            // 
            this.itemPriceTxtBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTxtBox.Location = new System.Drawing.Point(326, 480);
            this.itemPriceTxtBox.Name = "itemPriceTxtBox";
            this.itemPriceTxtBox.Size = new System.Drawing.Size(385, 27);
            this.itemPriceTxtBox.TabIndex = 22;
            // 
            // itemSizeTxtBox
            // 
            this.itemSizeTxtBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSizeTxtBox.Location = new System.Drawing.Point(326, 421);
            this.itemSizeTxtBox.Name = "itemSizeTxtBox";
            this.itemSizeTxtBox.Size = new System.Drawing.Size(385, 27);
            this.itemSizeTxtBox.TabIndex = 21;
            // 
            // itemPriceLbl
            // 
            this.itemPriceLbl.AutoSize = true;
            this.itemPriceLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceLbl.Location = new System.Drawing.Point(30, 483);
            this.itemPriceLbl.Name = "itemPriceLbl";
            this.itemPriceLbl.Size = new System.Drawing.Size(277, 23);
            this.itemPriceLbl.TabIndex = 19;
            this.itemPriceLbl.Text = "Set Item Price:";
            // 
            // itemSizeLbl
            // 
            this.itemSizeLbl.AutoSize = true;
            this.itemSizeLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSizeLbl.Location = new System.Drawing.Point(30, 424);
            this.itemSizeLbl.Name = "itemSizeLbl";
            this.itemSizeLbl.Size = new System.Drawing.Size(255, 23);
            this.itemSizeLbl.TabIndex = 20;
            this.itemSizeLbl.Text = "Set Item Size:";
            // 
            // clearItemBtn
            // 
            this.clearItemBtn.BackColor = System.Drawing.Color.Coral;
            this.clearItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearItemBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearItemBtn.Location = new System.Drawing.Point(545, 683);
            this.clearItemBtn.Name = "clearItemBtn";
            this.clearItemBtn.Size = new System.Drawing.Size(147, 91);
            this.clearItemBtn.TabIndex = 28;
            this.clearItemBtn.Text = "Clear All";
            this.clearItemBtn.UseVisualStyleBackColor = false;
            // 
            // modifyItemBtn
            // 
            this.modifyItemBtn.BackColor = System.Drawing.Color.Coral;
            this.modifyItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyItemBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyItemBtn.Location = new System.Drawing.Point(379, 683);
            this.modifyItemBtn.Name = "modifyItemBtn";
            this.modifyItemBtn.Size = new System.Drawing.Size(147, 91);
            this.modifyItemBtn.TabIndex = 27;
            this.modifyItemBtn.Text = "Modify Item";
            this.modifyItemBtn.UseVisualStyleBackColor = false;
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.AllowDrop = true;
            this.deleteItemBtn.BackColor = System.Drawing.Color.Coral;
            this.deleteItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteItemBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemBtn.Location = new System.Drawing.Point(211, 683);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(147, 91);
            this.deleteItemBtn.TabIndex = 26;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = false;
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.Coral;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(42, 683);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(147, 91);
            this.addItemBtn.TabIndex = 25;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.selectItemLbl);
            this.groupBox1.Controls.Add(this.selectItemComboBox);
            this.groupBox1.Controls.Add(this.itemTypeLbl);
            this.groupBox1.Controls.Add(this.clearItemBtn);
            this.groupBox1.Controls.Add(this.itemSizeLbl);
            this.groupBox1.Controls.Add(this.modifyItemBtn);
            this.groupBox1.Controls.Add(this.itemPriceLbl);
            this.groupBox1.Controls.Add(this.deleteItemBtn);
            this.groupBox1.Controls.Add(this.itemSizeTxtBox);
            this.groupBox1.Controls.Add(this.addItemBtn);
            this.groupBox1.Controls.Add(this.itemPriceTxtBox);
            this.groupBox1.Controls.Add(this.itemTypeTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(1039, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 870);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.groupBox2.Location = new System.Drawing.Point(63, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 870);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // selectItemLbl
            // 
            this.selectItemLbl.AutoSize = true;
            this.selectItemLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectItemLbl.Location = new System.Drawing.Point(28, 123);
            this.selectItemLbl.Name = "selectItemLbl";
            this.selectItemLbl.Size = new System.Drawing.Size(321, 23);
            this.selectItemLbl.TabIndex = 20;
            this.selectItemLbl.Text = "Select Item Type:";
            // 
            // selectItemComboBox
            // 
            this.selectItemComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Menu"});
            this.selectItemComboBox.BackColor = System.Drawing.Color.Coral;
            this.selectItemComboBox.DisplayMember = "(none)";
            this.selectItemComboBox.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectItemComboBox.FormattingEnabled = true;
            this.selectItemComboBox.Items.AddRange(new object[] {
            "Cashier",
            "Manager",
            "Administrator"});
            this.selectItemComboBox.Location = new System.Drawing.Point(32, 181);
            this.selectItemComboBox.MaxDropDownItems = 3;
            this.selectItemComboBox.Name = "selectItemComboBox";
            this.selectItemComboBox.Size = new System.Drawing.Size(319, 31);
            this.selectItemComboBox.TabIndex = 19;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1850, 950);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox itemTypeTxtBox;
        private System.Windows.Forms.Label itemTypeLbl;
        private System.Windows.Forms.TextBox itemPriceTxtBox;
        private System.Windows.Forms.TextBox itemSizeTxtBox;
        private System.Windows.Forms.Label itemPriceLbl;
        private System.Windows.Forms.Label itemSizeLbl;
        private System.Windows.Forms.Button clearItemBtn;
        private System.Windows.Forms.Button modifyItemBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label selectItemLbl;
        private System.Windows.Forms.ComboBox selectItemComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}