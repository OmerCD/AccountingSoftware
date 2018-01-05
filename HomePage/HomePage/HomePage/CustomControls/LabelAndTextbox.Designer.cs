namespace HomePage.CustomControls
{
    partial class LabelAndTextbox
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
            this.LatLabel = new System.Windows.Forms.Label();
            this.LatErrorLabel = new System.Windows.Forms.Label();
            this.LatTextBox = new HomePage.CustomControls.MyTextBox();
            this.SuspendLayout();
            // 
            // LatLabel
            // 
            this.LatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LatLabel.AutoSize = true;
            this.LatLabel.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LatLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LatLabel.Location = new System.Drawing.Point(3, 12);
            this.LatLabel.Name = "LatLabel";
            this.LatLabel.Size = new System.Drawing.Size(45, 20);
            this.LatLabel.TabIndex = 0;
            this.LatLabel.Text = "label1";
            this.LatLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LatErrorLabel
            // 
            this.LatErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LatErrorLabel.AutoSize = true;
            this.LatErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.LatErrorLabel.Location = new System.Drawing.Point(384, 16);
            this.LatErrorLabel.Name = "LatErrorLabel";
            this.LatErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.LatErrorLabel.TabIndex = 2;
            // 
            // LatTextBox
            // 
            this.LatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LatTextBox.ForeColor = System.Drawing.Color.Silver;
            this.LatTextBox.Location = new System.Drawing.Point(209, 13);
            this.LatTextBox.Name = "LatTextBox";
            this.LatTextBox.PlaceHolder = null;
            this.LatTextBox.Size = new System.Drawing.Size(169, 20);
            this.LatTextBox.TabIndex = 4;
            this.LatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAndTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.LatTextBox);
            this.Controls.Add(this.LatErrorLabel);
            this.Controls.Add(this.LatLabel);
            this.Name = "LabelAndTextbox";
            this.Size = new System.Drawing.Size(620, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LatLabel;
        private System.Windows.Forms.Label LatErrorLabel;
        public MyTextBox LatTextBox;
    }
}
