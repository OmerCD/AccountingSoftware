using HomePage.Classes.Database;
using HomePage.CustomControls;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;
using HomePage.Properties;

namespace HomePage.Forms
{
    public partial class Login : Form
    {
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private readonly char _passChar;
        private readonly string _passwordPlaceHolder;

        private void InsertAdmin()
        {
            var settingsCRUD = new CRUD<GeneralSettings>(DbFactory.GeneralSettings);

            var userCRUD = DbFactory.UserCRUD;

            var adminCreated = settingsCRUD.GetOne("AdminCreated", true)._id != null;
            if (!adminCreated)
            {
                var personnel = new User
                {
                    UserName = "admin",
                    Password = "admin123"
                };
                userCRUD.Insert(personnel);
                settingsCRUD.Insert(new GeneralSettings {AdminCreated = true});
            }
            
        }
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _passChar = PasswordTextBox.PasswordChar;
            UserNameTextBox.PlaceHolder = UserNameTextBox.Text;
            _passwordPlaceHolder = PasswordTextBox.Text;
            ServerIPTextBox.PlaceHolder = ServerIPTextBox.Text;
            if (Settings.Default.RememberMe)
            {
                if (!string.IsNullOrWhiteSpace(Settings.Default.IPAddress))
                {
                    ServerIPTextBox.ForeColor = Color.White;
                    ServerIPTextBox.Text = Settings.Default.IPAddress;
                    ServerIPTextBox.IsPlaceHolder = false;
                }
                if (!string.IsNullOrWhiteSpace(Settings.Default.UserName))
                {
                    UserNameTextBox.ForeColor = Color.White;
                    UserNameTextBox.Text = Settings.Default.UserName;
                    UserNameTextBox.IsPlaceHolder = false;
                }
                if (!string.IsNullOrWhiteSpace(Settings.Default.Password))
                {
                    PasswordTextBox.ForeColor = Color.White;
                    PasswordTextBox.Text = Settings.Default.Password;
                    PasswordTextBox.PasswordChar = '*';
                }
                CbRememberInfo.Checked = true;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.ForeColor != Color.White)
            {
                PasswordTextBox.TextAlign = HorizontalAlignment.Center;
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.White;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.TextLength > 0)
            {
                //PasswordTextBox.PasswordChar = _passChar;
            }
            else if (PasswordTextBox.TextLength<=0)
            {
                PasswordTextBox.TextAlign = HorizontalAlignment.Center;
                PasswordTextBox.Text = _passwordPlaceHolder;
                PasswordTextBox.ForeColor = Color.Silver;
                PasswordTextBox.PasswordChar = _passChar;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            #region Asıl Login

            if (ServerIPTextBox.TextLength < 11)
            {
                MessageBox.Show("Server IP adresi 11 haneden kısa olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (UserNameTextBox.TextLength < 3)
            {
                MessageBox.Show("Kullanıcı Adı 3 karakterden kısa olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (PasswordTextBox.TextLength < 6)
            {
                MessageBox.Show("Şifre 6 karakterden kısa olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            ConnectAndLogin();
            #endregion
        }

        void SetLockLoginForm(bool locked)
        {
            ServerIPTextBox.Enabled = !locked;
            UserNameTextBox.Enabled = !locked;
            PasswordTextBox.Enabled = !locked;
            LoginButton.Enabled = !locked;
            btnExit.Enabled = !locked;
        }
        private async void ConnectAndLogin()
        {
            SetLockLoginForm(true);
            var waitingForm = new LoadingForm();
            waitingForm.Show();
            if (await DbFactory.SetConnection(ServerIPTextBox.Text))
            {
                
                InsertAdmin();
                SetLockLoginForm(false);
                waitingForm.Close();
                waitingForm.Dispose();
                var userName = UserNameTextBox.Text;
                var password = PasswordTextBox.Text;
                var user = DbFactory.UserCRUD.CheckAuthentication(userName, password);
                if (user == null)
                {
                    MessageBox.Show("Hatalı Giriş Bilgisi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CbRememberInfo.Checked)
                {
                    SaveInfo();
                }
                MainPage.CurrentUser = user;
                DialogResult = DialogResult.Yes;
            }
            else
            {
                waitingForm.Close();
                waitingForm.Dispose();

                var mboxResult = MessageBox.Show("Sunucuya Bağlanılamadı", "Hata", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
                if (mboxResult == DialogResult.Retry)
                {
                    
                    Show();
                    ConnectAndLogin();
                }
                else if (mboxResult==DialogResult.Cancel)
                {
                    SetLockLoginForm(false);
                }
            }
        }

        private void SaveInfo()
        {
            Settings.Default.IPAddress = ServerIPTextBox.Text;
            Settings.Default.UserName = UserNameTextBox.Text;
            Settings.Default.Password = PasswordTextBox.Text;
            Settings.Default.RememberMe = CbRememberInfo.Checked;
            Settings.Default.Save();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
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

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var tBox = (MyTextBox) sender;
            tBox.ForeColor = Color.White;
            tBox.TextAlign = HorizontalAlignment.Center;
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            var tBox = (MyTextBox)sender;
            if (tBox.TextLength <= 0)
            {
                tBox.TextAlign = HorizontalAlignment.Center;
                tBox.Text = tBox.PlaceHolder;
                tBox.ForeColor = Color.Silver;
            }
        }
    }
}
