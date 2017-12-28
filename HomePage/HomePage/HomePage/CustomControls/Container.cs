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

        public string ButtonText
        {
            set { ContainerButton.Text = value; }
        }

        public delegate void ButtonClickEvent(object sender, EventArgs e);
        public ButtonClickEvent ClickEvent { get; set; }
        object _crud;
        public object CRUD
        {
            get
            {
                return _crud;
            }
            set
            {
                _crud = value;

            }
        }

        public void SetObject(object obj)
        {
            _object = obj;
            CreateControls();
        }
        public object Object
        {
            get
            {
                _object = GetValues();
                return _object;
            }
        }

        private object GetValues()
        {
            var myType = _object.GetType();
            //var myObject = Activator.CreateInstance(myType);
            foreach (var control in Controls)
            {
                if (control is LabelAndTextbox)
                {
                    var properties = myType.GetProperties();
                    foreach (var property in properties)
                    {
                        var cont = (control as LabelAndTextbox);
                        var propName = cont.LatLabel.Name;
                        if (propName == property.Name)
                        {
                            foreach (var prop in myType.GetProperties())
                            {
                                if (prop.Name == propName)
                                {
                                    prop.SetValue(_object, cont.LatTextBox.Text);
                                    break;
                                }
                            }
                            break;
                        }

                    }
                }
            }
            return _object;
        }

        void CreateControls()
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
                        Add(lat);
                    }
                    else if (propertyType == typeof(DateTime))
                    {
                        LabelAndDatePicker lad = new LabelAndDatePicker(attribute);
                        Add(lad);
                    }
                    else if (propertyType.IsEnum == true)
                    {
                        MetroFramework.Controls.MetroComboBox cb =
                            new MetroFramework.Controls.MetroComboBox { DataSource = (Enum.GetValues(propertyType)) };
                        Add(cb);
                    }
                    else if (propertyType == typeof(bool))
                    {
                        CheckBox cb = new CheckBox { Text = attribute.FieldName };
                        Add(cb);
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
                                cb.Add(pair.Key);
                            }
                        Add(cb);
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
                                    cb.Add(pair.Key);
                                }
                            Add(cb);
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
        public void Add(Control userControl)
        {

                Invoke((MethodInvoker)(() =>
               {
                   userControl.Location = new Point(userControl.Location.X, _lastY);
                   this.Controls.Add(userControl);
                   _lastY += userControl.Size.Height + 10;
               }));
            

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