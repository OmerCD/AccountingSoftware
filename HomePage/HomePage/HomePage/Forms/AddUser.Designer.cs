namespace HomePage.Forms
{
    partial class AddUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container1 = new HomePage.CustomControls.Container();
            this.SuspendLayout();
            // 
            // container1
            // 
            this.container1.ClickEvent = null;
            this.container1.Location = new System.Drawing.Point(23, 79);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(698, 399);
            this.container1.TabIndex = 0;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.container1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Container container1;
    }
}