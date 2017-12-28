using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePage.Document;

namespace HomePage.Classes.Database.Cruds
{
    public class ColumnCRUD : CRUD<Column>
    {
        public ColumnCRUD():base(DbFactory.Column)
        {
        }
    }
}
