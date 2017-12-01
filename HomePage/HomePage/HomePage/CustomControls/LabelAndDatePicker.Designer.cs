namespace HomePage.CustomControls
{
    partial class LabelAndDatePicker
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
            this.LadErrorLabel = new System.Windows.Forms.Label();
            this.LadLabel = new System.Windows.Forms.Label();
            this.LadDtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LadErrorLabel
            // 
            this.LadErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadErrorLabel.AutoSize = true;
            this.LadErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.LadErrorLabel.Location = new System.Drawing.Point(353, 16);
            this.LadErrorLabel.Name = "LadErrorLabel";
            this.LadErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.LadErrorLabel.TabIndex = 6;
            // 
            // LadLabel
            // 
            this.LadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LadLabel.AutoSize = true;
            this.LadLabel.Location = new System.Drawing.Point(3, 17);
            this.LadLabel.Name = "LadLabel";
            this.LadLabel.Size = new System.Drawing.Size(35, 13);
            this.LadLabel.TabIndex = 5;
            this.LadLabel.Text = "label1";
            // 
            // LadDtp
            // 
            this.LadDtp.Location = new System.Drawing.Point(147, 10);
            this.LadDtp.Name = "LadDtp";
            this.LadDtp.Size = new System.Drawing.Size(200, 20);
            this.LadDtp.TabIndex = 7;
            // 
            // LabelAndDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LadDtp);
            this.Controls.Add(this.LadErrorLabel);
            this.Controls.Add(this.LadLabel);
            this.Name = "LabelAndDatePicker";
            this.Size = new System.Drawing.Size(620, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LadErrorLabel;
        public System.Windows.Forms.Label LadLabel;
        private System.Windows.Forms.DateTimePicker LadDtp;
    }
}
