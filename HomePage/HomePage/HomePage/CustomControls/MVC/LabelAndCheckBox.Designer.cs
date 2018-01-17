using HomePage.CustomControls.MVC;

namespace HomePage.CustomControls
{
    partial class LabelAndCheckBox : LabelAndControl
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
            this.LacCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.Name = "LabelAndCheckBox";
            this.Size = new System.Drawing.Size(620, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox LacCheckBox;
    }
}
