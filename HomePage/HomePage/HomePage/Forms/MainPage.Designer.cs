namespace HomePage
{
    partial class MainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.PanelTopBar = new System.Windows.Forms.Panel();
            this.DVValues = new HomePage.CustomControls.DataView();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblSil = new System.Windows.Forms.Label();
            this.lblEkle = new System.Windows.Forms.Label();
            this.PnlMainOperations = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ButtonCompanies = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.ButtonCalendar = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDocuments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DVValues)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlMainOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopBar
            // 
            this.PanelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopBar.Location = new System.Drawing.Point(160, 0);
            this.PanelTopBar.Name = "PanelTopBar";
            this.PanelTopBar.Size = new System.Drawing.Size(864, 18);
            this.PanelTopBar.TabIndex = 2;
            this.PanelTopBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            this.PanelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // DVValues
            // 
            this.DVValues.AllowUserToAddRows = false;
            this.DVValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DVValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DVValues.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DVValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVValues.DefaultCellStyle = dataGridViewCellStyle4;
            this.DVValues.Location = new System.Drawing.Point(166, 117);
            this.DVValues.MultiSelect = false;
            this.DVValues.Name = "DVValues";
            this.DVValues.ReadOnly = true;
            this.DVValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DVValues.Size = new System.Drawing.Size(846, 604);
            this.DVValues.TabIndex = 1;
            // 
            // PanelTop
            // 
            this.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTop.Controls.Add(this.panel1);
            this.PanelTop.Controls.Add(this.lblUpdate);
            this.PanelTop.Controls.Add(this.BtnUpdate);
            this.PanelTop.Controls.Add(this.lblSil);
            this.PanelTop.Controls.Add(this.lblEkle);
            this.PanelTop.Controls.Add(this.btnExit);
            this.PanelTop.Controls.Add(this.BtnDelete);
            this.PanelTop.Controls.Add(this.BtnAdd);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(160, 18);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(864, 91);
            this.PanelTop.TabIndex = 5;
            this.PanelTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TextBoxSearch);
            this.panel1.Location = new System.Drawing.Point(558, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 40);
            this.panel1.TabIndex = 9;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxSearch.Location = new System.Drawing.Point(37, 7);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(251, 27);
            this.TextBoxSearch.TabIndex = 0;
            this.TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblUpdate.Location = new System.Drawing.Point(180, 68);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(65, 18);
            this.lblUpdate.TabIndex = 8;
            this.lblUpdate.Text = "Güncelle";
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblSil.Location = new System.Drawing.Point(113, 70);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(25, 18);
            this.lblSil.TabIndex = 6;
            this.lblSil.Text = "Sil";
            // 
            // lblEkle
            // 
            this.lblEkle.AutoSize = true;
            this.lblEkle.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblEkle.Location = new System.Drawing.Point(26, 70);
            this.lblEkle.Name = "lblEkle";
            this.lblEkle.Size = new System.Drawing.Size(37, 18);
            this.lblEkle.TabIndex = 5;
            this.lblEkle.Text = "Ekle";
            // 
            // PnlMainOperations
            // 
            this.PnlMainOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PnlMainOperations.Controls.Add(this.ButtonCompanies);
            this.PnlMainOperations.Controls.Add(this.btnSettings);
            this.PnlMainOperations.Controls.Add(this.BtnJobs);
            this.PnlMainOperations.Controls.Add(this.ButtonCalendar);
            this.PnlMainOperations.Controls.Add(this.BtnUsers);
            this.PnlMainOperations.Controls.Add(this.pictureBox1);
            this.PnlMainOperations.Controls.Add(this.BtnDocuments);
            this.PnlMainOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.PnlMainOperations.Location = new System.Drawing.Point(0, 0);
            this.PnlMainOperations.Name = "PnlMainOperations";
            this.PnlMainOperations.Size = new System.Drawing.Size(160, 733);
            this.PnlMainOperations.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.Location = new System.Drawing.Point(171, 7);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(78, 60);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(819, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.Location = new System.Drawing.Point(87, 7);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 60);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Location = new System.Drawing.Point(3, 7);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(78, 60);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ButtonCompanies
            // 
            this.ButtonCompanies.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonCompanies.FlatAppearance.BorderSize = 0;
            this.ButtonCompanies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCompanies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.ButtonCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCompanies.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonCompanies.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCompanies.Image = global::HomePage.Properties.Resources.three_buildings;
            this.ButtonCompanies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCompanies.Location = new System.Drawing.Point(4, 197);
            this.ButtonCompanies.Name = "ButtonCompanies";
            this.ButtonCompanies.Size = new System.Drawing.Size(150, 32);
            this.ButtonCompanies.TabIndex = 10;
            this.ButtonCompanies.Text = "Şirketler";
            this.ButtonCompanies.UseVisualStyleBackColor = true;
            this.ButtonCompanies.Click += new System.EventHandler(this.BtnCompanies_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(4, 353);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 32);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // BtnJobs
            // 
            this.BtnJobs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnJobs.FlatAppearance.BorderSize = 0;
            this.BtnJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.BtnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJobs.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnJobs.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnJobs.Image = global::HomePage.Properties.Resources.works;
            this.BtnJobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJobs.Location = new System.Drawing.Point(4, 158);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(150, 32);
            this.BtnJobs.TabIndex = 8;
            this.BtnJobs.Text = "İşler";
            this.BtnJobs.UseVisualStyleBackColor = true;
            this.BtnJobs.Click += new System.EventHandler(this.BtnJobs_Click);
            // 
            // ButtonCalendar
            // 
            this.ButtonCalendar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonCalendar.FlatAppearance.BorderSize = 0;
            this.ButtonCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.ButtonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCalendar.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonCalendar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCalendar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCalendar.Image")));
            this.ButtonCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCalendar.Location = new System.Drawing.Point(4, 314);
            this.ButtonCalendar.Name = "ButtonCalendar";
            this.ButtonCalendar.Size = new System.Drawing.Size(150, 32);
            this.ButtonCalendar.TabIndex = 4;
            this.ButtonCalendar.Text = "Takvim";
            this.ButtonCalendar.UseVisualStyleBackColor = true;
            this.ButtonCalendar.Click += new System.EventHandler(this.ButtonCalendar_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUsers.Image = global::HomePage.Properties.Resources.user;
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.Location = new System.Drawing.Point(4, 275);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(150, 32);
            this.BtnUsers.TabIndex = 3;
            this.BtnUsers.Text = "Kişiler ";
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Visible = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            this.BtnUsers.MouseEnter += new System.EventHandler(this.BtnUsers_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnDocuments
            // 
            this.BtnDocuments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDocuments.FlatAppearance.BorderSize = 0;
            this.BtnDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.BtnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocuments.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDocuments.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDocuments.Image = global::HomePage.Properties.Resources.sidebar_document;
            this.BtnDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDocuments.Location = new System.Drawing.Point(4, 236);
            this.BtnDocuments.Name = "BtnDocuments";
            this.BtnDocuments.Size = new System.Drawing.Size(150, 32);
            this.BtnDocuments.TabIndex = 2;
            this.BtnDocuments.Text = "Evrak";
            this.BtnDocuments.UseVisualStyleBackColor = true;
            this.BtnDocuments.Click += new System.EventHandler(this.BtnDocuments_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 733);
            this.Controls.Add(this.DVValues);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelTopBar);
            this.Controls.Add(this.PnlMainOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.DVValues)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlMainOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopBar;
        private CustomControls.DataView DVValues;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Label lblEkle;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button BtnDocuments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Panel PnlMainOperations;
        private System.Windows.Forms.Button ButtonCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button ButtonCompanies;
    }
}

