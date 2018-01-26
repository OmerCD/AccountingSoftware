namespace HomePage.CustomControls.MVC
{
    partial class LabelAndControl
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
            this.ControlLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ControlLabel
            // 
            this.ControlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ControlLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ControlLabel.Location = new System.Drawing.Point(3, 12);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(45, 20);
            this.ControlLabel.TabIndex = 1;
            this.ControlLabel.Text = "label1";
            this.ControlLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(412, 15);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 2;
            // 
            // LabelAndControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Name = "LabelAndControl";
            this.Size = new System.Drawing.Size(710, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ControlLabel;
        protected System.Windows.Forms.Label ErrorLabel;

    }
}
