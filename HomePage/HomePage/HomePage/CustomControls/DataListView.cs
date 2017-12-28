using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.CustomControls
{
    public partial class DataListView : ListView
    {
        private List<string> _idList;
        public DataListView()
        {
            InitializeComponent();
            _idList = new List<string>();
        }

        public void AddRow(ListViewItem row, string id)
        {
            _idList.Add(id);
            Items.Add(row);
        }

        public void ClearItems()
        {
            Items.Clear();
            _idList.Clear();
        }

        public void RemoveRow(int index)
        {
            _idList.RemoveAt(index);
            Items.RemoveAt(index);
        }

        public string SelectedId => SelectedIndices.Count > 0 ? _idList[SelectedIndices[0]] : "";
    }
}
