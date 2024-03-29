﻿using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using HomePage.Classes.Database.Cruds;
using HomePage.CustomControls;
using HomePage.Document;

namespace HomePage.Forms.ModuleForms
{
    public partial class ColumnEditor : NoBorderForm
    {
        private readonly ColumnCRUD _columnCrud;
        public ColumnEditor()
        {
            InitializeComponent();
            _columnCrud = new ColumnCRUD();
            cCaption = 32;
        }

        private void RefreshColumnList()
        {
            LvColumns.ClearItems();
            var columns = _columnCrud.GetAll(null);
            foreach (var column in columns)
            {
                var answers = column.PossibleAnswers.Aggregate("", (current, answer) => current + (answer + ','));
                answers = answers.Substring(0, answers.Length - 1);
                var row = new ListViewItem(new[] { column.Name, answers });
                LvColumns.AddRow(row, column._id);
            }
            ClearColumnPropertyFields();
        }
        private void ColumnEditor_Load(object sender, EventArgs e)
        {
            RefreshColumnList();
        }
        private void LvColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvColumns.SelectedId != "")
            {
                var column = _columnCrud.GetOne(LvColumns.SelectedId);
                TbColumnName.Text = column.Name;
                LbAnswers.Items.Clear();
                LbAnswers.Items.AddRange(column.PossibleAnswers);
            }
        }
        string[] ItemsToStringArray(IList items)
        {

            var sArray = new string[items.Count];
            for (int i = 0; i < sArray.Length; i++)
            {
                sArray[i] = items[i].ToString();
            }
            return sArray;
        }

        private void ClearColumnPropertyFields()
        {
            TbColumnName.Text = TbAnswer.Text = "";
            LbAnswers.Items.Clear();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ColumnCheck())
            {
                if (LbAnswers.Items.Count > 1)
                {
                    var column = new Column
                    {
                        Name = TbColumnName.Text,
                        PossibleAnswers = ItemsToStringArray(LbAnswers.Items)
                    };
                    _columnCrud.Insert(column);
                    RefreshColumnList();
                }
                else
                {
                    MessageBox.Show("Bir sütun için en az 2 adet cevap eklenmesi gerekmektedir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            AddAnswer();
        }

        private void AddAnswer()
        {
            if (TbAnswer.TextLength > 2)
            {
                LbAnswers.Items.Add(TbAnswer.Text);
                TbAnswer.Text = "";
            }
            else
            {
                MessageBox.Show("Cevap 3 karakterden kısa olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (LbAnswers.SelectedIndex != -1)
            {
                LbAnswers.Items.RemoveAt(LbAnswers.SelectedIndex);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (LvColumns.SelectedIndices.Count > 0)
            {
                var column = _columnCrud.GetOne(LvColumns.SelectedId);
                column.Name = TbColumnName.Text;
                column.PossibleAnswers = ItemsToStringArray(LbAnswers.Items);
                _columnCrud.Update(column._id, column);
                RefreshColumnList();
            }
            else
            {
                MessageBox.Show("Herhangi bir veri seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ColumnCheck()
        {
            if (TbColumnName.TextLength > 2)
            {
                if (!_columnCrud.NameCheck(TbColumnName.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Aynı isimle başka bir sütun bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Sütun adı 2 karakterden kısa olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LvColumns.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Bu sütunu silmek istediğinizden emin misiniz?.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (_columnCrud.Delete(LvColumns.SelectedId))
                    {
                        RefreshColumnList();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Herhangi bir veri seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                AddAnswer();
            }
        }
    }
}
