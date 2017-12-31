using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Document;
using HomePage.Classes.Database;
using HomePage.Classes.Database.Cruds;
using HomePage.Classes.Database.Entities;

namespace HomePage.Forms.ModuleForms
{
    public partial class DocumentPage : Form
    {
        private const int EXTRA_COLUMN_COUNT = 2;
        private CRUD<Column> _columnCrud;
        private CRUD<Company> _companyCrud;
        private CompanyColumnIndexCRUD _companyColumnIndexCrud;
        public DocumentPage()
        {
            InitializeComponent();
            _companyCrud = new CRUD<Company>();
            _columnCrud = new CRUD<Column>();
            _companyColumnIndexCrud = new CompanyColumnIndexCRUD();
        }

        private void ApplyChanges()
        {
            Company FindCompany(List<Company> companyList,string id)
            {
                return companyList.FirstOrDefault(company => company._id == id);
            }
            var companies = _companyCrud.GetAll();
            var columns = _columnCrud.GetAll();
            _companyColumnIndexCrud.ClearColection();
            for (int i = 0; i < DgvDocuments.Rows.Count; i++)
            {
                var row = DgvDocuments.Rows[i];
                var id = row.Cells[0].Value.ToString();
                var company = FindCompany(companies, id);
                if (company != null)
                {
                    for (int j = EXTRA_COLUMN_COUNT; j < DgvDocuments.ColumnCount; j++)
                    {
                        var column = columns[j - EXTRA_COLUMN_COUNT];
                        var answer = ((DataGridViewComboBoxCell) row.Cells[j]).Value?.ToString();
                        if (answer==null)
                        {
                            continue;
                        }
                        var answerIndex = Array.IndexOf(column.PossibleAnswers, answer);
                        var cCIndex = new CompanyColumnIndex
                        {
                            AnswerIndex = answerIndex,
                            Column = column,
                            Company = company,
                            EditDate = DateTime.Now,
                            User = MainPage.CurrentUser
                        };
                        _companyColumnIndexCrud.Insert(cCIndex);
                    }
                }
            }
        }
        private void DocumentPage_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            int CheckIfTupleExists(IReadOnlyList<Tuple<string, int>> tupleList, string id)
            {
                for (int i = 0; i < tupleList.Count; i++)
                {
                    if (tupleList[i].Item1==id)
                    {
                        return i;
                    }
                }
                return -1;
            }
            var columns = _columnCrud.GetAll();
            var companies = _companyCrud.GetAll();
            DgvDocuments.ColumnCount = columns.Count + EXTRA_COLUMN_COUNT;
            DgvDocuments.Columns[0].Name = "Id";
            DgvDocuments.Columns[0].Visible = false;
            DgvDocuments.Columns[1].Name = "Şirketler";
            DgvDocuments.Columns[1].ReadOnly = true;
            for (var i = EXTRA_COLUMN_COUNT; i < columns.Count + EXTRA_COLUMN_COUNT; i++)
            {
                DgvDocuments.Columns[i].Name = columns[i - EXTRA_COLUMN_COUNT].Name;
            }
            DgvDocuments.Rows.Add();
            foreach (var company in companies)
            {
                DataGridViewRow row = (DataGridViewRow)DgvDocuments.Rows[0].Clone();
                row.Cells[0].Value = company._id;
                row.Cells[1].Value = company.Name;
                var indecies = _companyColumnIndexCrud.GetCompanyAnswerIndexes(company);

                for (var j = EXTRA_COLUMN_COUNT; j < columns.Count + EXTRA_COLUMN_COUNT; j++)
                {
                    var column = columns[j - EXTRA_COLUMN_COUNT];
                    var comboBox = new DataGridViewComboBoxCell { DataSource = column.PossibleAnswers };
                    var tupleIndex = CheckIfTupleExists(indecies, column._id);
                    if (tupleIndex!=-1)
                        comboBox.Value = column.PossibleAnswers[indecies[tupleIndex].Item2];
                    row.Cells[j] = comboBox;
                }
                DgvDocuments.Rows.Add(row);
            }
            DgvDocuments.Rows.RemoveAt(0);
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        private void BtnColumnEditor_Click(object sender, EventArgs e)
        {
            using (var frm = new ColumnEditor())
            {
                frm.ShowDialog();
            }
        }
    }
}
