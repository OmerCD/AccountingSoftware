using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database
{
    public interface IRepositoryMain<T>
    {
        bool Insert(params T[] entities);
        bool Delete(string id);
        bool Update(string id, T entity);
        List<T> GetAll(BsonDocument filter);
        T GetOne(string id);
    }
}
