﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database.Cruds;
using HomePage.Document;

namespace HomePage.Forms.ModuleForms
{
    public partial class ColumnEditor : Form
    {
        private readonly ColumnCRUD _columnCrud;
        public ColumnEditor()
        {
            InitializeComponent();
            _columnCrud = new ColumnCRUD();
        }

        private void RefreshColumnList()
        {
            LvColumns.ClearItems();
            var columns = _columnCrud.GetAll(null);
            foreach (var column in columns)
            {
                var answers = column.PossibleAnswers.Aggregate("", (current, answer) => current + (answer + '|'));
                var row = new ListViewItem(new[] { column.Name, answers });
                LvColumns.AddRow(row, column._id);
            }
        }
        private void ColumnEditor_Load(object sender, EventArgs e)
        {
            RefreshColumnList();
        }

        private void LbAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            }
        }

        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            if (TbAnswer.TextLength > 2)
            {
                LbAnswers.Items.Add(TbAnswer.Text);
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
                //todo
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
                    //todo
                    return false;
                }
            }
            else
            {
                //todo
                return false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LvColumns.SelectedIndices.Count > 0)
            {
                if (_columnCrud.Delete(LvColumns.SelectedId))
                {
                    RefreshColumnList();
                }
            }
            else
            {
                //todo
            }
        }
    }
}