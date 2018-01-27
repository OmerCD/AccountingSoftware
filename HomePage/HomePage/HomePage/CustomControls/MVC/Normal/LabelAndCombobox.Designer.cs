using HomePage.CustomControls.MVC;

namespace HomePage.CustomControls
{
    partial class LabelAndCombobox : LabelAndControl
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
            this.LacComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LacComboBox
            // 
            this.LacComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LacComboBox.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LacComboBox.FormattingEnabled = true;
            this.LacComboBox.Location = new System.Drawing.Point(209, 9);
            this.LacComboBox.Name = "LacComboBox";
            this.LacComboBox.Size = new System.Drawing.Size(200, 28);
            this.LacComboBox.TabIndex = 2;
            // 
            // LabelAndCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LacComboBox);
            this.Name = "LabelAndCombobox";
            this.Controls.SetChildIndex(this.LacComboBox, 0);
            this.Controls.SetChildIndex(this.ErrorLabel, 0);
            this.Controls.SetChildIndex(this.ControlLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox LacComboBox;
    }
}
