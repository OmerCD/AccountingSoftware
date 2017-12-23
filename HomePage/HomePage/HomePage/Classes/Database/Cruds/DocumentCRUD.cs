using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePage.Classes.Database.Entities.Modules;

namespace HomePage.Classes.Database.Cruds
{
    public  class DocumentCRUD : CRUD<Document>
    {
        public DocumentCRUD()
        {
            Table = DbFactory.Document;
        }
       
       public  async Task<Tuple<Document,List<Column>>> GetOneFullDocument(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                using (IAsyncCursor<BsonDocument> cursor = await Table.FindAsync(filter))
                {
                    Document document = Newtonsoft.Json.JsonConvert.DeserializeObject<Document>(cursor.First().ToString());
                    List<Column> columns =  await DbFactory.ColumnCRUD.GetColumn(document._id);
                    return Tuple.Create(document, columns);
                }

            }
            catch (Exception ex)
            {

                return null;
            }
            
        }
        
    }
}
