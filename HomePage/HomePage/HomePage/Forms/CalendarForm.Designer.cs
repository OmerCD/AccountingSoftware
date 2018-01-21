using HomePage.CustomControls.Calendar;

namespace HomePage.Forms
{
    partial class CalendarForm
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
            this.calendar1 = new HomePage.CustomControls.Calendar.Calendar();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(12, 12);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(1059, 549);
            this.calendar1.TabIndex = 0;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 573);
            this.Controls.Add(this.calendar1);
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Calendar calendar1;
    }
}