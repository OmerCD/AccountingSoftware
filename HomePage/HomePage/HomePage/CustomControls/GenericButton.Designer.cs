namespace HomePage.CustomControls
{
    partial class GenericButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelText = new System.Windows.Forms.Label();
            this.ButtonGeneric = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.LabelText.Location = new System.Drawing.Point(21, 63);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(37, 18);
            this.LabelText.TabIndex = 7;
            this.LabelText.Text = "Ekle";
            // 
            // ButtonGeneric
            // 
            this.ButtonGeneric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGeneric.FlatAppearance.BorderSize = 0;
            this.ButtonGeneric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ButtonGeneric.Location = new System.Drawing.Point(0, 1);
            this.ButtonGeneric.Name = "ButtonGeneric";
            this.ButtonGeneric.Size = new System.Drawing.Size(78, 60);
            this.ButtonGeneric.TabIndex = 6;
            this.ButtonGeneric.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonGeneric.UseVisualStyleBackColor = true;
            this.ButtonGeneric.Click += new System.EventHandler(this.ButtonGeneric_Click);
            // 
            // GenericButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.ButtonGeneric);
            this.Name = "GenericButton";
            this.Size = new System.Drawing.Size(80, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Button ButtonGeneric;
    }
}
