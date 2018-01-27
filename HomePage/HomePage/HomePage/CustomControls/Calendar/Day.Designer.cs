namespace HomePage.CustomControls.Calendar
{
    partial class Day
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
            this.lblDay = new System.Windows.Forms.Label();
            this.pictureBoxJob = new System.Windows.Forms.PictureBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(3, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(35, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "label1";
            // 
            // pictureBoxJob
            // 
            this.pictureBoxJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxJob.Image = global::HomePage.Properties.Resources.warning_red;
            this.pictureBoxJob.Location = new System.Drawing.Point(101, 3);
            this.pictureBoxJob.Name = "pictureBoxJob";
            this.pictureBoxJob.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxJob.TabIndex = 4;
            this.pictureBoxJob.TabStop = false;
            this.pictureBoxJob.Visible = false;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEvent.Image = global::HomePage.Properties.Resources.warning_yellow;
            this.pictureBoxEvent.Location = new System.Drawing.Point(71, 3);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxEvent.TabIndex = 3;
            this.pictureBoxEvent.TabStop = false;
            this.pictureBoxEvent.Visible = false;
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.pictureBoxJob);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.lblDay);
            this.Name = "Day";
            this.Size = new System.Drawing.Size(126, 44);
            this.Click += new System.EventHandler(this.Day_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.PictureBox pictureBoxJob;
    }
}
