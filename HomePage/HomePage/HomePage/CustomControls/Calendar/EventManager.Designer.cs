namespace HomePage.CustomControls.Calendar
{
    partial class EventManager
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
            this.ListBoxEventsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxJobList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAddEvent = new System.Windows.Forms.Button();
            this.ButtonAddJob = new System.Windows.Forms.Button();
            this.EventViewer = new CustomControls.Container(true);
            this.SuspendLayout();
            // 
            // ListBoxEventsList
            // 
            this.ListBoxEventsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxEventsList.BackColor = System.Drawing.Color.Gray;
            this.ListBoxEventsList.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListBoxEventsList.ForeColor = System.Drawing.SystemColors.Window;
            this.ListBoxEventsList.FormattingEnabled = true;
            this.ListBoxEventsList.ItemHeight = 20;
            this.ListBoxEventsList.Location = new System.Drawing.Point(13, 40);
            this.ListBoxEventsList.Name = "ListBoxEventsList";
            this.ListBoxEventsList.Size = new System.Drawing.Size(136, 204);
            this.ListBoxEventsList.TabIndex = 0;
            this.ListBoxEventsList.SelectedIndexChanged += new System.EventHandler(this.ListBoxEventsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olay Listesi";
            // 
            // ListBoxJobList
            // 
            this.ListBoxJobList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxJobList.BackColor = System.Drawing.Color.Gray;
            this.ListBoxJobList.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListBoxJobList.ForeColor = System.Drawing.SystemColors.Window;
            this.ListBoxJobList.FormattingEnabled = true;
            this.ListBoxJobList.ItemHeight = 20;
            this.ListBoxJobList.Location = new System.Drawing.Point(155, 40);
            this.ListBoxJobList.Name = "ListBoxJobList";
            this.ListBoxJobList.Size = new System.Drawing.Size(136, 204);
            this.ListBoxJobList.TabIndex = 2;
            this.ListBoxJobList.SelectedIndexChanged += new System.EventHandler(this.ListBoxJobList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(152, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "İş Listesi";
            // 
            // EventViewer
            // 
            //this.EventViewer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.EventViewer.AutoScroll = true;
            this.EventViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.EventViewer.Location = new System.Drawing.Point(301, 40);
            this.EventViewer.Name = "EventViewer";
            this.EventViewer.Object = null;
            this.EventViewer.Size = new System.Drawing.Size(800, 251);
            this.EventViewer.TabIndex = 4;
            this.EventViewer.ButtonText = "Güncelle";
            // 
            // ButtonAddEvent
            // 
            this.ButtonAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddEvent.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddEvent.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAddEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAddEvent.Location = new System.Drawing.Point(13, 251);
            this.ButtonAddEvent.Name = "ButtonAddEvent";
            this.ButtonAddEvent.Size = new System.Drawing.Size(136, 40);
            this.ButtonAddEvent.TabIndex = 5;
            this.ButtonAddEvent.Text = "Olay Ekle";
            this.ButtonAddEvent.UseVisualStyleBackColor = false;
            this.ButtonAddEvent.Click += new System.EventHandler(this.ButtonAddEvent_Click);
            // 
            // ButtonAddJob
            // 
            this.ButtonAddJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddJob.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddJob.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAddJob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonAddJob.Location = new System.Drawing.Point(155, 251);
            this.ButtonAddJob.Name = "ButtonAddJob";
            this.ButtonAddJob.Size = new System.Drawing.Size(136, 40);
            this.ButtonAddJob.TabIndex = 6;
            this.ButtonAddJob.Text = "İş Ekle";
            this.ButtonAddJob.UseVisualStyleBackColor = false;
            this.ButtonAddJob.Click += new System.EventHandler(this.ButtonAddJob_Click);
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.ButtonAddJob);
            this.Controls.Add(this.ButtonAddEvent);
            this.Controls.Add(this.EventViewer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBoxJobList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxEventsList);
            this.Name = "EventManager";
            this.Size = new System.Drawing.Size(918, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxEventsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxJobList;
        private System.Windows.Forms.Label label2;
        private Container EventViewer;
        private System.Windows.Forms.Button ButtonAddEvent;
        private System.Windows.Forms.Button ButtonAddJob;
    }
}
