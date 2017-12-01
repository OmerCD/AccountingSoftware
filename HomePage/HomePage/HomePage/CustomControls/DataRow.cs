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
using System.Collections;

namespace HomePage.CustomControls
{
    public partial class DataRow
    {
        public DataRow()
        {
            InitializeComponent();
        }
        public int _lastY = 0;
        public DataGridViewRow CreateRow<T>(T entity) where T : DbObject
        {
            DataGridViewRow row = new DataGridViewRow();

            var properties = typeof(T).GetProperties();
            //row.CreateCells(_dataGridView);
            foreach (var property in properties)
            {




                var propertyType = property.PropertyType;
                var attributes = property.GetCustomAttributes(true);
                var value = property.GetValue(entity);
                if (attributes.Length > 0)
                {
                    CustomAttribute attribute = (CustomAttribute)attributes[0];

                    if (propertyType == typeof(String))
                    {
                        var cell = new DataGridViewTextBoxCell();
                        if (value == null)
                        {
                            cell.Value = "---";
                        }
                        else
                            cell.Value = value.ToString();
                        row.Cells.Add(cell);
                    }
                    else if (propertyType == typeof(DateTime))
                    {
                        var cell = new DataGridViewTextBoxCell();
                        if (value == null)
                        {
                            cell.Value = "---";
                        }
                        else
                            cell.Value = ((DateTime)value).ToShortDateString();
                        row.Cells.Add(cell);
                    }
                    else if (propertyType.IsEnum == true)
                    {
                        var cell = new DataGridViewComboBoxCell();
                        cell.DataSource = (Enum.GetValues(propertyType));
                        cell.FlatStyle = FlatStyle.Flat;
                        cell.Value = value;
                        row.Cells.Add(cell);
                    }
                    else if (propertyType == typeof(bool))
                    {
                        var cell = new DataGridViewCheckBoxCell();
                        cell.Value = (bool)value;
                        row.Cells.Add(cell);
                    }
                    else if (propertyType.IsSubclassOf(typeof(DbObject)))
                    {
                        var cell = new DataGridViewTextBoxCell();
                        var nameProperty = propertyType.GetProperty("Name");
                        var x = nameProperty.GetValue(value);
                        if (x != null)
                        {
                            cell.Value = x;
                        }
                        else
                        {
                            cell.Value = "---";
                        }
                        row.Cells.Add(cell);
                    }
                    else if (propertyType.IsArray )
                    {
                        var className = propertyType.Name.Substring(0, propertyType.Name.Length - 2);
                        var tempType = Type.GetType(propertyType.Namespace+"."+className);
                        if (tempType.IsSubclassOf(typeof(DbObject)))
                        {
                            var What = Activator.CreateInstance(typeof(List<>).MakeGenericType(tempType));
                            IList collection = (IList)value;
                            string names = "";
                            foreach (var item in collection)
                            {
                                
                                var itemType = item.GetType();
                                var itemTypeName = itemType.GetProperty("Name");
                                names += itemTypeName.GetValue(item) + "\n";
                                
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

