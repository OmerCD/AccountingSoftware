using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Cruds
{
    public class JobCRUD :CRUD<Job>
    {
        public JobCRUD():base(DbFactory.Job)
        {
            
        }
        public Dictionary<string, string> GetNameList() // PersonnelName,_id
        {
            Dictionary<string, string> personnelList = new Dictionary<string, string>();
            HashSet<string> nameList = new HashSet<string> {"ALL"};
            personnelList.Add("ALL", "ALL"); // Tüm Personel için
            foreach (var item in DbFactory.CompanyCRUD.GetAll(new BsonDocument()))
            {
                if (nameList.Contains(item.Name) == false)
                {
                    personnelList.Add(item.Name, item._id);
                    nameList.Add(item.Name);
                }

            }

            return personnelList;
        }
    }
}
