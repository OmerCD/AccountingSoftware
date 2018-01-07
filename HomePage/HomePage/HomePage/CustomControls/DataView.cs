using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;
using HomePage.Classes;

namespace HomePage.CustomControls
{
    public partial class DataView : DataGridView
    {
        private List<string> _ids = new List<string>();
        public DataView()
        {
            InitializeComponent();
            this.MultiSelect = false;
        }
        public int Add(DataGridViewRow row, string id)
        {
            _ids.Add(id);
            return this.Rows.Add(row);
        }
        /// <summary>
        /// Returns selected items' id
        /// </summary>
        public string SelectedId
        {
            get
            {
                if (SelectedCells.Count > 0)
                {
                    int index = SelectedCells[0].RowIndex;
                    return _ids[index];
                }
                return null;
            }
        }
        /// <summary>
        /// Arranges columns based on properties which have Custom Attributes in given Type T 
        /// </summary>
        /// <typeparam name="T">Properties to extract from</typeparam>
        public void Init<T>() where T : DbObject, new()
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
        /// <summary>
        /// Arranges columns based on properties which have Custom Attributes in given Type
        /// </summary>
        /// <param name="type">Properties to extract from</param>
        public void Init(Type type)
        {
            _ids = new List<string>();
            this.Columns.Clear();
            var properties = type.GetProperties();
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
