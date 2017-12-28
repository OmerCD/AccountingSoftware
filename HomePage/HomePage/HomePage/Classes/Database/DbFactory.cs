using HomePage.Classes.Database.Cruds;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomePage.Document;

namespace HomePage.Classes.Database
{
    public class DbFactory
    {
        //public static IMongoClient Client = new MongoClient("mongodb://mustafarumeli:2dDfShKEX9rbc6e2eHxedLaouu8glHyZE9Ghz5PauBTfBkhpIWhvZuwxsgal1bnhQ2ZIQdIgjxDSrfT6XjS9YA==@mustafarumeli.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
        public static IMongoClient Client = new MongoClient();
        private static IMongoDatabase _database;

        public static IMongoDatabase Database => _database ?? (_database = Client.GetDatabase("test2"));

        private static IMongoCollection<BsonDocument> _user;
        private static IMongoCollection<BsonDocument> _companyColumnIndex;
        private static IMongoCollection<BsonDocument> _column;
        private static IMongoCollection<BsonDocument> _company;
        private static IMongoCollection<BsonDocument> _job;
        private static IMongoCollection<BsonDocument> _calendar;
        private static IMongoCollection<BsonDocument> _companyLogin;
        private static IMongoCollection<BsonDocument> _personnel;


        public static IMongoCollection<BsonDocument> User => _user ?? (_user = Database.GetCollection<BsonDocument>(typeof(Entities.User).Name));
        public static IMongoCollection<BsonDocument> Personnel => _personnel ?? (_personnel = Database.GetCollection<BsonDocument>(typeof(Entities.Personnel).Name));
        public static IMongoCollection<BsonDocument> CompanyColumnIndex => _companyColumnIndex ?? (_companyColumnIndex = Database.GetCollection<BsonDocument>(typeof(CompanyColumnIndex).Name));
        public static IMongoCollection<BsonDocument> Column => _column ?? (_column = Database.GetCollection<BsonDocument>(typeof(Column).Name));
        public static IMongoCollection<BsonDocument> Company => _company ?? (_company = Database.GetCollection<BsonDocument>(typeof(Entities.Company).Name));
        public static IMongoCollection<BsonDocument> Job => _job ?? (_job = Database.GetCollection<BsonDocument>(typeof(Entities.Job).Name));
        public static IMongoCollection<BsonDocument> Calendar => _calendar ?? (_calendar = Database.GetCollection<BsonDocument>(typeof(Entities.Calendar).Name));
        public static IMongoCollection<BsonDocument> CompanyLogin => _companyLogin ?? (_companyLogin = Database.GetCollection<BsonDocument>(typeof(Entities.CompanyLogin).Name));


        private static UserCRUD _userCRUD;
        private static CompanyColumnIndexCRUD _companyColumnIndexCRUD;
        private static ColumnCRUD _columnCRUD;
        private static CompanyCRUD _companyCRUD;
        private static JobCRUD _jobCRUD;
        private static CalendarCRUD _calendarCRUD;
        private static CompanyLoginCRUD _companyLoginCRUD;

        public static UserCRUD UserCRUD => _userCRUD ?? (_userCRUD = new UserCRUD());
        public static CompanyColumnIndexCRUD CompanyColumnIndexCRUD => _companyColumnIndexCRUD ?? (_companyColumnIndexCRUD = new CompanyColumnIndexCRUD());
        public static ColumnCRUD ColumnCRUD => _columnCRUD ?? (_columnCRUD = new ColumnCRUD());
        public static CompanyCRUD CompanyCRUD => _companyCRUD ?? (_companyCRUD = new CompanyCRUD());
        public static JobCRUD JobCRUD => _jobCRUD ?? (_jobCRUD = new JobCRUD());
        public static CalendarCRUD CalendarCRUD => _calendarCRUD ?? (_calendarCRUD = new CalendarCRUD());
        public static CompanyLoginCRUD CompanyLoginCRUD => _companyLoginCRUD ?? (_companyLoginCRUD = new CompanyLoginCRUD());


    }
}
