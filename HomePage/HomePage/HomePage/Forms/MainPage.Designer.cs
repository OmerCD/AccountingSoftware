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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCompanies = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.PnlMainOperations = new System.Windows.Forms.Panel();
            this.BtnDocuments = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DVValues = new HomePage.CustomControls.DataView();
            this.PnlMainOperations.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVValues)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCompanies
            // 
            this.BtnCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompanies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCompanies.Location = new System.Drawing.Point(3, 15);
            this.BtnCompanies.Name = "BtnCompanies";
            this.BtnCompanies.Size = new System.Drawing.Size(130, 50);
            this.BtnCompanies.TabIndex = 0;
            this.BtnCompanies.Text = "Firmalar";
            this.BtnCompanies.UseVisualStyleBackColor = true;
            this.BtnCompanies.Click += new System.EventHandler(this.BtnCompanies_Click);
            // 
            // BtnJobs
            // 
            this.BtnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJobs.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnJobs.Location = new System.Drawing.Point(3, 71);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(130, 50);
            this.BtnJobs.TabIndex = 0;
            this.BtnJobs.Text = "İşler";
            this.BtnJobs.UseVisualStyleBackColor = true;
            this.BtnJobs.Click += new System.EventHandler(this.BtnJobs_Click);
            // 
            // PnlMainOperations
            // 
            this.PnlMainOperations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlMainOperations.Controls.Add(this.BtnDocuments);
            this.PnlMainOperations.Controls.Add(this.BtnJobs);
            this.PnlMainOperations.Controls.Add(this.BtnCompanies);
            this.PnlMainOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainOperations.Location = new System.Drawing.Point(0, 0);
            this.PnlMainOperations.Name = "PnlMainOperations";
            this.PnlMainOperations.Size = new System.Drawing.Size(137, 733);
            this.PnlMainOperations.TabIndex = 0;
            // 
            // BtnDocuments
            // 
            this.BtnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocuments.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDocuments.Location = new System.Drawing.Point(3, 127);
            this.BtnDocuments.Name = "BtnDocuments";
            this.BtnDocuments.Size = new System.Drawing.Size(130, 50);
            this.BtnDocuments.TabIndex = 1;
            this.BtnDocuments.Text = "Evrak";
            this.BtnDocuments.UseVisualStyleBackColor = true;
            this.BtnDocuments.Click += new System.EventHandler(this.BtnDocuments_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Location = new System.Drawing.Point(166, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 65);
            this.panel2.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(92, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(82, 58);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Veri Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(4, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(82, 58);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Yeni Veri Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DVValues
            // 
            this.DVValues.AllowUserToAddRows = false;
            this.DVValues.AllowUserToDeleteRows = false;
            this.DVValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DVValues.BackgroundColor = System.Drawing.Color.Black;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVValues.DefaultCellStyle = dataGridViewCellStyle4;
            this.DVValues.Location = new System.Drawing.Point(166, 150);
            this.DVValues.MultiSelect = false;
            this.DVValues.Name = "DVValues";
            this.DVValues.ReadOnly = true;
            this.DVValues.Size = new System.Drawing.Size(744, 357);
            this.DVValues.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 733);
            this.Controls.Add(this.DVValues);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlMainOperations);
            this.Name = "MainForm";
            this.Text = "Ana Sayfa";
            this.PnlMainOperations.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        MetroFramework.Controls.MetroContextMenu menuStrip1;
        private System.Windows.Forms.Button BtnCompanies;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Panel PnlMainOperations;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.DataView DVValues;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDocuments;
    }
}

