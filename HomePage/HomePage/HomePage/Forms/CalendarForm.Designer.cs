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
            this.eventManager1 = new HomePage.CustomControls.Calendar.EventManager();
            this.calendar1 = new HomePage.CustomControls.Calendar.Calendar();
            this.SuspendLayout();
            // 
            // eventManager1
            // 
            this.eventManager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventManager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.eventManager1.Location = new System.Drawing.Point(27, 406);
            this.eventManager1.Name = "eventManager1";
            this.eventManager1.Size = new System.Drawing.Size(803, 318);
            this.eventManager1.TabIndex = 1;
            // 
            // calendar1
            // 
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.calendar1.ChoosenDate = new System.DateTime(2018, 1, 24, 15, 53, 56, 577);
            this.calendar1.Location = new System.Drawing.Point(27, 30);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(794, 370);
            this.calendar1.TabIndex = 2;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(842, 736);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.eventManager1);
            this.MinimumSize = new System.Drawing.Size(858, 775);
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.ResumeLayout(false);

        }

        #endregion
        private EventManager eventManager1;
        private Calendar calendar1;
    }
}