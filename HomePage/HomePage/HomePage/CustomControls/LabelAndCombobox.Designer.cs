namespace HomePage.CustomControls
{
    partial class LabelAndCombobox
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
            this.LacLabel = new System.Windows.Forms.Label();
            this.LacComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LacLabel
            // 
            this.LacLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LacLabel.AutoSize = true;
            this.LacLabel.Location = new System.Drawing.Point(3, 16);
            this.LacLabel.Name = "LacLabel";
            this.LacLabel.Size = new System.Drawing.Size(35, 13);
            this.LacLabel.TabIndex = 1;
            this.LacLabel.Text = "label1";
            // 
            // LacComboBox
            // 
            this.LacComboBox.FormattingEnabled = true;
            this.LacComboBox.Location = new System.Drawing.Point(209, 13);
            this.LacComboBox.Name = "LacComboBox";
            this.LacComboBox.Size = new System.Drawing.Size(121, 21);
            this.LacComboBox.TabIndex = 2;
            // 
            // LabelAndCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LacComboBox);
            this.Controls.Add(this.LacLabel);
            this.Name = "LabelAndCombobox";
            this.Size = new System.Drawing.Size(620, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LacLabel;
        private System.Windows.Forms.ComboBox LacComboBox;
    }
}
