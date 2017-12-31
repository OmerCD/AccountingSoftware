using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;

namespace HomePage.Classes.Database
{
    public class UserCRUD : CRUD<User>
    {
        public UserCRUD()
        {
            Table = DbFactory.User;
        }
        public Personnel CheckAuthentication(string userName, string password)
        {
            try
            {
                var filter = new MongoDB.Bson.BsonDocument { { "UserName", userName }, { "Password", password },{"IsDeleted",0} };
                var cursor = Table.FindSync(filter);
                cursor.MoveNext();
                var batch = cursor.Current;
                if (batch==null)
                {
                    return null;
                }
                return BsonSerializer.Deserialize<Personnel>(batch.FirstOrDefault());
            }
            catch (Exception)
            {

                return null;
            }

        }

        public Dictionary<string, string> GetNameList() // PersonnelName,_id
        {
            var personnelList = new Dictionary<string, string> { { "ALL", "ALL" } };// Tüm Personel için
            var nameList = new HashSet<string> { "ALL" };
            foreach (var item in GetAll(new BsonDocument()))
            {
                if (item.UserType == Enums.UserTypes.Customer || nameList.Contains(item.Name)) continue;
                personnelList.Add(item.Name, item._id);
                nameList.Add(item.Name);
            }

            return personnelList;
        }
    }
}
