using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
   public class Calendar : DbObject
    {
        public DateTime Date { get; set; }
        public string[] Jobs { get; set; } // Job_id 
    }
}
