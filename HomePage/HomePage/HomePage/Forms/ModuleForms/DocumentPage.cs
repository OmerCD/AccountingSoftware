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
using HomePage.Classes.Database.Entities;

namespace HomePage.Forms.ModuleForms
{
    public partial class DocumentPage : Form
    {
        private CRUD<Column> _columnCrud;
        private CRUD<Company> _companyCrud;
        private CRUD<CompanyColumnIndex> _companyColumnIndexCrud;
        public DocumentPage()
        {
            InitializeComponent();
            _companyCrud= new CRUD<Company>();
            _columnCrud= new CRUD<Column>();
        }

        private void DocumentPage_Load(object sender, EventArgs e)
        {
            var columns = _columnCrud.GetAll();
            var companies = _companyCrud.GetAll();
            DgvDocuments.ColumnCount = columns.Count+1;
            DgvDocuments.Columns[0].Name = "Şirketler";
            for (int i = 1; i < columns.Count+1; i++)
            {
                DgvDocuments.Columns[i].Name = columns[i-1].Name;
            }
            for (int i = 0; i < companies.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)DgvDocuments.Rows[0].Clone();
                row.Cells[0].Value = companies[i].Name;
                for (int j = 1; j < columns.Count; j++)
                {
                    DataGridViewComboBoxCell comboBox =
                        new DataGridViewComboBoxCell {DataSource = columns[j].PossibleAnswers};
                    row.Cells[j] = comboBox;
                }
                DgvDocuments.Rows.Add(row);
            }
        }
    }
}
