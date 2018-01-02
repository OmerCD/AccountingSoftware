using HomePage.Classes.Database;
using HomePage.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;

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
            var userCRUD = DbFactory.UserCRUD;
            if (userCRUD.CheckAuthentication("admin", "admin123")==null)
            {
                var personnel = new User
                {
                    UserName = "admin",
                    Password = "admin123"
                };
                userCRUD.Insert(personnel);
            }
            
        }
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InsertAdmin();
            _passChar = PasswordTextBox.PasswordChar;
            UserNameTextBox.PlaceHolder = UserNameTextBox.Text;
            _passwordPlaceHolder = PasswordTextBox.Text;
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.ForeColor != Color.Black)
            {
                PasswordTextBox.TextAlign = HorizontalAlignment.Center;
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Silver;
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
            var userName = UserNameTextBox.Text;
            var password = PasswordTextBox.Text;
            var user = DbFactory.UserCRUD.CheckAuthentication(userName, password);
            if (user == null)
            {
                MessageBox.Show("Hatalı Giriş Bilgisi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Giriş Başarılı");
            MainPage.CurrentUser = user;
            DialogResult = DialogResult.Yes;
            #endregion
        }

        private void UserNameTextBox_Enter(object sender, EventArgs e)
        {
            UserNameTextBox.ForeColor = Color.Silver;
            UserNameTextBox.TextAlign = HorizontalAlignment.Center;
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
    }
}
