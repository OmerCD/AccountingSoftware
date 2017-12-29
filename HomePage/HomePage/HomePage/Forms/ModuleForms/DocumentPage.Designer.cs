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
            this.DgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocuments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvDocuments.Location = new System.Drawing.Point(0, 0);
            this.DgvDocuments.Name = "DgvDocuments";
            this.DgvDocuments.Size = new System.Drawing.Size(541, 520);
            this.DgvDocuments.TabIndex = 0;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(574, 53);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(75, 23);
            this.btnApplyChanges.TabIndex = 1;
            this.btnApplyChanges.Text = "Kaydet";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // BtnColumnEditor
            // 
            this.BtnColumnEditor.Location = new System.Drawing.Point(574, 131);
            this.BtnColumnEditor.Name = "BtnColumnEditor";
            this.BtnColumnEditor.Size = new System.Drawing.Size(75, 23);
            this.BtnColumnEditor.TabIndex = 2;
            this.BtnColumnEditor.Text = "Sütun Editör";
            this.BtnColumnEditor.UseVisualStyleBackColor = true;
            this.BtnColumnEditor.Click += new System.EventHandler(this.BtnColumnEditor_Click);
            // 
            // DocumentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 522);
            this.Controls.Add(this.BtnColumnEditor);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.DgvDocuments);
            this.Name = "DocumentPage";
            this.Text = "DocumentPage";
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