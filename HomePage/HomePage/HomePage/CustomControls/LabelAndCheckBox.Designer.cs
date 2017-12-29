namespace HomePage.CustomControls
{
    partial class LabelAndCheckBox
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
            this.LacCheckBox = new System.Windows.Forms.CheckBox();
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
            this.LacLabel.TabIndex = 3;
            this.LacLabel.Text = "label1";
            // 
            // LacCheckBox
            // 
            this.LacCheckBox.AutoSize = true;
            this.LacCheckBox.Location = new System.Drawing.Point(209, 13);
            this.LacCheckBox.Name = "LacCheckBox";
            this.LacCheckBox.Size = new System.Drawing.Size(80, 17);
            this.LacCheckBox.TabIndex = 4;
            this.LacCheckBox.Text = "checkBox1";
            this.LacCheckBox.UseVisualStyleBackColor = true;
            // 
            // LabelAndCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LacCheckBox);
            this.Controls.Add(this.LacLabel);
            this.Name = "LabelAndCheckBox";
            this.Size = new System.Drawing.Size(620, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LacLabel;
        private System.Windows.Forms.CheckBox LacCheckBox;
    }
}
