using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using MongoDB.Bson.Serialization;

namespace HomePage.Classes.Database
{
    public class UserCRUD : CRUD<User>
    {
        public UserCRUD()
        {
            Table = DbFactory.User;
        }
        public User CheckAuthentication(string userName, string password)
        {
            try
            {
                var filter = new BsonDocument { { "UserName", userName }, { "Password", password },{"IsDeleted",0} };
                var cursor = Table.FindSync(filter);
                cursor.MoveNext();
                var batch = cursor.Current;
                return batch==null ? null : BsonSerializer.Deserialize<User>(batch.FirstOrDefault());
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
