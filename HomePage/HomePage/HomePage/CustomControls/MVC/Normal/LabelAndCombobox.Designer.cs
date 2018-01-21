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
            this.Name = "LabelAndCombobox";
            this.Size = new System.Drawing.Size(620, 46);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox LacComboBox;
    }
}
