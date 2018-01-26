using System;

namespace HomePage.CustomControls.Calendar
{
    partial class Calendar
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
            this.LabelYear = new System.Windows.Forms.Label();
            this.TLPDates = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Titillium Web", 16.25F, System.Drawing.FontStyle.Bold);
            this.LabelYear.ForeColor = System.Drawing.Color.Coral;
            this.LabelYear.Location = new System.Drawing.Point(3, 16);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(73, 34);
            this.LabelYear.TabIndex = 9;
            this.LabelYear.Text = "label1";
            // 
            // TLPDates
            // 
            this.TLPDates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLPDates.ColumnCount = 7;
            this.TLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21464F));
            this.TLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21464F));
            this.TLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21464F));
            this.TLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21464F));
            this.TLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21464F));
            this.TLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21465F));
            this.TLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.71215F));
            this.TLPDates.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TLPDates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TLPDates.Location = new System.Drawing.Point(3, 63);
            this.TLPDates.Name = "TLPDates";
            this.TLPDates.RowCount = 6;
            this.TLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.TLPDates.Size = new System.Drawing.Size(638, 347);
            this.TLPDates.TabIndex = 8;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMonth.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextMonth.Location = new System.Drawing.Point(315, 11);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(136, 37);
            this.btnNextMonth.TabIndex = 7;
            this.btnNextMonth.Text = "Sonraki Ay";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousMonth.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviousMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreviousMonth.Location = new System.Drawing.Point(158, 11);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(136, 37);
            this.btnPreviousMonth.TabIndex = 6;
            this.btnPreviousMonth.Text = "Önceki Ay";
            this.btnPreviousMonth.UseVisualStyleBackColor = false;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Titillium Web", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMonth.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblMonth.Location = new System.Drawing.Point(73, 19);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(64, 29);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "label1";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.TLPDates);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnPreviousMonth);
            this.Controls.Add(this.lblMonth);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(644, 415);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.TableLayoutPanel TLPDates;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Label lblMonth;
    }
}
