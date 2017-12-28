

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
            this.LvColumns.Location = new System.Drawing.Point(12, 12);
            this.LvColumns.MinimumSize = new System.Drawing.Size(326, 330);
            this.LvColumns.MultiSelect = false;
            this.LvColumns.Name = "LvColumns";
            this.LvColumns.Size = new System.Drawing.Size(326, 330);
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
            this.label1.Location = new System.Drawing.Point(452, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sütun Adı:";
            // 
            // TbColumnName
            // 
            this.TbColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbColumnName.ForeColor = System.Drawing.Color.Silver;
            this.TbColumnName.Location = new System.Drawing.Point(514, 67);
            this.TbColumnName.Name = "TbColumnName";
            this.TbColumnName.PlaceHolder = null;
            this.TbColumnName.Size = new System.Drawing.Size(100, 20);
            this.TbColumnName.TabIndex = 2;
            // 
            // LbAnswers
            // 
            this.LbAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbAnswers.FormattingEnabled = true;
            this.LbAnswers.Location = new System.Drawing.Point(455, 93);
            this.LbAnswers.Name = "LbAnswers";
            this.LbAnswers.Size = new System.Drawing.Size(120, 95);
            this.LbAnswers.TabIndex = 3;
            this.LbAnswers.SelectedIndexChanged += new System.EventHandler(this.LbAnswers_SelectedIndexChanged);
            // 
            // TbAnswer
            // 
            this.TbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAnswer.ForeColor = System.Drawing.Color.Silver;
            this.TbAnswer.Location = new System.Drawing.Point(489, 222);
            this.TbAnswer.Name = "TbAnswer";
            this.TbAnswer.PlaceHolder = null;
            this.TbAnswer.Size = new System.Drawing.Size(100, 20);
            this.TbAnswer.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(344, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(344, 41);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(344, 70);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDeleteAnswer
            // 
            this.BtnDeleteAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteAnswer.Location = new System.Drawing.Point(581, 104);
            this.BtnDeleteAnswer.Name = "BtnDeleteAnswer";
            this.BtnDeleteAnswer.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteAnswer.TabIndex = 10;
            this.BtnDeleteAnswer.Text = "Sil";
            this.BtnDeleteAnswer.UseVisualStyleBackColor = true;
            this.BtnDeleteAnswer.Click += new System.EventHandler(this.BtnDeleteAnswer_Click);
            // 
            // BtnAddAnswer
            // 
            this.BtnAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAnswer.Location = new System.Drawing.Point(595, 221);
            this.BtnAddAnswer.Name = "BtnAddAnswer";
            this.BtnAddAnswer.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAnswer.TabIndex = 8;
            this.BtnAddAnswer.Text = "Ekle";
            this.BtnAddAnswer.UseVisualStyleBackColor = true;
            this.BtnAddAnswer.Click += new System.EventHandler(this.BtnAddAnswer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cevap Adı";
            // 
            // ColumnEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDeleteAnswer);
            this.Controls.Add(this.BtnAddAnswer);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbAnswer);
            this.Controls.Add(this.LbAnswers);
            this.Controls.Add(this.TbColumnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LvColumns);
            this.MinimumSize = new System.Drawing.Size(729, 393);
            this.Name = "ColumnEditor";
            this.Text = "Column Editor";
            this.Load += new System.EventHandler(this.ColumnEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}