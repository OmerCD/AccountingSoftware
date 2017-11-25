using HomePage.Classes.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
   
    public class User : DbObject
    {
        [Custom(MinLength = 4,MaxLength =32,FieldName ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Custom(MinLength = 6, MaxLength = 14,IsPassword =true,FieldName ="Şifre")]
        public string Password {  get; protected set; }
        [Custom(MinLength = 2, MaxLength = 40, FieldName = "İsim Soyisim")]
        public string FullName { get; set; }
        [Custom(MinLength = 3, MaxLength = 64,PlaceHolderText ="isim@domain.com", FieldName = "E-Posta",RegexPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$")]
        public string Email { get; set; }
        [Custom(MinLength = 10, MaxLength = 10, PlaceHolderText = "5XXXXXXXXX", FieldName = "Telefon Numarası",RegexPattern = @"^[0-9]{9}")]
        public string PhoneNumber { get; set; }
        public UserTypes UserType { get; set; }

        public User() { }

        public User(string userName, string password, string fullName, string email, UserTypes userType): base()
        {
            UserName = userName;
            Password = password;
            FullName = fullName;
            Email = email;
            UserType = userType;
        }
   

        public UserTypes GetUserType()
        {
            return UserType;
        }
    }
}
