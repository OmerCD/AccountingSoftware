using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database.Entities;
using HomePage.Classes.Database.Enums;

namespace HomePage.Forms
{
    public partial class AddUser : MetroFramework.Forms.MetroForm
    {
        public string ButtonText
        {
            set => container1.ButtonText = value;
        }
        public AddUser(UserTypes userType)
        {
            InitializeComponent();
            switch (userType)
            {
                case UserTypes.Customer: container1.Object = new Customer(); break;
                case UserTypes.Personnel: container1.Object = new Personnel(); break;
            }
            container1.ClickEvent = ClickEvent;
        }

        private void ClickEvent(object sender, EventArgs eventArgs)
        {
            
        }
    }
}
