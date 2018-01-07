

namespace HomePage.Forms.ModuleForms
{
    partial class ColumnEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnEditor));
            this.LvColumns = new HomePage.CustomControls.DataListView();
            this.ChName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChOptions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TbColumnName = new HomePage.CustomControls.MyTextBox();
            this.LbAnswers = new System.Windows.Forms.ListBox();
            this.TbAnswer = new HomePage.CustomControls.MyTextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDeleteAnswer = new System.Windows.Forms.Button();
            this.BtnAddAnswer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvColumns
            // 
            this.LvColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChName,
            this.ChOptions});
            this.LvColumns.FullRowSelect = true;
            this.LvColumns.HideSelection = false;
            this.LvColumns.Location = new System.Drawing.Point(12, 37);
            this.LvColumns.MinimumSize = new System.Drawing.Size(326, 330);
            this.LvColumns.MultiSelect = false;
            this.LvColumns.Name = "LvColumns";
            this.LvColumns.Size = new System.Drawing.Size(358, 344);
            this.LvColumns.TabIndex = 0;
            this.LvColumns.UseCompatibleStateImageBehavior = false;
            this.LvColumns.View = System.Windows.Forms.View.Details;
            this.LvColumns.SelectedIndexChanged += new System.EventHandler(this.LvColumns_SelectedIndexChanged);
            // 
            // ChName
            // 
            this.ChName.Text = "Sütun Adı";
            this.ChName.Width = 185;
            // 
            // ChOptions
            // 
            this.ChOptions.Text = "Cevaplar";
            this.ChOptions.Width = 133;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sütun Adı:";
            // 
            // TbColumnName
            // 
            this.TbColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbColumnName.ForeColor = System.Drawing.Color.Silver;
            this.TbColumnName.Location = new System.Drawing.Point(110, 19);
            this.TbColumnName.Name = "TbColumnName";
            this.TbColumnName.PlaceHolder = null;
            this.TbColumnName.Size = new System.Drawing.Size(100, 20);
            this.TbColumnName.TabIndex = 2;
            // 
            // LbAnswers
            // 
            this.LbAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbAnswers.FormattingEnabled = true;
            this.LbAnswers.Location = new System.Drawing.Point(110, 85);
            this.LbAnswers.Name = "LbAnswers";
            this.LbAnswers.Size = new System.Drawing.Size(100, 95);
            this.LbAnswers.TabIndex = 3;
            // 
            // TbAnswer
            // 
            this.TbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAnswer.ForeColor = System.Drawing.Color.Silver;
            this.TbAnswer.Location = new System.Drawing.Point(110, 52);
            this.TbAnswer.Name = "TbAnswer";
            this.TbAnswer.PlaceHolder = null;
            this.TbAnswer.Size = new System.Drawing.Size(100, 20);
            this.TbAnswer.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(132)))), ((int)(((byte)(167)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(564, 136);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 35);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Sütun Ekle";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(132)))), ((int)(((byte)(167)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(376, 37);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(85, 35);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(132)))), ((int)(((byte)(167)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(376, 78);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 35);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDeleteAnswer
            // 
            this.BtnDeleteAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(132)))), ((int)(((byte)(167)))));
            this.BtnDeleteAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteAnswer.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDeleteAnswer.ForeColor = System.Drawing.Color.Black;
            this.BtnDeleteAnswer.Location = new System.Drawing.Point(215, 145);
            this.BtnDeleteAnswer.Name = "BtnDeleteAnswer";
            this.BtnDeleteAnswer.Size = new System.Drawing.Size(85, 35);
            this.BtnDeleteAnswer.TabIndex = 10;
            this.BtnDeleteAnswer.Text = "Cevap Sil";
            this.BtnDeleteAnswer.UseVisualStyleBackColor = false;
            this.BtnDeleteAnswer.Click += new System.EventHandler(this.BtnDeleteAnswer_Click);
            // 
            // BtnAddAnswer
            // 
            this.BtnAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(132)))), ((int)(((byte)(167)))));
            this.BtnAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAnswer.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddAnswer.ForeColor = System.Drawing.Color.Black;
            this.BtnAddAnswer.Location = new System.Drawing.Point(215, 44);
            this.BtnAddAnswer.Name = "BtnAddAnswer";
            this.BtnAddAnswer.Size = new System.Drawing.Size(85, 35);
            this.BtnAddAnswer.TabIndex = 8;
            this.BtnAddAnswer.Text = "Cevap Ekle";
            this.BtnAddAnswer.UseVisualStyleBackColor = false;
            this.BtnAddAnswer.Click += new System.EventHandler(this.BtnAddAnswer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cevap Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbColumnName);
            this.groupBox1.Controls.Add(this.BtnDeleteAnswer);
            this.groupBox1.Controls.Add(this.LbAnswers);
            this.groupBox1.Controls.Add(this.BtnAddAnswer);
            this.groupBox1.Controls.Add(this.TbAnswer);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(386, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sütun Özellikleri";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(685, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ColumnEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(729, 393);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LvColumns);
            this.MinimumSize = new System.Drawing.Size(729, 393);
            this.Name = "ColumnEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Column Editor";
            this.Load += new System.EventHandler(this.ColumnEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HomePage.CustomControls.DataListView LvColumns;
        private System.Windows.Forms.Label label1;
        private CustomControls.MyTextBox TbColumnName;
        private System.Windows.Forms.ListBox LbAnswers;
        private CustomControls.MyTextBox TbAnswer;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnDeleteAnswer;
        private System.Windows.Forms.Button BtnAddAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ChName;
        private System.Windows.Forms.ColumnHeader ChOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
    }
}