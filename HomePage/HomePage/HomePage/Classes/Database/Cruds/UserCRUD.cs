using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database
{
    public class UserCRUD : CRUD<User>
    {
        public UserCRUD()
        {
            Table = DbFactory.User;
        }
        public async Task<User> CheckAuthentication(string userName, string password)
        {
            try
            {
                var filter = new MongoDB.Bson.BsonDocument { { "UserName", userName }, { "Password", password } };
                using (IAsyncCursor<BsonDocument> cursor = await Table.FindAsync(filter))
                {
                System.Windows.Forms.MessageBox.Show(cursor.ToString());
                return JsonConvert.DeserializeObject<User>(cursor.First().ToString());
                }
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
