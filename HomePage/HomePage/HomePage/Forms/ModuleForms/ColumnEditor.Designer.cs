

using System.Windows.Forms;
using FontAwesome.Sharp;

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
            if (disposing)
            {
                components?.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnEditor));
            this.LvColumns = new HomePage.CustomControls.DataListView();
            this.ChName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChOptions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TbColumnName = new System.Windows.Forms.TextBox();
            this.LbAnswers = new System.Windows.Forms.ListBox();
            this.answerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnAddAnswer = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDeleteAnswer = new System.Windows.Forms.ToolStripMenuItem();
            this.TbAnswer = new System.Windows.Forms.TextBox();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnUpdate = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ButtonAddAnswer = new System.Windows.Forms.Button();
            this.answerContextMenuStrip.SuspendLayout();
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
            this.LvColumns.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LvColumns.FullRowSelect = true;
            this.LvColumns.HideSelection = false;
            this.LvColumns.Location = new System.Drawing.Point(12, 46);
            this.LvColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LvColumns.MultiSelect = false;
            this.LvColumns.Name = "LvColumns";
            this.LvColumns.Size = new System.Drawing.Size(328, 367);
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
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sütun Adı:";
            // 
            // TbColumnName
            // 
            this.TbColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbColumnName.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbColumnName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TbColumnName.Location = new System.Drawing.Point(78, 21);
            this.TbColumnName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbColumnName.Name = "TbColumnName";
            this.TbColumnName.Size = new System.Drawing.Size(190, 27);
            this.TbColumnName.TabIndex = 0;
            // 
            // LbAnswers
            // 
            this.LbAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbAnswers.ContextMenuStrip = this.answerContextMenuStrip;
            this.LbAnswers.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbAnswers.FormattingEnabled = true;
            this.LbAnswers.ItemHeight = 20;
            this.LbAnswers.Location = new System.Drawing.Point(78, 103);
            this.LbAnswers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LbAnswers.Name = "LbAnswers";
            this.LbAnswers.Size = new System.Drawing.Size(190, 184);
            this.LbAnswers.TabIndex = 3;
            // 
            // answerContextMenuStrip
            // 
            this.answerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddAnswer,
            this.BtnDeleteAnswer});
            this.answerContextMenuStrip.Name = "answerContextMenuStrip";
            this.answerContextMenuStrip.Size = new System.Drawing.Size(132, 48);
            this.answerContextMenuStrip.Text = "answerContextMenuStrip";
            // 
            // BtnAddAnswer
            // 
            this.BtnAddAnswer.Name = "BtnAddAnswer";
            this.BtnAddAnswer.Size = new System.Drawing.Size(131, 22);
            this.BtnAddAnswer.Text = "Cevap Ekle";
            this.BtnAddAnswer.Click += new System.EventHandler(this.BtnAddAnswer_Click);
            // 
            // BtnDeleteAnswer
            // 
            this.BtnDeleteAnswer.Name = "BtnDeleteAnswer";
            this.BtnDeleteAnswer.Size = new System.Drawing.Size(131, 22);
            this.BtnDeleteAnswer.Text = "Cevap Sil";
            this.BtnDeleteAnswer.Click += new System.EventHandler(this.BtnDeleteAnswer_Click);
            // 
            // TbAnswer
            // 
            this.TbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAnswer.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TbAnswer.Location = new System.Drawing.Point(78, 62);
            this.TbAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbAnswer.Name = "TbAnswer";
            this.TbAnswer.Size = new System.Drawing.Size(190, 27);
            this.TbAnswer.TabIndex = 1;
            this.TbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAnswer_KeyDown);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAdd.Font = new System.Drawing.Font("Titillium Web", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Green;
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAdd.IconColor = System.Drawing.Color.Green;
            this.BtnAdd.IconSize = 30;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAdd.Location = new System.Drawing.Point(78, 308);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Rotation = 0D;
            this.BtnAdd.Size = new System.Drawing.Size(190, 49);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Sütun Ekle";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnUpdate.Font = new System.Drawing.Font("Titillium Web", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.DarkCyan;
            this.BtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnUpdate.IconColor = System.Drawing.Color.DarkCyan;
            this.BtnUpdate.IconSize = 32;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(90, 421);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Rotation = 0D;
            this.BtnUpdate.Size = new System.Drawing.Size(132, 38);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDelete.Font = new System.Drawing.Font("Titillium Web", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnDelete.IconColor = System.Drawing.Color.Red;
            this.BtnDelete.IconSize = 32;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnDelete.Location = new System.Drawing.Point(228, 421);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Rotation = 0D;
            this.BtnDelete.Size = new System.Drawing.Size(84, 38);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cevap Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonAddAnswer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbColumnName);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.LbAnswers);
            this.groupBox1.Controls.Add(this.TbAnswer);
            this.groupBox1.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(356, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(372, 367);
            this.groupBox1.TabIndex = 3;
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
            this.btnExit.Location = new System.Drawing.Point(723, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ButtonAddAnswer
            // 
            this.ButtonAddAnswer.BackColor = System.Drawing.Color.ForestGreen;
            this.ButtonAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddAnswer.Font = new System.Drawing.Font("Titillium Web", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAddAnswer.ForeColor = System.Drawing.Color.White;
            this.ButtonAddAnswer.Location = new System.Drawing.Point(274, 59);
            this.ButtonAddAnswer.Name = "ButtonAddAnswer";
            this.ButtonAddAnswer.Size = new System.Drawing.Size(92, 32);
            this.ButtonAddAnswer.TabIndex = 12;
            this.ButtonAddAnswer.Text = "Ekle";
            this.ButtonAddAnswer.UseVisualStyleBackColor = false;
            this.ButtonAddAnswer.Click += new System.EventHandler(this.BtnAddAnswer_Click);
            // 
            // ColumnEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(753, 484);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LvColumns);
            this.Font = new System.Drawing.Font("Titillium Web", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(675, 484);
            this.Name = "ColumnEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sütun Editörü";
            this.Load += new System.EventHandler(this.ColumnEditor_Load);
            this.answerContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.DataListView LvColumns;
        private Label label1;
        private TextBox TbColumnName;
        private ListBox LbAnswers;
        private TextBox TbAnswer;
        private IconButton BtnAdd;
        private Label label2;
        private ColumnHeader ChName;
        private ColumnHeader ChOptions;
        private GroupBox groupBox1;
        private Button btnExit;
        private ContextMenuStrip answerContextMenuStrip;
        private ToolStripMenuItem BtnAddAnswer;
        private ToolStripMenuItem BtnDeleteAnswer;
        private IconButton BtnUpdate;
        private IconButton BtnDelete;
        private Button ButtonAddAnswer;
    }
}