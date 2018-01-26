using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace HomePage.Classes.Database.Cruds
{
    public class DayEventCRUD : CRUD<DayEvent>
    {
        internal DayEvent GetOne(string columnName, DateTime dateTime)
        {
            try
            {
                var testDoc = GenerateDayCheckDocument(dateTime);
                var testFilter = new BsonDocument
                {
                    {
                        columnName,
                        testDoc
                    },
                    {
                        "IsDeleted",
                        0
                    }
                };
                var cursor = Table.FindSync<DayEvent>(testFilter);
                cursor.MoveNext();
                var batch = cursor.Current;
                return batch.FirstOrDefault();
            }
            catch (Exception)
            {

                return new DayEvent { _id = null };
            }
        }
    }
}
