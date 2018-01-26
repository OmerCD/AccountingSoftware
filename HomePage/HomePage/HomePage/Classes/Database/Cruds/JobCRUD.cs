using System;
using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace HomePage.Classes.Database.Cruds
{
    public class JobCRUD : CRUD<Job>
    {
        public JobCRUD() : base(DbFactory.Job)
        {

        }

        public bool CheckIfJobExists(DateTime date)
        {
            BsonDocument testDoc = GenerateDayCheckDocument(date);
            var testFilter = new BsonDocument
                {
                    {
                        "EventDate",
                        testDoc
                    },
                    {
                        "IsDeleted",
                        0
                    }
                };
            var cursor = Table.FindSync<Job>(testFilter);
            return cursor.Any();
        }


        public Job[] GetJobsAtGivenDate(DateTime date)
        {
            try
            {
                var testDoc = GenerateDayCheckDocument(date);
                var testFilter = new BsonDocument
                {
                    {
                        "EventDate",
                        testDoc
                    },
                    {
                        "IsDeleted",
                        0
                    }
                };
                var cursor = Table.FindSync<Job>(testFilter);
                cursor.MoveNext();
                var batch = cursor.Current;
                return batch.ToArray();
            }
            catch (Exception)
            {

                return new Job[0];
            }
        }
    }
}
