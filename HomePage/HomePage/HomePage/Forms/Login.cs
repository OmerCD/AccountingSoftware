using HomePage.Classes.Database;
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

namespace HomePage.Forms
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        char _passChar;
        string _passwordPlaceHolder;
        public Login()
        {
            InitializeComponent();
            _passChar = PasswordTextBox.PasswordChar;
            UserNameTextBox.PlaceHolder = UserNameTextBox.Text;
            _passwordPlaceHolder = PasswordTextBox.Text;
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.ForeColor != Color.Black)
            {
                PasswordTextBox.TextAlign = HorizontalAlignment.Left;
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
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

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.TextLength < 3)
            {
                MessageBox.Show("Kullanıcı Adı 3 karakterden kısa olamaz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            if (PasswordTextBox.TextLength<6)
            {
                MessageBox.Show("Şifre 6 karakterden kısa olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var userName = UserNameTextBox.Text;
            var password = PasswordTextBox.Text;
            var user = await DbFactory.UserCRUD.CheckAuthentication(userName, password);
            if (user == null) return;
            MessageBox.Show("Giriş Başarılı");
            MainForm.CurrentUser = user;
            DialogResult= DialogResult.Yes;
            Close();
        }
    }
}
