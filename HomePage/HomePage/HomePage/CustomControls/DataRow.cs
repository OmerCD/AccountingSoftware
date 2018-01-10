using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;
using System.Collections;

namespace HomePage.CustomControls
{
    public partial class DataRow
    {
        public DataRow()
        {
            InitializeComponent();
        }

        public DataGridViewRow CreateRow<T>(T entity) where T : DbObject
        {
            DataGridViewRow row = new DataGridViewRow();

            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;
                var attributes = property.GetCustomAttributes(true);
                var value = property.GetValue(entity);
               
                if (attributes.Length > 0)
                {
                    if (value == null)
                    {
                        var cell = new DataGridViewTextBoxCell {Value = "---"};
                        row.Cells.Add(cell);
                        continue;
                    }

                    if (propertyType == typeof(string))
                    {
                        var cell = new DataGridViewTextBoxCell {Value = value.ToString()};
                        row.Cells.Add(cell);
                    }
                    else if (propertyType == typeof(DateTime))
                    {
                        var cell = new DataGridViewTextBoxCell {Value = ((DateTime) value).ToShortDateString()};
                        row.Cells.Add(cell);
                    }
                    else if (propertyType.IsEnum)
                    {
                        var cell = new DataGridViewComboBoxCell
                        {
                            DataSource = (Enum.GetValues(propertyType)),
                            FlatStyle = FlatStyle.Flat,
                            Value = value
                        };
                        row.Cells.Add(cell);
                    }
                    else if (propertyType == typeof(bool))
                    {
                        var cell = new DataGridViewCheckBoxCell {Value = (bool) value};
                        row.Cells.Add(cell);
                    }
                    else if (propertyType.IsSubclassOf(typeof(DbObject)))
                    {
                        var cell = new DataGridViewTextBoxCell();
                        var nameProperty = propertyType.GetProperty("Name");
                        var x = nameProperty?.GetValue(value);
                        cell.Value = x ?? "---";
                        row.Cells.Add(cell);
                    }
                    else if (propertyType.IsArray ) //todo for managing DbObject Array
                    {
                        var className = propertyType.Name.Substring(0, propertyType.Name.Length - 2);
                        var tempType = Type.GetType(propertyType.Namespace+"."+className);
                        if (tempType.IsSubclassOf(typeof(DbObject)))
                        {
                            Activator.CreateInstance(typeof(List<>).MakeGenericType(tempType));
                            IList collection = (IList)value;
                            string names = "";
                            foreach (var item in collection)
                            {
                                
                                var itemType = item.GetType();
                                var itemTypeName = itemType.GetProperty("Name");
                                names += itemTypeName?.GetValue(item) + "\n";
                                
                            }
                            var cell = new DataGridViewTextBoxCell();
                            names = names.Substring(0, names.Length - 1);
                            cell.Value = names;
                            row.Cells.Add(cell);
                        }
                       
                    }

                }


            }
            return row;
        }

    }


}

