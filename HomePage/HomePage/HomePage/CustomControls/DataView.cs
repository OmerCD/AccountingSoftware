using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;
using HomePage.Classes;

namespace HomePage.CustomControls
{
    public partial class DataView : DataGridView
    {
        List<string> _ids = new List<string>();
        public DataView()
        {
            InitializeComponent();
            this.MultiSelect = false;
        }
        public int Add(DataGridViewRow row,string id)
        {
            _ids.Add(id);
            return this.Rows.Add(row);
        }
        public string SelectedId
        { get
            {
                if (SelectedCells.Count>0)
                {
                    int index = SelectedCells[0].RowIndex;
                    return _ids[index];
                }
                else
                {
                    return null;
                }
             
            }
        }
        public void Init<T>() where T : Classes.Database.Entities.DbObject, new()
        {
            _ids = new List<string>();
            this.Columns.Clear();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(true);
                if (attributes.Length != 0)
                {
                    CustomAttribute attribute = (CustomAttribute)attributes?[0];
                    if (attribute != null)
                    {
                        Columns.Add(property.Name, attribute.FieldName);
                    }
                }
            }
       
        }
    }
}
