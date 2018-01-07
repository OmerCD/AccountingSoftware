using System;

namespace HomePage.Classes.Database.Entities
{
   public class Calendar : DbObject
    {
        public DateTime Date { get; set; }
        public string[] Jobs { get; set; } // Job_id 
    }
}
