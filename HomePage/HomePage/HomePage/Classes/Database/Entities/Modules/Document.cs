using System;

namespace HomePage.Classes.Database.Entities.Modules
{
   public class CompanyColumnIndex : DbObject
    {
        public string ColumnId { get; set; }
        public int AnswerIndex { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public DateTime LastEdit { get; set; }

    }
    public class Column : DbObject
    {
        public string ColumnName { get; set; }
        public string[] Answers { get; set; }
    }
   
}
