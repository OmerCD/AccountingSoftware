using System;
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
                case UserTypes.Customer:
                    container1.Object=new Customer(); break;
                case UserTypes.Personnel: container1.Object=new User(); break;
            }
            container1.ClickEvent = ClickEvent;
        }

        private void ClickEvent(object sender, EventArgs eventArgs)
        {
            
        }
    }
}
