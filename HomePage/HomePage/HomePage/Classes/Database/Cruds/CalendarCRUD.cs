using HomePage.Classes.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
