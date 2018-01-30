using FontAwesome.Sharp;

namespace HomePage.CustomControls.MVC
{
    partial class MultiFlowAdd<TControl, TOutput>
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
            this.PanelControls = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddField = new System.Windows.Forms.Button();
            this.ButtonRemoveField = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonRemoveAll = new System.Windows.Forms.Button();
            this.ButtonRevert = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // PanelControls
            // 
            this.PanelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControls.AutoScroll = true;
            this.PanelControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelControls.Location = new System.Drawing.Point(0, 0);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(654, 465);
            this.PanelControls.TabIndex = 0;
            this.PanelControls.WrapContents = false;
            // 
            // ButtonAddField
            // 
            this.ButtonAddField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddField.BackColor = System.Drawing.Color.Tomato;
            this.ButtonAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddField.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAddField.ForeColor = System.Drawing.Color.White;
            this.ButtonAddField.Location = new System.Drawing.Point(12, 471);
            this.ButtonAddField.Name = "ButtonAddField";
            this.ButtonAddField.Size = new System.Drawing.Size(84, 31);
            this.ButtonAddField.TabIndex = 0;
            this.ButtonAddField.Text = "Ekle";
            this.ButtonAddField.UseVisualStyleBackColor = false;
            this.ButtonAddField.Click += new System.EventHandler(this.ButtonAddField_Click);
            // 
            // ButtonRemoveField
            // 
            this.ButtonRemoveField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRemoveField.BackColor = System.Drawing.Color.Tomato;
            this.ButtonRemoveField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveField.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonRemoveField.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveField.Location = new System.Drawing.Point(109, 471);
            this.ButtonRemoveField.Name = "ButtonRemoveField";
            this.ButtonRemoveField.Size = new System.Drawing.Size(84, 31);
            this.ButtonRemoveField.TabIndex = 1;
            this.ButtonRemoveField.Text = "Çıkar";
            this.ButtonRemoveField.UseVisualStyleBackColor = false;
            this.ButtonRemoveField.Click += new System.EventHandler(this.ButtonRemoveField_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonApply.BackColor = System.Drawing.Color.Tomato;
            this.ButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApply.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonApply.ForeColor = System.Drawing.Color.White;
            this.ButtonApply.Location = new System.Drawing.Point(567, 471);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(84, 31);
            this.ButtonApply.TabIndex = 2;
            this.ButtonApply.Text = "Onayla";
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // ButtonRemoveAll
            // 
            this.ButtonRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRemoveAll.BackColor = System.Drawing.Color.Tomato;
            this.ButtonRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveAll.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonRemoveAll.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveAll.Location = new System.Drawing.Point(206, 471);
            this.ButtonRemoveAll.Name = "ButtonRemoveAll";
            this.ButtonRemoveAll.Size = new System.Drawing.Size(109, 31);
            this.ButtonRemoveAll.TabIndex = 3;
            this.ButtonRemoveAll.Text = "Hepsini Kaldır";
            this.ButtonRemoveAll.UseVisualStyleBackColor = false;
            this.ButtonRemoveAll.Click += new System.EventHandler(this.ButtonRemoveAll_Click);
            // 
            // ButtonRevert
            // 
            this.ButtonRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRevert.BackColor = System.Drawing.Color.Tomato;
            this.ButtonRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRevert.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonRevert.ForeColor = System.Drawing.Color.White;
            this.ButtonRevert.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.ButtonRevert.IconColor = System.Drawing.Color.White;
            this.ButtonRevert.IconSize = 26;
            this.ButtonRevert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonRevert.Location = new System.Drawing.Point(328, 471);
            this.ButtonRevert.Name = "ButtonRevert";
            this.ButtonRevert.Rotation = 0D;
            this.ButtonRevert.Size = new System.Drawing.Size(42, 31);
            this.ButtonRevert.TabIndex = 4;
            this.ButtonRevert.UseVisualStyleBackColor = false;
            this.ButtonRevert.Click += new System.EventHandler(this.ButtonRevert_Click);
            // 
            // MultiFlowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(654, 506);
            this.Controls.Add(this.ButtonRevert);
            this.Controls.Add(this.ButtonRemoveAll);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonRemoveField);
            this.Controls.Add(this.ButtonAddField);
            this.Controls.Add(this.PanelControls);
            this.MinimumSize = new System.Drawing.Size(670, 545);
            this.Name = "MultiFlowAdd";
            this.Text = "Çoklu Ekleme Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelControls;
        private System.Windows.Forms.Button ButtonAddField;
        private System.Windows.Forms.Button ButtonRemoveField;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonRemoveAll;
        private IconButton ButtonRevert;
    }
}