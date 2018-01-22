using System;
using HomePage.Classes;
using HomePage.Classes.Database.Entities;

namespace HomePage.CustomControls.Calendar
{
    public class EventInfo:DbObject
    {
        [Custom(FieldName = "Olay Adı",MaxLength = 25)]
        public string Name { get; set; }
        [Custom(FieldName = "Olay Tarihi")]
        public DateTime EventDate { get; set; }
    }
}
