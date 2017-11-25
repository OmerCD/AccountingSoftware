namespace HomePage.Forms
{
    partial class Login
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ForgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.UserNameTextBox = new HomePage.CustomControls.MyTextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(83, 185);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(113, 51);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Giriş";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.Location = new System.Drawing.Point(23, 116);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(246, 32);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "Şifre";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(188, 151);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.ForgotPasswordLabel.TabIndex = 0;
            this.ForgotPasswordLabel.TabStop = true;
            this.ForgotPasswordLabel.Text = "Şifremi Unuttum";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.UserNameTextBox.Location = new System.Drawing.Point(23, 78);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PlaceHolder = null;
            this.UserNameTextBox.Size = new System.Drawing.Size(246, 32);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.Text = "Kullanıcı Adı";
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 330);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "Login";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.MyTextBox UserNameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.LinkLabel ForgotPasswordLabel;
    }
}