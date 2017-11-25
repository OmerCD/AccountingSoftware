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

namespace HomePage.CustomControls
{
    public partial class Container : UserControl
    {
        private object _object;

        public string ButtonText
        {
            set => ContainerButton.Text = value;
        }

        public delegate void ButtonClickEvent(object sender,EventArgs e);
        public ButtonClickEvent ClickEvent { get; set; }

        public object Object
        {
            get
            {
                _object = GetValues();
                return _object;
            }
            set
            {
                _object = value;
                //Controls.Clear();
                CreateControls();
            }
        }

        private object GetValues()
        {
            var myType = _object.GetType();
            var myObject = Activator.CreateInstance(myType);
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
                                    prop.SetValue(myObject, cont.LatTextBox.Text);
                                    break;
                                }
                            }
                            break;
                        }

                    }
                }
            }
            return myObject;
        }
        void CreateControls()
        {
            var properties = _object.GetType().GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(true);
                if (attributes.Length > 0)
                {
                    LabelAndTextbox lat = new LabelAndTextbox(attributes[0] as CustomAttribute)
                    {
                        LatLabel = { Name = property.Name }
                    };
                    Add(lat);
                }

            }
            ContainerButton.Visible = true;
            ContainerButton.Text = "Kayıt Ol";
            LocateButton();
        }
        public Container()
        {
            InitializeComponent();
           
        }
        public int _lastY = 0;
        public void Add(Control userControl)
        {
            userControl.Location = new Point(userControl.Location.X, _lastY);
            this.Controls.Add(userControl);
            _lastY += userControl.Size.Height + 10;

        }
        public void LocateButton()
        {
            this.Size = new Size(this.Width, this.Height + 35);
            this.ContainerButton.Location = new Point(this.ContainerButton.Location.X, this._lastY);


        }

        private void ContainerButton_Click(object sender, EventArgs e)
        {
            ClickEvent(sender, e);
        }
    }
}
