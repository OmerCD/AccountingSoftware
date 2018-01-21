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
            this.flpnlEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpnlEvents
            // 
            this.flpnlEvents.Location = new System.Drawing.Point(3, 29);
            this.flpnlEvents.Name = "flpnlEvents";
            this.flpnlEvents.Size = new System.Drawing.Size(144, 114);
            this.flpnlEvents.TabIndex = 3;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(3, 13);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(35, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "label1";
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpnlEvents);
            this.Controls.Add(this.lblDay);
            this.Name = "Day";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnlEvents;
        private System.Windows.Forms.Label lblDay;
    }
}
