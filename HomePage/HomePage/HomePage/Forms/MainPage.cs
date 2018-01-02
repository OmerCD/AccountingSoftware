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
    public partial class MainPage : Form//MetroFramework.Forms.MetroForm
    {
        public static User CurrentUser;

        public MainPage()
        {
            if (CurrentUser == null)
            {
                CurrentUser = new User("TestUser", "1234", "Test1 Test2", "test@mail.com", UserTypes.Administrator, null);
            }
            //using (var frm = new Login())
            //{
            //    var result = frm.ShowDialog();
            //    if (CurrentUser == null || result != DialogResult.Yes)
            //    {
            //        Close();
            //        Application.Exit();
            //    }
            //    else
            //    {
            InitializeComponent();
            if (CurrentUser.UserType == UserTypes.Administrator)
            {
                BtnUsers.Visible = true;
            }
                    //pnlDataGrid.Visible = false;

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
                //}

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

        Type _lastCrudType;
        Type _lastType;
        private void BtnCompanies_Click(object sender, EventArgs e)
        {
            _lastCrudType = typeof(CompanyCRUD);
            _lastType = typeof(Company);
            RefreshDataGridView<Company>();
        }

        private void BtnJobs_Click(object sender, EventArgs e)
        {
            _lastType = typeof(Job);
            _lastCrudType = typeof(JobCRUD);

            RefreshDataGridView<Job>();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DVValues.SelectedId) == false)
            {
                if (MessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                {
                    _lastCrudType.GetMethod("Delete")
                        ?.Invoke(Activator.CreateInstance(_lastCrudType), new[] {DVValues.SelectedId});
                    RefreshDataGridView();
                }

            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_lastType != null)
            {
                using (CreateForm cf = new CreateForm((DbObject)Activator.CreateInstance(_lastType), FormGoal.Add))
                {
                    cf.ShowDialog();
                    RefreshDataGridView();
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
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (DVValues.SelectedCells.Count > 0)
            {

                dynamic genericCRUD = GetCRUD(_lastType);
                var entity = genericCRUD.GetOne(DVValues.SelectedId);

                //var entity = _lastCrudType.GetMethod("GetOne")?.Invoke(Activator.CreateInstance(_lastCrudType), new[] { DVValues.SelectedId });
                using (var frm = new CreateForm((DbObject)entity, FormGoal.Update))
                {
                    frm.ShowDialog();
                    RefreshDataGridView();
                }
            }
        }

        public static dynamic GetCRUD(Type type)
        { 
            return Activator.CreateInstance(typeof(CRUD<>).MakeGenericType(type));
        }
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            _lastCrudType = typeof(CRUD<User>);
            _lastType = typeof(User);
            RefreshDataGridView<User>();
        }

        private void RefreshDataGridView<T>() where T:DbObject, new()
        {
            dynamic comps = new CRUD<T>();
            var list = comps.GetAll();
            DVValues.Init<User>();
            foreach (var item in list)
            {
                CustomControls.DataRow r = new CustomControls.DataRow();
                DVValues.Add(r.CreateRow(item), item._id);
            }
        }
        private void RefreshDataGridView()
        {
            dynamic comps = Activator.CreateInstance(typeof(CRUD<>).MakeGenericType(_lastType));
            var list = comps.GetAll();
            DVValues.Init<User>();
            foreach (var item in list)
            {
                CustomControls.DataRow r = new CustomControls.DataRow();
                DVValues.Add(r.CreateRow(item), item._id);
            }
        }
    }
}
