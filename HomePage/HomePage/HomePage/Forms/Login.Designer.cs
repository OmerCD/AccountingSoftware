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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new HomePage.CustomControls.MyTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ServerIPTextBox = new HomePage.CustomControls.MyTextBox();
            this.CbRememberInfo = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.Location = new System.Drawing.Point(25, 284);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 32);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "Şifre";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.UserNameTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.UserNameTextBox.Location = new System.Drawing.Point(25, 246);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PlaceHolder = null;
            this.UserNameTextBox.Size = new System.Drawing.Size(250, 32);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.Text = "Kullanıcı Adı";
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserNameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HomePage.Properties.Resources.F1login1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(52, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 151);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::HomePage.Properties.Resources.power;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(270, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.ServerIPTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ServerIPTextBox.ForeColor = System.Drawing.Color.Silver;
            this.ServerIPTextBox.Location = new System.Drawing.Point(25, 181);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.PlaceHolder = null;
            this.ServerIPTextBox.Size = new System.Drawing.Size(250, 32);
            this.ServerIPTextBox.TabIndex = 0;
            this.ServerIPTextBox.Text = "Sunucu IP";
            this.ServerIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ServerIPTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.ServerIPTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // CbRememberInfo
            // 
            this.CbRememberInfo.AutoSize = true;
            this.CbRememberInfo.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbRememberInfo.ForeColor = System.Drawing.Color.White;
            this.CbRememberInfo.Location = new System.Drawing.Point(25, 322);
            this.CbRememberInfo.Name = "CbRememberInfo";
            this.CbRememberInfo.Size = new System.Drawing.Size(115, 24);
            this.CbRememberInfo.TabIndex = 3;
            this.CbRememberInfo.Text = "Bilgileri Hatırla";
            this.CbRememberInfo.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Titillium Web", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.LoginButton.Location = new System.Drawing.Point(25, 371);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(250, 55);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Giriş Yap";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(300, 452);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CbRememberInfo);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Giriş";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.MyTextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private CustomControls.MyTextBox ServerIPTextBox;
        private System.Windows.Forms.CheckBox CbRememberInfo;
        private System.Windows.Forms.Button LoginButton;
    }
}