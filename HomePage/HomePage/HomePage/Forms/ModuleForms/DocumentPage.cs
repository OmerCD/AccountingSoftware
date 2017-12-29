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
            for (int i = 0; i < DgvDocuments.Rows.Count; i++)
            {
                
            }
        }
        private void DocumentPage_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            int extraColumnCount = 2;
            var columns = _columnCrud.GetAll();
            var companies = _companyCrud.GetAll();
            DgvDocuments.ColumnCount = columns.Count + extraColumnCount;
            DgvDocuments.Columns[0].Name = "Id";
            DgvDocuments.Columns[0].Visible = false;
            DgvDocuments.Columns[1].Name = "Şirketler";
            DgvDocuments.Columns[1].ReadOnly = true;
            for (var i = extraColumnCount; i < columns.Count + extraColumnCount; i++)
            {
                DgvDocuments.Columns[i].Name = columns[i - extraColumnCount].Name;
            }
            DgvDocuments.Rows.Add();
            foreach (var company in companies)
            {
                DataGridViewRow row = (DataGridViewRow)DgvDocuments.Rows[0].Clone();
                row.Cells[0].Value = company._id;
                row.Cells[1].Value = company.Name;
                var indecies = _companyColumnIndexCrud.GetCompanyAnswerIndexes(company._id);

                for (var j = extraColumnCount; j < columns.Count + extraColumnCount; j++)
                {
                    var column = columns[j - extraColumnCount];
                    var comboBox = new DataGridViewComboBoxCell { DataSource = column.PossibleAnswers };
                    if (indecies.ContainsKey(column._id))
                        comboBox.Value = column.PossibleAnswers[indecies[column._id]];
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
