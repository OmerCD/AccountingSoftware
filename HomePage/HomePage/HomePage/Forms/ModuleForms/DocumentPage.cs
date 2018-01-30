using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HomePage.Document;
using HomePage.Classes.Database;
using HomePage.Classes.Database.Cruds;
using HomePage.Classes.Database.Entities;
using HomePage.Classes.Database.Enums;

namespace HomePage.Forms.ModuleForms
{
    public partial class DocumentPage : Form
    {
        private const int EXTRA_COLUMN_COUNT = 4;
        private readonly CRUD<Column> _columnCrud;
        private readonly CRUD<Company> _companyCrud;
        private readonly CompanyColumnIndexCRUD _companyColumnIndexCrud;
        public DocumentPage()
        {
            InitializeComponent();
            _companyCrud = new CRUD<Company>();
            _columnCrud = new CRUD<Column>();
            _companyColumnIndexCrud = new CompanyColumnIndexCRUD();
        }

        private void ApplyChanges()
        {
            Company FindCompany(IEnumerable<Company> companyList, string id)
            {
                return companyList.FirstOrDefault(company => company._id == id);
            }
            var companies = _companyCrud.GetAll();
            var columns = _columnCrud.GetAll();
            _companyColumnIndexCrud.ClearColection();
            for (var i = 0; i < DgvDocuments.Rows.Count; i++)
            {
                var row = DgvDocuments.Rows[i];
                var id = row.Cells[0].Value.ToString();
                var company = FindCompany(companies, id);
                if (company != null)
                {
                    CreateCollectionDatabase(columns, row, company);
                }
            }
            InsertLog($"{MainPage.CurrentUser.Name} adlı kişi Dökumanları değiştirdi");
        }
        /// <summary>
        /// Inserts AnswerIndicies to the database based on given parameters.
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="row"></param>
        /// <param name="company"></param>
        private void CreateCollectionDatabase(List<Column> columns, DataGridViewRow row, Company company)
        {
            for (var j = EXTRA_COLUMN_COUNT; j < DgvDocuments.ColumnCount; j++)
            {
                var column = columns[j - EXTRA_COLUMN_COUNT];
                var answer = ((DataGridViewComboBoxCell)row.Cells[j]).Value?.ToString();
                if (answer == null)
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

        private void InsertLog(string actionText)
        {
            var log = new Log(actionText, this.GetType().Name);
            var logCRUD = new CRUD<Log>();
            logCRUD.Insert(log);
        }
        private void DocumentPage_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DgvDocuments.Columns.Clear();
            var columns = _columnCrud.GetAll();
            var companies = _companyCrud.GetAll();
            int CheckIfTupleExists(IReadOnlyList<Tuple<string, int>> tupleList, string id)
            {
                for (var i = 0; i < tupleList.Count; i++)
                {
                    if (tupleList[i].Item1 == id)
                    {
                        return i;
                    }
                }
                return -1;
            }
            AssignConstantFields(columns.Count);
            CreateColumnsOfDataGridView(columns);
            DgvDocuments.Rows.Add();
            foreach (var company in companies)
            {
                var row = (DataGridViewRow)DgvDocuments.Rows[0].Clone();
                row.Cells[0].Value = company._id;
                row.Cells[1].Value = company.Name;
                var indecies = _companyColumnIndexCrud.GetCompanyAnswerIndexes(company);
                for (var j = EXTRA_COLUMN_COUNT; j < columns.Count + EXTRA_COLUMN_COUNT; j++)
                {
                    var column = columns[j - EXTRA_COLUMN_COUNT];
                    var comboBox = new DataGridViewComboBoxCell { DataSource = column.PossibleAnswers, FlatStyle = FlatStyle.Flat };
                    var tupleIndex = CheckIfTupleExists(indecies, column._id);
                    if (tupleIndex != -1)
                        comboBox.Value = column.PossibleAnswers[indecies[tupleIndex].Item2];
                    row.Cells[j] = comboBox;
                }
                DgvDocuments.Rows.Add(row);
            }
            DgvDocuments.Rows.RemoveAt(0);
        }

        private void CreateColumnsOfDataGridView(IReadOnlyList<Column> columns)
        {
            for (var i = EXTRA_COLUMN_COUNT; i < columns.Count + EXTRA_COLUMN_COUNT; i++)
            {
                var index = i - EXTRA_COLUMN_COUNT;
                DgvDocuments.Columns[i].Name = columns[index].Name;
            }
        }

        private void AssignConstantFields(int columnCount)
        {
            DgvDocuments.ColumnCount = columnCount + EXTRA_COLUMN_COUNT;
            DgvDocuments.Columns[0].Name = "Id";
            DgvDocuments.Columns[0].Visible = false;

            DgvDocuments.Columns[1].Name = "Şirketler";
            DgvDocuments.Columns[1].ReadOnly = true;

            DgvDocuments.Columns[2].Name = "Son Düzenleyen";
            DgvDocuments.Columns[2].ReadOnly = true;
            if (MainPage.CurrentUser.UserType != UserTypes.Yönetici)
                DgvDocuments.Columns[2].Visible = false;

            DgvDocuments.Columns[3].Name = "Son Düzenleme Tarihi";
            DgvDocuments.Columns[3].ReadOnly = true;
            //todo Assign right variables to the columns

            DgvDocuments.Columns[2].Visible = false;
            DgvDocuments.Columns[3].Visible = false;
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

                RefreshDataGridView();

            }
        }
    }
}
