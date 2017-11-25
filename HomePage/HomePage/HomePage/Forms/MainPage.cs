using HomePage.Classes;
using HomePage.Classes.Database;
using HomePage.Classes.Database.Entities;
using HomePage.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Forms;

namespace HomePage
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public static User CurrentUser;
        public MainForm()
        {
            using (var frm = new Login())
            {
                frm.ShowDialog();
                if (CurrentUser == null)
                {
                    Application.Exit();
                }
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User("", "", "", "", Classes.Database.Enums.UserTypes.Administrator);
            CreateFoo<User>();



        }

        void CreateFoo<T>() where T : class
        {
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(true);
                if (attributes.Length > 0)
                {
                    LabelAndTextbox lat = new LabelAndTextbox(attributes[0] as CustomAttribute)
                    {
                        LatLabel = { Name = property.Name }
                    };
                    container1.Add(lat);
                }

            }
            container1.ContainerButton.Visible = true;
            container1.ContainerButton.Text = "Kayıt Ol";
            container1.ContainerButton.Click += ContainerButton_Click;
            container1.LocateButton();
        }
        object GetValues<T>() where T : DbObject, new()
        {
            var myType = typeof(T);
            var myObject = Activator.CreateInstance(myType);
            foreach (var control in container1.Controls)
            {
                if (control is LabelAndTextbox)
                {


                    var properties = typeof(T).GetProperties();
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
        private void ContainerButton_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            foreach (var item in container1.Controls)
            {
                var lat = item as LabelAndTextbox;
                if (lat?.IsValidated() == false)
                {
                    isOk = false;
                }
            }

            if (isOk == true)
            {
                var crud = new UserCRUD();
                //oldUser
                User user = (User)GetValues<User>();
                //user._id = oldUser._id
                crud.Insert(user);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
