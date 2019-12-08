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
            this.modifyUserLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyUserLbl.Location = new System.Drawing.Point(37, 40);
            this.modifyUserLbl.Name = "modifyUserLbl";
            this.modifyUserLbl.Size = new System.Drawing.Size(836, 23);
            this.modifyUserLbl.TabIndex = 0;
            this.modifyUserLbl.Text = "Please Enter new Username  and / or Password!";
            // 
            // newPassLbl
            // 
            this.newPassLbl.AutoSize = true;
            this.newPassLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLbl.Location = new System.Drawing.Point(125, 186);
            this.newPassLbl.Name = "newPassLbl";
            this.newPassLbl.Size = new System.Drawing.Size(260, 23);
            this.newPassLbl.TabIndex = 0;
            this.newPassLbl.Text = "New Password:";
            // 
            // newNameLbl
            // 
            this.newNameLbl.AutoSize = true;
            this.newNameLbl.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameLbl.Location = new System.Drawing.Point(109, 125);
            this.newNameLbl.Name = "newNameLbl";
            this.newNameLbl.Size = new System.Drawing.Size(267, 23);
            this.newNameLbl.TabIndex = 0;
            this.newNameLbl.Text = "New UserName:";
            // 
            // newUserTxt
            // 
            this.newUserTxt.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserTxt.Location = new System.Drawing.Point(405, 122);
            this.newUserTxt.Name = "newUserTxt";
            this.newUserTxt.Size = new System.Drawing.Size(385, 27);
            this.newUserTxt.TabIndex = 1;
            // 
            // newPassTxt
            // 
            this.newPassTxt.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTxt.Location = new System.Drawing.Point(405, 183);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.Size = new System.Drawing.Size(385, 27);
            this.newPassTxt.TabIndex = 2;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.BackColor = System.Drawing.Color.Coral;
            this.saveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveChangesBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesBtn.Location = new System.Drawing.Point(185, 273);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(225, 91);
            this.saveChangesBtn.TabIndex = 3;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = false;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // cancelChangesBtn
            // 
            this.cancelChangesBtn.BackColor = System.Drawing.Color.Coral;
            this.cancelChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelChangesBtn.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelChangesBtn.Location = new System.Drawing.Point(511, 273);
            this.cancelChangesBtn.Name = "cancelChangesBtn";
            this.cancelChangesBtn.Size = new System.Drawing.Size(225, 91);
            this.cancelChangesBtn.TabIndex = 4;
            this.cancelChangesBtn.Text = "Cancel";
            this.cancelChangesBtn.UseVisualStyleBackColor = false;
            this.cancelChangesBtn.Click += new System.EventHandler(this.cancelChangesBtn_Click);
            // 
            // ModifyUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1060, 413);
            this.Controls.Add(this.cancelChangesBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.newPassTxt);
            this.Controls.Add(this.newUserTxt);
            this.Controls.Add(this.newNameLbl);
            this.Controls.Add(this.newPassLbl);
            this.Controls.Add(this.modifyUserLbl);
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