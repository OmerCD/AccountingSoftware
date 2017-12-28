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
            this.DgvDocuments.Location = new System.Drawing.Point(0, 0);
            this.DgvDocuments.Name = "DgvDocuments";
            this.DgvDocuments.Size = new System.Drawing.Size(541, 520);
            this.DgvDocuments.TabIndex = 0;
            // 
            // DocumentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 522);
            this.Controls.Add(this.DgvDocuments);
            this.Name = "DocumentPage";
            this.Text = "DocumentPage";
            this.Load += new System.EventHandler(this.DocumentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDocuments;
    }
}