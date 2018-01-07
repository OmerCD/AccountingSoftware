    using HomePage.Classes.Database.Entities;

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
