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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.PanelTopBar = new System.Windows.Forms.Panel();
            this.DVValues = new HomePage.CustomControls.DataView();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LayoutPanelGenericButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAdd = new HomePage.CustomControls.GenericButton();
            this.BtnDelete = new HomePage.CustomControls.GenericButton();
            this.BtnUpdate = new HomePage.CustomControls.GenericButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.PnlMainOperations = new System.Windows.Forms.Panel();
            this.LayoutPanelMainButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.BtnDocuments = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.ButtonCalendar = new System.Windows.Forms.Button();
            this.ButtonCompanies = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DVValues)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.LayoutPanelGenericButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlMainOperations.SuspendLayout();
            this.LayoutPanelMainButtons.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DVValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVValues.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.PanelTop.Controls.Add(this.LayoutPanelGenericButtons);
            this.PanelTop.Controls.Add(this.panel1);
            this.PanelTop.Controls.Add(this.btnExit);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(160, 18);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(864, 91);
            this.PanelTop.TabIndex = 5;
            this.PanelTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // LayoutPanelGenericButtons
            // 
            this.LayoutPanelGenericButtons.Controls.Add(this.BtnAdd);
            this.LayoutPanelGenericButtons.Controls.Add(this.BtnDelete);
            this.LayoutPanelGenericButtons.Controls.Add(this.BtnUpdate);
            this.LayoutPanelGenericButtons.Location = new System.Drawing.Point(0, 1);
            this.LayoutPanelGenericButtons.Name = "LayoutPanelGenericButtons";
            this.LayoutPanelGenericButtons.Size = new System.Drawing.Size(411, 87);
            this.LayoutPanelGenericButtons.TabIndex = 10;
            this.LayoutPanelGenericButtons.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.ButtonImage = global::HomePage.Properties.Resources.documentadd;
            this.BtnAdd.ButtonText = "Ekle";
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(80, 82);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.ClickEvent += new System.Action<object, System.EventArgs>(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.ButtonImage = global::HomePage.Properties.Resources.documentdelete;
            this.BtnDelete.ButtonText = "Sil";
            this.BtnDelete.Location = new System.Drawing.Point(89, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(80, 82);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.ClickEvent += new System.Action<object, System.EventArgs>(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ButtonImage = global::HomePage.Properties.Resources.documentupdate;
            this.BtnUpdate.ButtonText = "Güncelle";
            this.BtnUpdate.Location = new System.Drawing.Point(175, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(80, 82);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.ClickEvent += new System.Action<object, System.EventArgs>(this.BtnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TextBoxSearch);
            this.panel1.Location = new System.Drawing.Point(558, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 40);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HomePage.Properties.Resources.magnifier;
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // PnlMainOperations
            // 
            this.PnlMainOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PnlMainOperations.Controls.Add(this.LayoutPanelMainButtons);
            this.PnlMainOperations.Controls.Add(this.pictureBox1);
            this.PnlMainOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.PnlMainOperations.Location = new System.Drawing.Point(0, 0);
            this.PnlMainOperations.Name = "PnlMainOperations";
            this.PnlMainOperations.Size = new System.Drawing.Size(160, 733);
            this.PnlMainOperations.TabIndex = 0;
            // 
            // LayoutPanelMainButtons
            // 
            this.LayoutPanelMainButtons.Controls.Add(this.BtnJobs);
            this.LayoutPanelMainButtons.Controls.Add(this.BtnDocuments);
            this.LayoutPanelMainButtons.Controls.Add(this.BtnUsers);
            this.LayoutPanelMainButtons.Controls.Add(this.ButtonCalendar);
            this.LayoutPanelMainButtons.Controls.Add(this.ButtonCompanies);
            this.LayoutPanelMainButtons.Controls.Add(this.btnSettings);
            this.LayoutPanelMainButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanelMainButtons.Location = new System.Drawing.Point(0, 158);
            this.LayoutPanelMainButtons.Name = "LayoutPanelMainButtons";
            this.LayoutPanelMainButtons.Size = new System.Drawing.Size(157, 572);
            this.LayoutPanelMainButtons.TabIndex = 11;
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
            this.BtnJobs.Location = new System.Drawing.Point(3, 3);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(150, 32);
            this.BtnJobs.TabIndex = 8;
            this.BtnJobs.Text = "İşler";
            this.BtnJobs.UseVisualStyleBackColor = true;
            this.BtnJobs.Click += new System.EventHandler(this.BtnJobs_Click);
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
            this.BtnDocuments.Location = new System.Drawing.Point(3, 41);
            this.BtnDocuments.Name = "BtnDocuments";
            this.BtnDocuments.Size = new System.Drawing.Size(150, 32);
            this.BtnDocuments.TabIndex = 2;
            this.BtnDocuments.Text = "Evrak";
            this.BtnDocuments.UseVisualStyleBackColor = true;
            this.BtnDocuments.Click += new System.EventHandler(this.BtnDocuments_Click);
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
            this.BtnUsers.Location = new System.Drawing.Point(3, 79);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(150, 32);
            this.BtnUsers.TabIndex = 3;
            this.BtnUsers.Text = "Kişiler ";
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Visible = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            this.BtnUsers.MouseEnter += new System.EventHandler(this.BtnUsers_MouseEnter);
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
            this.ButtonCalendar.Location = new System.Drawing.Point(3, 117);
            this.ButtonCalendar.Name = "ButtonCalendar";
            this.ButtonCalendar.Size = new System.Drawing.Size(150, 32);
            this.ButtonCalendar.TabIndex = 4;
            this.ButtonCalendar.Text = "Takvim";
            this.ButtonCalendar.UseVisualStyleBackColor = true;
            this.ButtonCalendar.Click += new System.EventHandler(this.ButtonCalendar_Click);
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
            this.ButtonCompanies.Location = new System.Drawing.Point(3, 155);
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
            this.btnSettings.Location = new System.Drawing.Point(3, 193);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 32);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            this.LayoutPanelGenericButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlMainOperations.ResumeLayout(false);
            this.LayoutPanelMainButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopBar;
        private CustomControls.DataView DVValues;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelTop;
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
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelMainButtons;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelGenericButtons;
        private CustomControls.GenericButton BtnAdd;
        private CustomControls.GenericButton BtnDelete;
        private CustomControls.GenericButton BtnUpdate;
    }
}

