namespace ICBINJPOSController
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passWordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(83, 218);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(174, 19);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // passWordLabel
            // 
            this.passWordLabel.AutoSize = true;
            this.passWordLabel.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordLabel.Location = new System.Drawing.Point(97, 273);
            this.passWordLabel.Name = "passWordLabel";
            this.passWordLabel.Size = new System.Drawing.Size(160, 19);
            this.passWordLabel.TabIndex = 0;
            this.passWordLabel.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(283, 215);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(224, 22);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(283, 270);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(224, 22);
            this.passWordTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Goudy Stout", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(279, 148);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(222, 19);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Please Log In:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Coral;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Goudy Stout", 8.25F);
            this.loginButton.Location = new System.Drawing.Point(84, 386);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(173, 60);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AllowDrop = true;
            this.clearButton.BackColor = System.Drawing.Color.Coral;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Goudy Stout", 8.25F);
            this.clearButton.Location = new System.Drawing.Point(334, 386);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(173, 60);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 579);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passWordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passWordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button clearButton;
    }
}

