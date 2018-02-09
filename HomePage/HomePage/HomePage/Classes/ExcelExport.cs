using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.Classes
{
    class ExcelExport
    {
        private Microsoft.Office.Interop.Excel._Application _excel = new Microsoft.Office.Interop.Excel.Application();
        private Microsoft.Office.Interop.Excel._Worksheet _worksheet;
        private Microsoft.Office.Interop.Excel._Workbook _workbook;


        public ExcelExport()
        {
            _workbook = _excel.Workbooks.Add(Type.Missing);
        }

        public async void Export(DataGridView dataGridView)
        {
            try
            {

                _worksheet = _workbook.ActiveSheet;

                _worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                await CreateIndecies(dataGridView, ref cellRowIndex, ref cellColumnIndex);

                //Getting the location and file name of the excel to save from user.
                var saveDialog =
                    new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                        FilterIndex = 2
                    };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    _workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _excel.Quit();
                _workbook = null;
                _excel = null;
            }
        }

        private async Task<Tuple<int cellRowIndex,int cellColumnIndex>> CreateIndecies(DataGridView dataGridView, int cellRowIndex, int cellColumnIndex)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                    if (cellRowIndex == 1)
                    {
                        _worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView.Columns[j].HeaderText;
                    }
                    else
                    {
                        _worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    cellColumnIndex++;
                }
                cellColumnIndex = 1;
                cellRowIndex++;
            }
            return (cel);
        }
    }
}
