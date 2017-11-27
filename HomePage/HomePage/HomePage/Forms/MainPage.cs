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
using HomePage.Classes.Database.Enums;
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
                var result = frm.ShowDialog();
                if (CurrentUser == null || result!=DialogResult.Yes)
                {
                    Close();
                    Application.Exit();
                }
                else
                {
                    InitializeComponent();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            container1.Object = user;
            container1.ClickEvent = ContainerButton_Click;
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
                User user = (User)container1.Object;
                //user._id = oldUser._id
                crud.Insert(user);
                MessageBox.Show("Success");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new AddUser(UserTypes.Personnel))
            {
                frm.ButtonText = "Ekle";
                frm.ShowDialog();
            }
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new AddUser(UserTypes.Customer))
            {
                frm.ButtonText = "Oluştur";
                frm.ShowDialog();
            }
        }
    }
}
