namespace HomePage
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DVValues = new HomePage.CustomControls.DataView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblSil = new System.Windows.Forms.Label();
            this.lblEkle = new System.Windows.Forms.Label();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.PnlMainOperations = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDocuments = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.BtnCompanies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DVValues)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            this.PnlMainOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(114, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 18);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // DVValues
            // 
            this.DVValues.AllowUserToAddRows = false;
            this.DVValues.AllowUserToDeleteRows = false;
            this.DVValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DVValues.BackgroundColor = System.Drawing.Color.DarkGray;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVValues.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVValues.Location = new System.Drawing.Point(0, 0);
            this.DVValues.MultiSelect = false;
            this.DVValues.Name = "DVValues";
            this.DVValues.ReadOnly = true;
            this.DVValues.Size = new System.Drawing.Size(735, 450);
            this.DVValues.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUpdate);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.lblSil);
            this.panel1.Controls.Add(this.lblEkle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(114, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 91);
            this.panel1.TabIndex = 5;
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
            // pnlDataGrid
            // 
            this.pnlDataGrid.Controls.Add(this.DVValues);
            this.pnlDataGrid.Location = new System.Drawing.Point(118, 116);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(735, 450);
            this.pnlDataGrid.TabIndex = 6;
            // 
            // PnlMainOperations
            // 
            this.PnlMainOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PnlMainOperations.Controls.Add(this.button1);
            this.PnlMainOperations.Controls.Add(this.pictureBox1);
            this.PnlMainOperations.Controls.Add(this.BtnDocuments);
            this.PnlMainOperations.Controls.Add(this.BtnJobs);
            this.PnlMainOperations.Controls.Add(this.BtnCompanies);
            this.PnlMainOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainOperations.Font = new System.Drawing.Font("Adobe Gurmukhi", 13.25F);
            this.PnlMainOperations.Location = new System.Drawing.Point(0, 0);
            this.PnlMainOperations.Name = "PnlMainOperations";
            this.PnlMainOperations.Size = new System.Drawing.Size(114, 733);
            this.PnlMainOperations.TabIndex = 0;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImage = global::HomePage.Properties.Resources.documentupdate;
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.Location = new System.Drawing.Point(171, 7);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(78, 60);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = global::HomePage.Properties.Resources._002_power_4;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(863, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::HomePage.Properties.Resources.documentdelete;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.Location = new System.Drawing.Point(87, 7);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 60);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = global::HomePage.Properties.Resources.documentadd;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Location = new System.Drawing.Point(3, 7);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(78, 60);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackgroundImage = global::HomePage.Properties.Resources._004_settings_3;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Location = new System.Drawing.Point(822, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(35, 37);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::HomePage.Properties.Resources.users2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kişiler";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::HomePage.Properties.Resources.F1transparentHeader;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 109);
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
            this.BtnDocuments.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.BtnDocuments.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDocuments.Image = global::HomePage.Properties.Resources.contract11;
            this.BtnDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDocuments.Location = new System.Drawing.Point(3, 179);
            this.BtnDocuments.Name = "BtnDocuments";
            this.BtnDocuments.Size = new System.Drawing.Size(109, 30);
            this.BtnDocuments.TabIndex = 1;
            this.BtnDocuments.Text = "Evrak";
            this.BtnDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDocuments.UseVisualStyleBackColor = true;
            this.BtnDocuments.Click += new System.EventHandler(this.BtnDocuments_Click);
            // 
            // BtnJobs
            // 
            this.BtnJobs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnJobs.FlatAppearance.BorderSize = 0;
            this.BtnJobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnJobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.BtnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJobs.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.BtnJobs.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnJobs.Image = global::HomePage.Properties.Resources.calculator11;
            this.BtnJobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJobs.Location = new System.Drawing.Point(3, 148);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(109, 30);
            this.BtnJobs.TabIndex = 0;
            this.BtnJobs.Text = "              İşler";
            this.BtnJobs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJobs.UseVisualStyleBackColor = true;
            this.BtnJobs.Click += new System.EventHandler(this.BtnJobs_Click);
            // 
            // BtnCompanies
            // 
            this.BtnCompanies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCompanies.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCompanies.FlatAppearance.BorderSize = 0;
            this.BtnCompanies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCompanies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.BtnCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompanies.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompanies.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCompanies.Image = global::HomePage.Properties.Resources.houses111;
            this.BtnCompanies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompanies.Location = new System.Drawing.Point(3, 117);
            this.BtnCompanies.Name = "BtnCompanies";
            this.BtnCompanies.Size = new System.Drawing.Size(109, 30);
            this.BtnCompanies.TabIndex = 0;
            this.BtnCompanies.Text = "  Firmalar";
            this.BtnCompanies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCompanies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompanies.UseVisualStyleBackColor = true;
            this.BtnCompanies.Click += new System.EventHandler(this.BtnCompanies_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 733);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlMainOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.DVValues)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            this.PnlMainOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        MetroFramework.Controls.MetroContextMenu menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.DataView DVValues;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.Label lblEkle;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button BtnCompanies;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Button BtnDocuments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PnlMainOperations;
    }
}

