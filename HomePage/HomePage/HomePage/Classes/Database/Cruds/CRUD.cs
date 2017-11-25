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
    public class CRUD<T> : IRepositoryMain<T> where T:DbObject, new()
    {
        protected IMongoDatabase Database;
        protected IMongoCollection<BsonDocument> Table;

        public CRUD(IMongoCollection<BsonDocument> tableInstance)
        {
            Database = DbFactory.Database;
            Table = tableInstance;
        }

        protected CRUD()
        {

        }


        public virtual async Task<bool> Delete(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                var entity = await GetOne(id);
                entity.Delete();
                await Table.UpdateOneAsync(filter, JsonConvert.SerializeObject(entity));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual async Task<List<T>> GetAll(BsonDocument filter)
        {
            try
            {
                var results = new List<T>();
                using (var cursor = await Table.FindAsync(filter))
                {
                    var x = cursor.ToList();
                    results.AddRange(x.Select(item => JsonConvert.DeserializeObject<T>(item.ToString())));
                }
                results = results.Where(x => x.IsDeleted == false).ToList();
                return results;
            }
            catch (Exception)
            {

                return new List<T>();
            }

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
        public virtual async Task<bool> Insert(T entity)
        {
            try
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
                var bsonDocument = BsonDocument.Parse(json);
                await Table.InsertOneAsync(bsonDocument);
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
