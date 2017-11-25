using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
    public class DbObject
    {
        public string _id { get; set; }
        public DateTime CreationDate { get; protected set; }
        public bool IsDeleted { get; protected set; }
        public DbObject()
        {
            _id = Guid.NewGuid().ToString();
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
