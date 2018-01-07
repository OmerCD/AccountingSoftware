namespace HomePage.Forms.ModuleForms
{
    partial class DocumentPage
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
            this.DgvDocuments = new System.Windows.Forms.DataGridView();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.BtnColumnEditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDocuments
            // 
            this.DgvDocuments.AllowUserToAddRows = false;
            this.DgvDocuments.AllowUserToDeleteRows = false;
            this.DgvDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDocuments.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDocuments.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDocuments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvDocuments.Location = new System.Drawing.Point(12, 12);
            this.DgvDocuments.Name = "DgvDocuments";
            this.DgvDocuments.Size = new System.Drawing.Size(619, 498);
            this.DgvDocuments.TabIndex = 0;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(188)))), ((int)(((byte)(145)))));
            this.btnApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyChanges.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApplyChanges.ForeColor = System.Drawing.Color.Black;
            this.btnApplyChanges.Location = new System.Drawing.Point(637, 476);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(75, 34);
            this.btnApplyChanges.TabIndex = 1;
            this.btnApplyChanges.Text = "Kaydet";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // BtnColumnEditor
            // 
            this.BtnColumnEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnColumnEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.BtnColumnEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColumnEditor.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnColumnEditor.ForeColor = System.Drawing.Color.Black;
            this.BtnColumnEditor.Location = new System.Drawing.Point(637, 12);
            this.BtnColumnEditor.Name = "BtnColumnEditor";
            this.BtnColumnEditor.Size = new System.Drawing.Size(75, 62);
            this.BtnColumnEditor.TabIndex = 2;
            this.BtnColumnEditor.Text = "Sütun Editör";
            this.BtnColumnEditor.UseVisualStyleBackColor = false;
            this.BtnColumnEditor.Click += new System.EventHandler(this.BtnColumnEditor_Click);
            // 
            // DocumentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(724, 522);
            this.Controls.Add(this.BtnColumnEditor);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.DgvDocuments);
            this.MinimumSize = new System.Drawing.Size(740, 561);
            this.Name = "DocumentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durum Kontrol Sayfası";
            this.Load += new System.EventHandler(this.DocumentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDocuments;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Button BtnColumnEditor;
    }
}