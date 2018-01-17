using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using System.Collections.Generic;

namespace HomePage.Classes.Database.Cruds
{
    public class CompanyCRUD : CRUD<Company>
    {
        public CompanyCRUD():base(DbFactory.Company)
        {
        }
    }
}
