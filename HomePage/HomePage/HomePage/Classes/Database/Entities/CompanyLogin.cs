using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
   public class CompanyLogin :DbObject
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public CompanyLogin()
        {

        }

        public CompanyLogin(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
