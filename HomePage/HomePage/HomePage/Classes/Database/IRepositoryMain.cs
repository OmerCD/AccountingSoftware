﻿using MongoDB.Bson;
using System.Collections.Generic;

namespace HomePage.Classes.Database
{
    public interface IRepositoryMain<T>
    {
        bool Insert(T entity);
        bool InsertMany(params T[] entities);
        bool Delete(string id);
        bool Update(string id, T entity);
        List<T> GetAll(BsonDocument filter);
        T GetOne(string id);
    }
}
