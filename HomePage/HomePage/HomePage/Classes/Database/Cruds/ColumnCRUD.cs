using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Cruds
{
    public class ColumnCRUD : CRUD<Column>
    {
        public ColumnCRUD()
        {
            Table = DbFactory.Column;
        }

       public async Task<List<Column>> GetColumn(string documentId)
        {
            try
            {

                var results = new List<Column>();
                BsonDocument filter = new BsonDocument { { "DocumentId", documentId }};
                using (IAsyncCursor<BsonDocument> cursor = await Table.FindAsync(filter))
                {
                    var x = cursor.ToList();
                    results.AddRange(x.Select(item => Newtonsoft.Json.JsonConvert.DeserializeObject<Column>(item.ToString())));
                }
                results = results.Where(x => x.IsDeleted == 0).ToList();
                return results;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
