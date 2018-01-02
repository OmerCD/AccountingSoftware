using HomePage.Classes.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
    public class Customer : User
    {
        public Customer() { }
        public Customer(string userName, string password, string fullName, string email, UserTypes userType, CustomerTypes customerType, string address, string[] allowedModules) : base(userName, password, fullName, email, userType,allowedModules)
        {
            CustomerType = customerType;
            Address = address;
        }

        public CustomerTypes CustomerType { get; private set; }
        public string Address { get; set; }
    }
}
