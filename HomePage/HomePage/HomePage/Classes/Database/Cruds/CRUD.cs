﻿using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomePage.Classes.Database
{
    public class CRUD<T> : IRepositoryMain<T> where T : DbObject, new()
    {
        private readonly IMongoDatabase _database;
        protected IMongoCollection<BsonDocument> Table;


        public CRUD(IMongoCollection<BsonDocument> tableInstance)
        {
            _database = DbFactory.Database;
            Table = tableInstance;
        }

        public CRUD()
        {
            var typeName = typeof(T).Name;
            var testProp = typeof(DbFactory).GetProperty(typeName);
            var factoryValue = testProp.GetValue(null);

            Table = (IMongoCollection<BsonDocument>)factoryValue;
        }
        // ReSharper disable once UnusedMember.Global
        public Dictionary<string, string> GetNameList()
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            HashSet<string> nameList = new HashSet<string> { "ALL" };
            list.Add("ALL", "ALL"); // Tüm data için
            foreach (dynamic item in new CRUD<T>().GetAll(new BsonDocument()))
            {
                string name = item.Name ?? "";
                if (nameList.Contains(name) == false)
                {
                    list.Add(name, item._id);
                    nameList.Add(name);
                }

            }

            return list;
        }

        public virtual bool NameCheck(string name)
        {
            try
            {
                var filter = new BsonDocument { { "Name", name } };
                var cursor = Table.FindSync(filter);
                cursor.MoveNext();
                return cursor.Current.Any();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return true;
            }
        }
        public virtual bool Delete(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                /**/
                var builder = Builders<BsonDocument>.Update.Set("IsDeleted", 1);

                Table.UpdateOne(filter, builder);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public virtual List<T> GetAll()
        {
            try
            {
                var filter = new BsonDocument { { "IsDeleted", 0 } };
                var results = new List<T>();
                var found = Table.FindSync(filter);
                while (found.MoveNext())
                {
                    var batch = found.Current;
                    results.AddRange(batch.Select(item => BsonSerializer.Deserialize<T>(item)));
                }
                return results;
            }
            catch (Exception ex)
            {

                return new List<T>();
            }

        }
        public void ClearColection()
        {
            _database.DropCollection(typeof(T).Name);
        }
        public virtual List<T> GetAll(BsonDocument filter)
        {
            try
            {
                if (filter == null) filter = new BsonDocument { { "IsDeleted", 0 } };
                var results = new List<T>();
                var found = Table.FindSync(filter);
                while (found.MoveNext())
                {
                    var batch = found.Current;
                    results.AddRange(batch.Select(item => BsonSerializer.Deserialize<T>(item)));
                }
                return results;
            }
            catch (Exception ex)
            {

                return new List<T>();
            }

        }

        public virtual T GetOne(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                var cursor = Table.FindSync(filter);
                cursor.MoveNext();
                var batch = cursor.Current;
                return BsonSerializer.Deserialize<T>(batch.FirstOrDefault());

            }
            catch (Exception)
            {

                return new T { _id = null };
            }

        }
        public List<T> BringBack(BsonDocument filter)
        {
            try
            {
                var results = new List<T>();
                using (var cursor = Table.FindSync(filter))
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

        public virtual bool Insert(T entity)
        {
            try
            {
                Table.InsertOne(entity.ToBsonDocument());


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public virtual bool InsertMany(params T[] entities)
        {
            try
            {
                Table.InsertMany(entities.Select(x => x.ToBsonDocument()));


                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public virtual bool Update(string id, T entity)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                var bsonEntity = entity.ToBsonDocument();
                var update = new BsonDocument { { "$set", bsonEntity } };
                Table.UpdateOne(filter, update);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
