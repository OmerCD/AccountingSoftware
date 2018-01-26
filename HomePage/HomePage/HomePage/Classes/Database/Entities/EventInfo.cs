using System;
using System.Collections.Generic;

namespace HomePage.Classes.Database.Entities
{
    public class Event:DbObject
    {
        [Custom(FieldName = "Olay Adı",MaxLength = 25)]
        public string Name { get; set; }
        [Custom(FieldName = "Olay Saati")]
        public int EventHour { get; set; }
        [Custom(FieldName = "Açıklama",MaxLength = 500)]
        public string Description { get; set; }
    }

    public class DayEvent : DbObject
    {
        public DateTime EventDate { get; set; }
        public List<Event> Events { get; set; }

        public DayEvent()
        {
            Events= new List<Event>();
        }
    }
}
