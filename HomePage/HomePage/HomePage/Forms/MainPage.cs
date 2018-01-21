using HomePage.Classes.Database;
using HomePage.Classes.Database.Entities;
using HomePage.Forms;
using System;
using System.Windows.Forms;
using HomePage.Classes.Database.Enums;
using HomePage.Forms.ModuleForms;
using System.Runtime.InteropServices;
using HomePage.CustomControls.ContextMenu;
using MongoDB.Bson;

namespace HomePage
{
    public partial class MainPage : Form
    {
        public static User CurrentUser;

        private readonly PoperContainer _poperContextSettings;
        private Type _lastType;

        public MainPage()
        {
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
                    if (CurrentUser.UserType == UserTypes.Yönetici)
                    {
                        BtnUsers.Visible = true;
                    }
                    var menuContextSettings = new SettingsContextMenu();
                    _poperContextSettings = new PoperContainer(menuContextSettings);

                    menuContextSettings.BtnLogOut.Click += BtnLogOut_Click;
                }
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            BtnUsers.Visible = false;
            DVValues.Rows.Clear();
            DVValues.Columns.Clear();
            using (var frm = new Login())
            {
                Hide();
                var result = frm.ShowDialog();
                if (CurrentUser == null || result != DialogResult.Yes)
                {
                    Close();
                    Application.Exit();
                }
                else
                {
                    Show();
                    if (CurrentUser.UserType == UserTypes.Yönetici)
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

        /// <summary>
        /// Assign last selected types by giving the desired types to be used.
        /// </summary>
        /// <typeparam name="TObjectType"></typeparam>
        private void AssignLastTypes<TObjectType>()
        {
            _lastType = typeof(TObjectType);
        }
        private void BtnCompanies_Click(object sender, EventArgs e)
        {
            EntityChange<Company>();
        }

        private void EntityChange<T>() where T:DbObject, new()
        {
            AssignLastTypes<T>();
            RefreshDataGridView<T>();
        }

        private void BtnJobs_Click(object sender, EventArgs e)
        {
            EntityChange<Job>();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DVValues.SelectedId) == false)
            {
                if (CheckIfUserLastAdmin())
                {
                    MessageBox.Show("Yalnızca 1 adet yönetici kaldığı için, bu kullanıcıyı silemezsiniz.",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                {
                    var genericCRUD = GetCRUD(_lastType);
                    genericCRUD.Delete(DVValues.SelectedId);
                    RefreshDataGridView();
                }

            }

        }

        private bool CheckIfUserLastAdmin()
        {
            if (_lastType == typeof(User))
            {
                var userCRUD = new CRUD<User>();
                var selectedUser = userCRUD.GetOne(DVValues.SelectedId);
                if (selectedUser.UserType == UserTypes.Yönetici)
                {
                    var adminList = userCRUD.GetAll(new BsonDocument { { "UserType", UserTypes.Yönetici }, { "IsDeleted", 0 } });
                    if (adminList.Count < 2)
                    {
                        return true;
                    }
                }
            }
            return false;
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
            EntityChange<User>();
        }
        /// <summary>
        /// Refreshes the DataGridView based on given Type, from database.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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
        /// <summary>
        /// Refreshes the DataGridView based on given last type choosen, from database
        /// </summary>
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

        private void ButtonCalendar_Click(object sender, EventArgs e)
        {
            using (var frm = new CalendarForm())
            {
                frm.ShowDialog();
            }
        }
    }
}
