using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HomePage.Classes;
using System.Reflection;
using HomePage.Classes.Database.Entities;
using HomePage.Classes.Database;
using HomePage.CustomControls.MVC;

namespace HomePage.CustomControls
{
    public partial class Container : UserControl
    {
        /// <summary>
        /// Object that this container will try to create the view for.
        /// </summary>
        private object _object;
        /// <summary>
        /// This Dictionary keeps track of the controls added for assignment of the properties, that controls created from.
        /// </summary>
        private readonly Dictionary<string, IMainCustomControl> _valueControls = new Dictionary<string, IMainCustomControl>();

        /// <summary>
        /// This property will set the Text on the single button in this container.
        /// </summary>
        public string ButtonText
        {
            set => ContainerButton.Text = value;
        }
        /// <summary>
        /// This event will be triggerd when user clicks on the Button of this Container.
        /// </summary>
        public event Action<object,EventArgs> ButtonClickEvent;

        /// <summary>
        /// It will return the desired object or set up the Form based on desired object.
        /// </summary>
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
        /// <summary>
        /// It will assign entered values to the right properties of given object.
        /// </summary>
        /// <returns></returns>
        private object GetValues()
        {
            var props = _object.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.CustomAttributes.Any())
                {
                    var value = _valueControls[prop.Name].Value;
                    SetPropertyValue(prop, value);
                }
            }
            return _object;
        }

        private void SetPropertyValue(PropertyInfo prop, object value)
        {
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
                if (attributes.Length > 0)
                {
                    var attribute = (CustomAttribute)attributes[0];

                    AddControl(property, attribute);
                }

            }
            ContainerButton.Visible = true;
            LocateButton();

        }
        /// <summary>
        /// Based on given parameters this method tries to create best suiting control for the given property which must have a CustomAttribute.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="attribute"></param>
        private void AddControl(PropertyInfo property,CustomAttribute attribute)
        {
            var propertyType = property.PropertyType;
            if (propertyType == typeof(string))
            {
                var value = property.GetValue(_object);
                var fill = value != null;
                var text = value?.ToString();
                if (!fill && !string.IsNullOrEmpty(attribute.PlaceHolderText))
                {
                    text = attribute.PlaceHolderText;
                }
                var lat =
                    new LabelAndTextbox(attribute, fill)
                    {
                        LatTextBox = { Text = text }
                    };
                Add(lat, property.Name);
            }
            else if (propertyType == typeof(DateTime))
            {
                var lad =
                    new LabelAndDatePicker(attribute) { DateValue = (DateTime)property.GetValue(_object) };
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
                    string name = valueOfProperty?.Name;
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
                }
                Add(cb, property.Name);
                if (index < result.Count)
                    cb.ComboBox.SelectedIndex = index;
            }

            else if (propertyType.IsArray)
            {
                var className = propertyType.Name.Substring(0, propertyType.Name.Length - 2);
                var tempType = Type.GetType(propertyType.Namespace + "." + className);
                if (tempType != null)
                {
                    if (tempType.IsSubclassOf(typeof(DbObject)))
                    {
                        var cb = new LabelAndCombobox(attribute);
                        var genericType = typeof(CRUD<>).MakeGenericType(tempType);
                        dynamic instanceCRUD = Activator.CreateInstance(genericType);
                        Dictionary<string, string> result = instanceCRUD.GetNameList();
                        var index = 0;
                        if (result != null)
                        {
                            dynamic valueOfProperty = property.GetValue(_object); // todo: Control to show arrays
                            foreach (var element in valueOfProperty)
                            {
                                string name = element?.Name ?? "";
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
                                else if (index < result.Count) cb.ComboBox.SelectedIndex = index;
                            }

                        }
                        Add(cb, property.Name);
                    }
                    else
                    {
                        var value = property.GetValue(_object);
                        var cb = new LabelAndMultiTextBox(attribute,(string[])value);
                        Add(cb,property.Name);
                    }
                }
            }
        }

        public Container()
        {
            InitializeComponent();

        }
        private int _lastY;

        private void Add(Control userControl, string propertyName)
        {
            _valueControls.Add(propertyName, (IMainCustomControl)userControl);
            userControl.Location = new Point(userControl.Location.X+30, _lastY);
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
                ButtonClickEvent?.Invoke(sender, e);
            }
        }
    }
}