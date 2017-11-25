using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePage.Classes.Database.Enums;

namespace HomePage.Classes.Database.Entities
{
    public class Personnel : User
    {
        public Personnel()
        {

        }
        public Personnel(string userName, string password, string fullName, string email, UserTypes userType, string[] allowedModules) : base(userName, password, fullName, email, userType)
        {
            AllowedModules = allowedModules;
        }

        public string[] AllowedModules { get; set; }
    }
}
