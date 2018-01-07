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
