using HomePage.Classes;
using HomePage.Classes.Database;
using HomePage.Classes.Database.Cruds;
using HomePage.Classes.Database.Entities;
using HomePage.CustomControls;
using HomePage.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database.Enums;
using HomePage.Forms.ModuleForms;
using System.Runtime.InteropServices;

namespace HomePage
{
    public partial class MainForm : Form//MetroFramework.Forms.MetroForm
    {
        public static User CurrentUser;

        public MainForm()
        {
            
            
            if (CurrentUser == null)
            {
                CurrentUser = new Personnel("TestUser","1234","Test1 Test2","test@mail.com",UserTypes.Personnel, null);
            }
            using (var frm = new Login())
            {
                //var result = frm.ShowDialog();
                //if (CurrentUser == null || result != DialogResult.Yes)
                //{
                //    Close();
                //    Application.Exit();
                //}
                //else
                //{
                    InitializeComponent();
                pnlDataGrid.Visible = false;
                
                //}
                //User user = new User("", "", "mahmut1", "Mahmut", Classes.Database.Enums.UserTypes.Personnel);
                //User user1 = new User("", "", "mahmut2", "Mahmut1", Classes.Database.Enums.UserTypes.Personnel);
                //User user2 = new User("", "", "mahmut3", "Mahmut2", Classes.Database.Enums.UserTypes.Personnel);
                //DbFactory.UserCRUD.Insert(user, user1, user2);
                //Company cmp = new Company
                //{
                //    Name = "Company1",
                //    Address = "TestAddress",
                //    CompanyType = CompanyTypes.Limited,
                //    Contacs = null,
                //    TaxNo = "4556446",
                //    TaxOffice = null,
                //    TaxTypes = new []{"TestTax","TestTax2"},
                //    TcNo = null,
                //    TicaretSicilNo = "454545465"
                //};
                //Company cmp2 = new Company
                //{
                //    Name = "Company2",
                //    Address = "TestAddress",
                //    CompanyType = CompanyTypes.Limited,
                //    Contacs = null,
                //    TaxNo = "4556446",
                //    TaxOffice = null,
                //    TaxTypes = new[] { "TestTax", "TestTax2" },
                //    TcNo = null,
                //    TicaretSicilNo = "454545465"
                //};
                //Company cmp3 = new Company
                //{
                //    Name = "Company3",
                //    Address = "TestAddress",
                //    CompanyType = CompanyTypes.Limited,
                //    Contacs = null,
                //    TaxNo = "4556446",
                //    TaxOffice = null,
                //    TaxTypes = new[] { "TestTax", "TestTax2" },
                //    TcNo = null,
                //    TicaretSicilNo = "454545465"
                //};
                //DbFactory.CompanyCRUD.Insert(cmp, cmp2, cmp3);
            }

        }
        Dictionary<string, string> PersonnelNameList;
#region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
#endregion
        private void button1_Click(object sender, EventArgs e)
        {
            //User user = new User("", "", "", "Mahmut", Classes.Database.Enums.UserTypes.Personnel);
            //  User user1 = new User("", "", "", "Mahmut1", Classes.Database.Enums.UserTypes.Personnel);
            //  User user2 = new User("", "", "", "Mahmut2", Classes.Database.Enums.UserTypes.Personnel);
            //bool ok = DbFactory.UserCRUD.Insert(user, user1, user2);
            /*   PersonnelNameList = await DbFactory.UserCRUD.GetPersonnelName();
               foreach (var item in PersonnelNameList)
               {
                   comboBox1.Items.Add(item.Key);
               }
   ;
             CreateFoo<Company>();*/




        }

