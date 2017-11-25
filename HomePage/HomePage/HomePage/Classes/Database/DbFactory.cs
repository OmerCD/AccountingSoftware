using HomePage.Classes.Database.Cruds;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database
{
    public class DbFactory
    {
        //public static IMongoClient Client = new MongoClient("mongodb://mustafarumeli:2dDfShKEX9rbc6e2eHxedLaouu8glHyZE9Ghz5PauBTfBkhpIWhvZuwxsgal1bnhQ2ZIQdIgjxDSrfT6XjS9YA==@mustafarumeli.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
        public static IMongoClient Client = new MongoClient();
        private static IMongoDatabase _database;

        public static IMongoDatabase Database => _database ?? (_database = Client.GetDatabase("test"));

        private static IMongoCollection<BsonDocument> _user;
        private static IMongoCollection<BsonDocument> _document;
        private static IMongoCollection<BsonDocument> _column;


        private static UserCRUD _userCRUD;
        private static DocumentCRUD  _documentCRUD;
        private static ColumnCRUD _columnCRUD;

        public static IMongoCollection<BsonDocument> User => _user ?? (_user = Database.GetCollection<BsonDocument>(typeof(Entities.User).Name));
        public static UserCRUD UserCRUD => _userCRUD ?? (_userCRUD = new UserCRUD());
        public static DocumentCRUD DocumentCRUD => _documentCRUD ?? (_documentCRUD = new DocumentCRUD());
        public static ColumnCRUD ColumnCRUD => _columnCRUD ?? (_columnCRUD = new ColumnCRUD());

        public static IMongoCollection<BsonDocument> Document => _document ?? (_document = Database.GetCollection<BsonDocument>(typeof(Entities.Document).Name));
        public static IMongoCollection<BsonDocument> Column => _column ?? (_column = Database.GetCollection<BsonDocument>(typeof(Entities.Column).Name));

    }
}
