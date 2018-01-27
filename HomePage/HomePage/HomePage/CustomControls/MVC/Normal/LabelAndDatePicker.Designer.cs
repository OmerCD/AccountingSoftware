using HomePage.CustomControls.MVC;

namespace HomePage.CustomControls
{
    partial class LabelAndDatePicker : LabelAndControl
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
            // LadDtp
            // 
            this.LadDtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LadDtp.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LadDtp.Location = new System.Drawing.Point(209, 10);
            this.LadDtp.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.LadDtp.Name = "LadDtp";
            this.LadDtp.Size = new System.Drawing.Size(200, 27);
            this.LadDtp.TabIndex = 7;
            // 
            // LabelAndDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LadDtp);
            this.Controls.Add(this.LadErrorLabel);
            this.Name = "LabelAndDatePicker";
            this.Controls.SetChildIndex(this.LadErrorLabel, 0);
            this.Controls.SetChildIndex(this.LadDtp, 0);
            this.Controls.SetChildIndex(this.ErrorLabel, 0);
            this.Controls.SetChildIndex(this.ControlLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LadErrorLabel;
        private System.Windows.Forms.DateTimePicker LadDtp;
    }
}
