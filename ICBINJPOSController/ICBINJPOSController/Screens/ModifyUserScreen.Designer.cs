namespace ICBINJPOSController
{
    partial class ModifyUserScreen
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
            this.modifyUserLbl = new System.Windows.Forms.Label();
            this.newPassLbl = new System.Windows.Forms.Label();
            this.newNameLbl = new System.Windows.Forms.Label();
            this.newUserTxt = new System.Windows.Forms.TextBox();
            this.newPassTxt = new System.Windows.Forms.TextBox();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.cancelChangesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyUserLbl
            // 
            this.modifyUserLbl.AutoSize = true;
            this.modifyUserLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyUserLbl.Location = new System.Drawing.Point(247, 48);
            this.modifyUserLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyUserLbl.Name = "modifyUserLbl";
            this.modifyUserLbl.Size = new System.Drawing.Size(354, 19);
            this.modifyUserLbl.TabIndex = 0;
            this.modifyUserLbl.Text = "Please Enter new Username  and / or Password!";
            // 
            // newPassLbl
            // 
            this.newPassLbl.AutoSize = true;
            this.newPassLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLbl.Location = new System.Drawing.Point(193, 160);
            this.newPassLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPassLbl.Name = "newPassLbl";
            this.newPassLbl.Size = new System.Drawing.Size(119, 19);
            this.newPassLbl.TabIndex = 0;
            this.newPassLbl.Text = "New Password:";
            // 
            // newNameLbl
            // 
            this.newNameLbl.AutoSize = true;
            this.newNameLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameLbl.Location = new System.Drawing.Point(186, 110);
            this.newNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newNameLbl.Name = "newNameLbl";
            this.newNameLbl.Size = new System.Drawing.Size(126, 19);
            this.newNameLbl.TabIndex = 0;
            this.newNameLbl.Text = "New UserName:";
            // 
            // newUserTxt
            // 
            this.newUserTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserTxt.Location = new System.Drawing.Point(338, 107);
            this.newUserTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newUserTxt.Name = "newUserTxt";
            this.newUserTxt.Size = new System.Drawing.Size(290, 27);
            this.newUserTxt.TabIndex = 1;
            // 
            // newPassTxt
            // 
            this.newPassTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTxt.Location = new System.Drawing.Point(338, 157);
            this.newPassTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.Size = new System.Drawing.Size(290, 27);
            this.newPassTxt.TabIndex = 2;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.BackColor = System.Drawing.Color.Coral;
            this.saveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveChangesBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesBtn.Location = new System.Drawing.Point(224, 256);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(169, 74);
            this.saveChangesBtn.TabIndex = 3;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = false;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // cancelChangesBtn
            // 
            this.cancelChangesBtn.BackColor = System.Drawing.Color.Coral;
            this.cancelChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelChangesBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelChangesBtn.Location = new System.Drawing.Point(432, 256);
            this.cancelChangesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelChangesBtn.Name = "cancelChangesBtn";
            this.cancelChangesBtn.Size = new System.Drawing.Size(169, 74);
            this.cancelChangesBtn.TabIndex = 4;
            this.cancelChangesBtn.Text = "Cancel";
            this.cancelChangesBtn.UseVisualStyleBackColor = false;
            this.cancelChangesBtn.Click += new System.EventHandler(this.cancelChangesBtn_Click);
            // 
            // ModifyUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(795, 358);
            this.Controls.Add(this.cancelChangesBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.newPassTxt);
            this.Controls.Add(this.newUserTxt);
            this.Controls.Add(this.newNameLbl);
            this.Controls.Add(this.newPassLbl);
            this.Controls.Add(this.modifyUserLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyUserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyUserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyUserLbl;
        private System.Windows.Forms.Label newPassLbl;
        private System.Windows.Forms.Label newNameLbl;
        private System.Windows.Forms.TextBox newUserTxt;
        private System.Windows.Forms.TextBox newPassTxt;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button cancelChangesBtn;
    }
}