using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes;
using System.Collections;
using System.Reflection;
using HomePage.Classes.Database.Entities;
using HomePage.Classes.Database;

namespace HomePage.CustomControls
{
    public partial class Container : UserControl
    {
        private object _object;
        private Dictionary<string, IMainCustomControl> _valueControls = new Dictionary<string, IMainCustomControl>();

        public string ButtonText
        {
            set => ContainerButton.Text = value;
        }

        public delegate void ButtonClickEvent(object sender, EventArgs e);
        public ButtonClickEvent ClickEvent { get; set; }
        public object CRUD { get; set; }


        public object Object
        {
            set
            {
                _object = value;
                CreateControls();
            }
            get
            {
                _object = GetValues();
                return _object;
            }
        }

        private object GetValues()
        {
            var props = _object.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.CustomAttributes.Any())
                {
                    var value = _valueControls[prop.Name].Value;
                    var propType = prop.PropertyType;
                    if (propType.IsSubclassOf(typeof(DbObject)))
                    {
                        var foreignObject = GetField(prop,
                            ((LabelAndCombobox)_valueControls[prop.Name]).GetSelectedId);
                        prop.SetValue(_object, foreignObject);
                    }
                    else if (propType.IsEnum)
                    {
                        var cBox = (LabelAndCombobox)_valueControls[prop.Name];
                        prop.SetValue(_object, cBox.SelectedIndex);
                    }
                    else
                    {
                        prop.SetValue(_object, value);
                    }
                }
            }
            return _object;
        }

        private object GetField(PropertyInfo prop, string getSelectedId)
        {
            var type = prop.PropertyType;

            var genericCRUD = MainPage.GetCRUD(type);
            return genericCRUD.GetOne(getSelectedId);
        }

        private void CreateControls()
        {
            var properties = _object.GetType().GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(true);
                var propertyType = property.PropertyType;
                if (attributes.Length > 0)
                {
                    var attribute = (CustomAttribute)attributes[0];

                    if (propertyType == typeof(string))
                    {
                        var value = property.GetValue(_object);
                        var fill = value!=null;
                        var text = value?.ToString();
                        if (!fill && !string.IsNullOrEmpty(attribute.PlaceHolderText))
                        {
                            text = attribute.PlaceHolderText;
                        }
                        var lat =
                            new LabelAndTextbox(attribute,fill)
                            {
                                LatTextBox = { Text =  text}
                            };
                        Add(lat, property.Name);
                    }
                    else if (propertyType == typeof(DateTime))
                    {
                        var lad =
                            new LabelAndDatePicker(attribute) { Value = (DateTime)property.GetValue(_object) };
                        Add(lad, property.Name);
                    }
                    else if (propertyType.IsEnum)
                    {
                        var enumValues = Enum.GetValues(propertyType);
                        var cb = new LabelAndCombobox(attribute, (from object enumValue in enumValues select enumValue).ToArray());
                        var enumIndex = (int)property.GetValue(_object);
                        cb.ComboBox.SelectedIndex = enumIndex;
                        Add(cb, property.Name);
                    }
                    else if (propertyType == typeof(bool))
                    {
                        var cb = new LabelAndCheckBox(attribute.FieldName);
                        var tick = (bool)property.GetValue(_object);
                        cb.LacCheckBox.Checked = tick;
                        Add(cb, property.Name);
                    }
                    else if (propertyType.IsSubclassOf(typeof(DbObject)))
                    {
                        var cb = new LabelAndCombobox(attribute);
                        var instanceCRUD = MainPage.GetCRUD(propertyType);

                        Dictionary<string, string> result = instanceCRUD.GetNameList();
                        var index = 0;

                        if (result != null)
                        {
                            dynamic valueOfProperty = property.GetValue(_object);
                            string name = valueOfProperty.Name;
                            var nameChecked = false;
                            foreach (var pair in result)
                            {
                                if (nameChecked == false && name != pair.Key)
                                {
                                    index++;

                                }
                                else
                                {
                                    nameChecked = true;
                                }
                                cb.Add(pair.Key, pair.Value);
                            }
                            cb.ComboBox.SelectedIndex = index;
                        }
                        Add(cb, property.Name);
                        cb.ComboBox.SelectedIndex = index;
                    }

                    else if (propertyType.IsArray)
                    {
                        var className = propertyType.Name.Substring(0, propertyType.Name.Length - 2);
                        var tempType = Type.GetType(propertyType.Namespace + "." + className);
                        if (tempType != null && tempType.IsSubclassOf(typeof(DbObject)))
                        {
                            var cb = new LabelAndCombobox(attribute);
                            var genericType = typeof(CRUD<>).MakeGenericType(tempType);
                            dynamic instanceCRUD = Activator.CreateInstance(genericType);
                            Dictionary<string, string> result = instanceCRUD.GetNameList();
                            var index = 0;
                            if (result != null)
                            {
                                dynamic valueOfProperty = property.GetValue(_object); // todo: Control to show arrays
                                string name = valueOfProperty?.Name ?? "";
                                var nameChecked = false;
                                foreach (var pair in result)
                                {
                                    if (nameChecked == false && name != pair.Key)
                                    {
                                        index++;

                                    }
                                    else
                                    {
                                        nameChecked = true;
                                    }
                                    cb.Add(pair.Key, pair.Value);
                                }
                                if (name == "") cb.SelectBase();
                                else cb.ComboBox.SelectedIndex = index;
                            }
                            Add(cb, property.Name);
                        }
                    }
                }

            }
            ContainerButton.Visible = true;
            LocateButton();

        }
        public Container()
        {
            InitializeComponent();

        }
        private int _lastY;

        private void Add(Control userControl, string propertyName)
        {
            _valueControls.Add(propertyName, (IMainCustomControl)userControl);
            userControl.Location = new Point(userControl.Location.X, _lastY);
            this.Controls.Add(userControl);
            _lastY += userControl.Size.Height + 10;
        }

        private void LocateButton()
        {
            this.Size = new Size(this.Width + 120, this.Height + ContainerButton.Height + 120);
            this.ContainerButton.Location = new Point(this.ContainerButton.Location.X - 40, this._lastY - 70);
        }

        private void ContainerButton_Click(object sender, EventArgs e)
        {
            var error = false;
            foreach (var controlPair in _valueControls)
            {
                var control = controlPair.Value;
                if (!control.IsValidated())
                {
                    error = true;
                }
            }
            if (!error)
            {
                ClickEvent(sender, e);
            }
        }
    }
}