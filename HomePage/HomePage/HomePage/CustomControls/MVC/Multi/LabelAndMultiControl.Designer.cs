namespace HomePage.CustomControls.MVC
{
    partial class LabelAndMultiControl<T> : LabelAndControl where T : LabelAndControl, new()
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
            this.ButtonMultiAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonMultiAdd
            // 
            this.ButtonMultiAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.ButtonMultiAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiAdd.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonMultiAdd.ForeColor = System.Drawing.Color.Ivory;
            this.ButtonMultiAdd.Location = new System.Drawing.Point(209, 9);
            this.ButtonMultiAdd.Name = "ButtonMultiAdd";
            this.ButtonMultiAdd.Size = new System.Drawing.Size(200, 27);
            this.ButtonMultiAdd.TabIndex = 7;
            this.ButtonMultiAdd.Text = "Elemanlar";
            this.ButtonMultiAdd.UseVisualStyleBackColor = false;
            this.ButtonMultiAdd.Click += new System.EventHandler(this.ButtonMultiAdd_Click);
            // 
            // LabelAndMultiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.ButtonMultiAdd);
            this.Name = "LabelAndMultiControl";
            this.Controls.SetChildIndex(this.ErrorLabel, 0);
            this.Controls.SetChildIndex(this.ControlLabel, 0);
            this.Controls.SetChildIndex(this.ButtonMultiAdd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonMultiAdd;
    }
}
