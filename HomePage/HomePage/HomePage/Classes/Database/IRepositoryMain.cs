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
        Task<bool> Insert(params T[] entities);
        Task<bool> Delete(string id);
        Task<bool> Update(string id, T entity);
        Task<List<T>> GetAll(BsonDocument filter);
        Task<T> GetOne(string id);
    }
}
