﻿namespace HomePage.CustomControls
{
    partial class Container
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
            this.ContainerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContainerButton
            // 
            this.ContainerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContainerButton.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ContainerButton.ForeColor = System.Drawing.Color.White;
            this.ContainerButton.Location = new System.Drawing.Point(171, 202);
            this.ContainerButton.MaximumSize = new System.Drawing.Size(130, 48);
            this.ContainerButton.MinimumSize = new System.Drawing.Size(130, 48);
            this.ContainerButton.Name = "ContainerButton";
            this.ContainerButton.Size = new System.Drawing.Size(130, 48);
            this.ContainerButton.TabIndex = 0;
            this.ContainerButton.Text = "button1";
            this.ContainerButton.UseVisualStyleBackColor = true;
            this.ContainerButton.Visible = false;
            this.ContainerButton.Click += new System.EventHandler(this.ContainerButton_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContainerButton);
            this.Name = "Container";
            this.Size = new System.Drawing.Size(350, 263);
            this.Resize += new System.EventHandler(this.Container_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ContainerButton;
    }
}
