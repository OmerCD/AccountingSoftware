using HomePage.CustomControls.MVC;

namespace HomePage.CustomControls
{
    partial class LabelAndTextbox : LabelAndControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LatTextBox = new HomePage.CustomControls.MyTextBox();
            this.SuspendLayout();
            // 
            // LatTextBox
            // 
            this.LatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LatTextBox.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LatTextBox.ForeColor = System.Drawing.Color.Silver;
            this.LatTextBox.Location = new System.Drawing.Point(209, 10);
            this.LatTextBox.Name = "LatTextBox";
            this.LatTextBox.PlaceHolder = null;
            this.LatTextBox.Size = new System.Drawing.Size(200, 27);
            this.LatTextBox.TabIndex = 4;
            this.LatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAndTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.LatTextBox);
            this.Name = "LabelAndTextbox";
            this.Controls.SetChildIndex(this.ErrorLabel, 0);
            this.Controls.SetChildIndex(this.LatTextBox, 0);
            this.Controls.SetChildIndex(this.ControlLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MyTextBox LatTextBox;
    }
}
