﻿namespace HomePage
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.container1 = new HomePage.CustomControls.Container();
            this.metroMenuStrip1 = new HomePage.CustomControls.MetroMenuStrip();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // container1
            // 
            this.container1.AutoSize = true;
            this.container1.Location = new System.Drawing.Point(92, 154);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(324, 150);
            this.container1.TabIndex = 2;
            // 
            // metroMenuStrip1
            // 
            this.metroMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.metroMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItem});
            this.metroMenuStrip1.Location = new System.Drawing.Point(20, 60);
            this.metroMenuStrip1.Name = "metroMenuStrip1";
            this.metroMenuStrip1.Size = new System.Drawing.Size(716, 28);
            this.metroMenuStrip1.TabIndex = 3;
            this.metroMenuStrip1.Text = "metroMenuStrip1";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(68, 24);
            this.SettingsMenuItem.Text = "Ayarlar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 343);
            this.Controls.Add(this.container1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroMenuStrip1);
            this.MainMenuStrip = this.metroMenuStrip1;
            this.Name = "MainForm";
            this.Text = "Ana Sayfa";
            this.metroMenuStrip1.ResumeLayout(false);
            this.metroMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        MetroFramework.Controls.MetroContextMenu menuStrip1;
        private System.Windows.Forms.Button button1;
        private CustomControls.Container container1;
        private CustomControls.MetroMenuStrip metroMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
    }
}
