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
        public Customer()
        {
            
        }
        public Customer(string userName, string password, string fullName, string email, UserTypes userType,CustomerTypes customerType, string address) : base(userName, password, fullName, email, userType)
        {
            CustomerType = customerType;
            Address = address;
        }
        [Custom(FieldName = "Müşteri Türü")]
        public CustomerTypes CustomerType { get; private set; }
        [Custom(FieldName = "Adres",MinLength = 10,MaxLength = 128)]
        public string Address { get; set; }
    }
}
