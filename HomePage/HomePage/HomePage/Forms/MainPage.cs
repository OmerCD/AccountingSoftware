using HomePage.Classes.Database;
using HomePage.Classes.Database.Cruds;
using HomePage.Classes.Database.Entities;
using HomePage.Forms;
using System;
using System.Windows.Forms;
using HomePage.Classes.Database.Enums;
using HomePage.Forms.ModuleForms;
using System.Runtime.InteropServices;
using HomePage.CustomControls.ContextMenu;

namespace HomePage
{
    public partial class MainPage : Form
    {
        public static User CurrentUser;

        private readonly PoperContainer _poperContextSettings;

        public MainPage()
        {
            //if (CurrentUser == null)
            //{
            //    CurrentUser = new User("TestUser", "1234", "Test1 Test2", "test@mail.com", UserTypes.Administrator, null);
            //}
            using (var frm = new Login())
            {
                var result = frm.ShowDialog();
                if (CurrentUser == null || result != DialogResult.Yes)
                {
                    Close();
                    Application.Exit();
                }
                else
                {
                    InitializeComponent();
                    if (CurrentUser.UserType == UserTypes.Administrator)
                    {
                        BtnUsers.Visible = true;
                    }
                    var menuContextSettings = new SettingsContextMenu();
                    _poperContextSettings= new PoperContainer(menuContextSettings);

                    menuContextSettings.BtnLogOut.Click += BtnLogOut_Click;
                    //pnlDataGrid.Visible = false;

                }
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            BtnUsers.Visible = false;
            using (var frm = new Login())
            {
                var result = frm.ShowDialog();
                if (CurrentUser == null || result != DialogResult.Yes)
                {
                    Close();
                    Application.Exit();
                }
                else
                {
                    if (CurrentUser.UserType == UserTypes.Administrator)
                    {
                        BtnUsers.Visible = true;
                    }
                }
            }
        }

        #region Move Form

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        #endregion

        private Type _lastCrudType;
        private Type _lastType;
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
                        ?.Invoke(Activator.CreateInstance(_lastCrudType), new[] { DVValues.SelectedId });
                    RefreshDataGridView();
                }

            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_lastType != null)
            {
                using (var cf = new CreateForm((DbObject)Activator.CreateInstance(_lastType), FormGoal.Add))
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
                var genericCRUD = GetCRUD(_lastType);
                var entity = genericCRUD.GetOne(DVValues.SelectedId);

                //var entity = _lastCrudType.GetMethod("GetOne")?.Invoke(Activator.CreateInstance(_lastCrudType), new[] { DVValues.SelectedId });
                using (var frm = new CreateForm((DbObject)entity, FormGoal.Update))
                {
                    frm.ShowDialog();
                    RefreshDataGridView();
                }
            }
        }
        /// <summary>
        /// Returns a dynamic variable based on the type entered. It is used for creating a generic CRUD type
        /// </summary>
        /// <param name="type">Disered type of CRUD</param>
        /// <returns>Dynamic CRUD variable</returns>
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

        private void RefreshDataGridView<T>() where T : DbObject, new()
        {
            dynamic comps = new CRUD<T>();
            var list = comps.GetAll();
            DVValues.Init<T>();
            foreach (var item in list)
            {
                var r = new CustomControls.DataRow();
                DVValues.Add(r.CreateRow(item), item._id);
            }
        }
        private void RefreshDataGridView()
        {
            dynamic comps = GetCRUD(_lastType);
            var list = comps.GetAll();
            DVValues.Init(_lastType);
            foreach (var item in list)
            {
                var r = new CustomControls.DataRow();
                DVValues.Add(r.CreateRow(item), item._id);
            }
        }

        private void BtnUsers_MouseEnter(object sender, EventArgs e)
        {
            BtnUsers.Text = BtnUsers.Text.TrimEnd();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _poperContextSettings.Show(btnSettings);
        }
    }
}
