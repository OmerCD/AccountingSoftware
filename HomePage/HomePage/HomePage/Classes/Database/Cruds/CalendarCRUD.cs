using HomePage.Classes.Database.Entities;

namespace HomePage.Classes.Database.Cruds
{
    public class CalendarCRUD :CRUD<Calendar>
    {
        public CalendarCRUD()
        {
            Table = DbFactory.Calendar;
        }
    }
}
