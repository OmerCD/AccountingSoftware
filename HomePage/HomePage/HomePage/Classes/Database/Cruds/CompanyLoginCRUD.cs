    using HomePage.Classes.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Cruds
{

    public class CompanyLoginCRUD : CRUD<CompanyLogin>
    {
        public CompanyLoginCRUD()
        {
            Table = DbFactory.CompanyLogin;
        }
    }
}
