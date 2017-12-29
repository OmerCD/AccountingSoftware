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
                            ((LabelAndCombobox) _valueControls[prop.Name]).GetSelectedId);
                        prop.SetValue(_object, foreignObject);
                    }
                    else if (propType.IsEnum)
                    {
                        var cBox = (LabelAndCombobox) _valueControls[prop.Name];
                        prop.SetValue(_object,cBox.SelectedIndex);
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
            var genericType = typeof(CRUD<>).MakeGenericType(type);
            var genericCRUD = Activator.CreateInstance(genericType);
            var methodInfo = genericType.GetMethod("GetOne");
            var result = methodInfo.Invoke(genericCRUD, new object[] {getSelectedId});
            return result;
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
                    CustomAttribute attribute = (CustomAttribute)attributes[0];

                    if (propertyType == typeof(string))
                    {
                        LabelAndTextbox lat = new LabelAndTextbox(attribute);
                        Add(lat, property.Name);
                    }
                    else if (propertyType == typeof(DateTime))
                    {
                        LabelAndDatePicker lad = new LabelAndDatePicker(attribute);
                        Add(lad, property.Name);
                    }
                    else if (propertyType.IsEnum == true)
                    {
                        var enumValues = Enum.GetValues(propertyType);
                        List<string> values= new List<string>();
                        foreach (var enumValue in enumValues)
                        {
                            values.Add(enumValue.ToString());
                        }
                        LabelAndCombobox cb = new LabelAndCombobox(attribute, values.ToArray());
                        Add(cb, property.Name);
                    }
                    else if (propertyType == typeof(bool))
                    {
                        LabelAndCheckBox cb = new LabelAndCheckBox(attribute.FieldName);
                        Add(cb, property.Name);
                    }
                    else if (propertyType.IsSubclassOf(typeof(DbObject)))
                    {
                        LabelAndCombobox cb = new LabelAndCombobox(attribute);
                        var genericType = typeof(CRUD<>).MakeGenericType(propertyType);
                        var instanceCRUD = Activator.CreateInstance(genericType);

                        var method = genericType.GetMethod("GetNameList")?.MakeGenericMethod(propertyType);
                        var returnValue = method?.Invoke(instanceCRUD, null);
                        //var result = (Dictionary<string, string>) returnValue?.GetType().GetProperty("Result")?.GetValue(returnValue);
                        var result = (Dictionary<string, string>)returnValue;
                        if (result != null)
                            foreach (var pair in result)
                            {
                                cb.Add(pair.Key,pair.Value);
                            }
                        Add(cb, property.Name);
                        cb.SelectBase();
                    }

                    else if (propertyType.IsArray)
                    {
                        var className = propertyType.Name.Substring(0, propertyType.Name.Length - 2);
                        var tempType = Type.GetType(propertyType.Namespace + "." + className);
                        if (tempType != null && tempType.IsSubclassOf(typeof(DbObject)))
                        {
                            LabelAndCombobox cb = new LabelAndCombobox(attribute);
                            var genericType = typeof(CRUD<>).MakeGenericType(tempType);
                            var instanceCRUD = Activator.CreateInstance(genericType);

                            var method = genericType.GetMethod("GetNameList")?.MakeGenericMethod(tempType);
                            var returnValue = method?.Invoke(instanceCRUD, null);
                            var result = (Dictionary<string, string>)returnValue;
                            if (result != null)
                                foreach (var pair in result)
                                {
                                    cb.Add(pair.Key,pair.Value);
                                }
                            Add(cb, property.Name);
                            cb.SelectBase();
                        }
                    }
                }

            }
            Invoke((MethodInvoker)(() =>
           {
               ContainerButton.Visible = true;
               ContainerButton.Text = "Kayıt Ol";
               ToolTip t = new ToolTip();
               t.Show("heyyo", ContainerButton, 5000);
               LocateButton();
           }));

        }
        public Container()
        {
            InitializeComponent();

        }
        private int _lastY = 0;
        public void Add(Control userControl, string propertyName)
        {
            _valueControls.Add(propertyName, (IMainCustomControl)userControl);
            userControl.Location = new Point(userControl.Location.X, _lastY);
            this.Controls.Add(userControl);
            _lastY += userControl.Size.Height + 10;
        }
        public void LocateButton()
        {
            this.Size = new Size(this.Width + 120, this.Height + ContainerButton.Height + 120);
            this.ContainerButton.Location = new Point(this.ContainerButton.Location.X - 40, this._lastY - 70);


        }

        private void ContainerButton_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }
    }
}