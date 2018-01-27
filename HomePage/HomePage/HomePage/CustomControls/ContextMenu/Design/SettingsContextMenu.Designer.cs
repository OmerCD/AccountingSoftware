﻿using System.Drawing;
using FontAwesome.Sharp;

namespace HomePage.CustomControls.ContextMenu
{
    partial class SettingsContextMenu
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
            this.BtnLogOut = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnLogOut.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogOut.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnLogOut.IconColor = System.Drawing.Color.AliceBlue;
            this.BtnLogOut.IconSize = 24;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogOut.Location = new System.Drawing.Point(3, 3);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Rotation = 0D;
            this.BtnLogOut.Size = new System.Drawing.Size(150, 32);
            this.BtnLogOut.TabIndex = 0;
            this.BtnLogOut.Text = "Oturumu Kapat";
            this.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.UseVisualStyleBackColor = false;
            // 
            // SettingsContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.BtnLogOut);
            this.Name = "SettingsContextMenu";
            this.Size = new System.Drawing.Size(150, 87);
            this.ResumeLayout(false);

        }

        #endregion

        public IconButton BtnLogOut;
    }
}