        void CreateFoo<T>() where T : class
        {/*
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;
                var attributes = property.GetCustomAttributes(true);
                if (attributes.Length > 0)
                {
                    
                    if (propertyType == typeof(String))
                    {
                        LabelAndTextbox lat = new LabelAndTextbox(attributes[0] as CustomAttribute);
                        lat.LatLabel.Name = property.Name;
                        container1.Add(lat);
                    }
                    else if (propertyType == typeof(Enum))
                    {
                        MetroFramework.Controls.MetroComboBox cb = new MetroFramework.Controls.MetroComboBox();
                        cb.DataSource = Enum.GetValues(property.GetType());
                        container1.Add(cb);
                    }
                    else if (propertyType == typeof(bool))
                    {
                        CheckBox cb = new CheckBox();
                        cb.Text = property.Name;
                        cb.Checked = (bool)property.GetValue(property);
                    }

                }
                if (propertyType.IsEnum == true)
                {
                    MetroFramework.Controls.MetroComboBox cb = new MetroFramework.Controls.MetroComboBox();
                    cb.DataSource = Enum.GetValues(propertyType);
                    container1.Add(cb);
                }else if (propertyType == typeof(bool))
                {
                    CheckBox cb = new CheckBox();
                    cb.Text = property.Name;
                    container1.Add(cb);
                }


            }
            container1.ContainerButton.Visible = true;
            container1.ContainerButton.Text = "Kayıt Ol";
            container1.ContainerButton.Click += ContainerButton_Click;
            container1.LocateButton();*/
        }
        object GetValues<T>() where T : DbObject, new()
        {
            return null;
            /*
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
            return myObject;*/
        }
        private void ContainerButton_Click(object sender, EventArgs e)
        {/*
            bool isOk = true;
            foreach (var item in container1.Controls)
            {
                if (item is LabelAndTextbox)
                {
                    var lat = (item as LabelAndTextbox);
                    if (lat.IsValidated() == false)
                    {
                        isOk = false;
                    }
                }
            }

            if (isOk == true)
            {
                var crud = new UserCRUD();
                //oldUser
                User user = (User)GetValues<User>();
                //user._id = oldUser._id
                crud.Insert(user);
                MessageBox.Show("Welcome");
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        Type _lastCrudType;
        Type _lastType;
        private void BtnCompanies_Click(object sender, EventArgs e)
        {
            _lastCrudType = typeof(CompanyCRUD);
            _lastType = typeof(Company);
            var comps = new CRUD<Company>().GetAll(new MongoDB.Bson.BsonDocument());
            //var comps = await DbFactory.CompanyCRUD.GetAll(new MongoDB.Bson.BsonDocument());
            DVValues.Init<Company>();
            foreach (var item in comps)
            {
                CustomControls.DataRow r = new CustomControls.DataRow();
                DVValues.Add(r.CreateRow(item), item._id);
            }
            Resize();
        }

        private void BtnJobs_Click(object sender, EventArgs e)
        {
            _lastType = typeof(Job);
            _lastCrudType = typeof(JobCRUD);
            //Personnel[] pList = { new Personnel { Name = "Mahmut" }, new Personnel { Name = "Muhsin" } };
            //var j = new Job(pList, DateTime.Now, new Company() { Name = "asd" }, "desc", "dae", 5);
            //var j1 = new Job(pList, DateTime.Now, new Company() { Name = "asd" }, "desc2", "da2e", 5);
            //bool done = DbFactory.JobCRUD.InsertMany(j1, j);
            //MessageBox.Show(done.ToString());

            var jobs = DbFactory.JobCRUD.GetAll(new MongoDB.Bson.BsonDocument());
            DVValues.Init<Job>();
            foreach (var item in jobs)
            {
                CustomControls.DataRow r = new CustomControls.DataRow();
                DVValues.Add(r.CreateRow(item), item._id);
            }
            Resize();
        }

        private new void Resize()
        {
            var width = DVValues.Columns.GetColumnsWidth(DataGridViewElementStates.None) + DVValues.RowHeadersWidth + 2;

            var height = DVValues.Rows.GetRowsHeight(DataGridViewElementStates.None) + DVValues.ColumnHeadersHeight + 2;
            DVValues.Size = new Size(width, height);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DVValues.SelectedId) == false)
            {
               var t = _lastCrudType.GetMethod("Delete")?.Invoke(Activator.CreateInstance(_lastCrudType),new[] { DVValues.SelectedId });
                MessageBox.Show(t.ToString());
            }
           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_lastType != null)
            {
                using (CreateForm cf = new CreateForm(Activator.CreateInstance(_lastType),FormGoal.Add))
                {
                    cf.ShowDialog();
                }
            }
        }

        private void BtnDocuments_Click(object sender, EventArgs e)
        {
            using (var frm = new DocumentPage())
            {
                frm.ShowDialog();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
       
            Application.Exit();
        }


        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
        }
    }
}
