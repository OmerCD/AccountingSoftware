using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database
{
    public class CRUD<T> : IRepositoryMain<T> where T:DbObject, new()
    {
        protected IMongoDatabase Database;
        protected IMongoCollection<BsonDocument> Table;


        public CRUD(IMongoCollection<BsonDocument> tableInstance)
        {
            Database = DbFactory.Database;
            Table = tableInstance;
        }

        public CRUD()
        {
            var typeName = typeof(T).Name;
            var testProp = typeof(DbFactory).GetProperty(typeName);
            var factoryValue = testProp.GetValue(null);
            Table = (IMongoCollection<BsonDocument>) factoryValue;
        }
        public async Task<Dictionary<string, string>> GetNameList<T1>() where T1:DbObject,new() // PersonnelName,_id
        {
            Dictionary<string, string> personnelList = new Dictionary<string, string>();
            HashSet<string> nameList = new HashSet<string> {"ALL"};
            personnelList.Add("ALL", "ALL"); // Tüm data için
            foreach (var item in await new CRUD<T1>().GetAll(new BsonDocument()))
            {
                string name = item.GetType().GetProperty("Name")?.GetValue(item).ToString();
                if (nameList.Contains(name) == false)
                {
                    personnelList.Add(name, item._id);
                    nameList.Add(name);
                }

            }

            return personnelList;
        }

        public virtual async Task<bool> Delete(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
              /**/
                var builder =  Builders<BsonDocument>.Update.Set("IsDeleted", 1);

                await Table.UpdateOneAsync(filter, builder);
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual async Task<List<T>> GetAll(BsonDocument filter)
        {
            //try
            //{
                var results = new List<T>();
                using (var cursor = await Table.FindAsync(filter))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        var batch = cursor.Current;
                        results.AddRange(batch.Select(item => BsonSerializer.Deserialize<T>(item)));
                    }
                    
                }
                results = results.Where(x => x.IsDeleted == 0).ToList();
                return results;
            //}
            //catch (Exception ex)
            //{

            //    return new List<T>();
            //}

        }

        public virtual async Task<T> GetOne(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                using (var cursor = await Table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<T>(cursor.First().ToString());
                }

            }
            catch (Exception)
            {

                return new T { _id = null };
            }

        }
        public  async Task<List<T>> BringBack(BsonDocument filter)
        {
            try
            {
                var results = new List<T>();
                using (var cursor = await Table.FindAsync(filter))
                {
                    var x = cursor.ToList();
                    results.AddRange(x.Select(item => JsonConvert.DeserializeObject<T>(item.ToString())));
                }
                return results;
            }
            catch (Exception)
            {

                return new List<T>();
            }
        }
        public async Task<T> GetOneUser(string userName,string password)//todo
        {
            try
            {
                var filter = new BsonDocument { { "UserName", userName }, {"Password",password } };
                using (var cursor = await Table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<T>(cursor.First().ToString());
                }

            }
            catch (Exception)
            {

                return new T { _id = null };
            }

        }
        public virtual async Task<bool> Insert(params T[] entities)
        {
            try
            {
                foreach (var entity in entities)
                {
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
                    var bsonDocument = BsonDocument.Parse(json);
                    await Table.InsertOneAsync(bsonDocument);
                }
               
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public virtual async Task<bool> Update(string id, T entity)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                await Table.UpdateOneAsync(filter, JsonConvert.SerializeObject(entity));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
