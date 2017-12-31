using System;
using HomePage.Classes.Database.Entities;

namespace HomePage.Document
{
   public class CompanyColumnIndex : DbObject
    {
        public Column Column { get; set; }
        public int AnswerIndex { get; set; }
        public Company Company { get; set; }
        public Personnel User { get; set; }
        public DateTime EditDate { get; set; }

    }
    public class Column : DbObject
    {
        public Column(int minRank=0)
        {
            MinRank = minRank;
        }

        public Column()
        {
        }

        public string[] PossibleAnswers { get; set; }
        public int MinRank { get; set; }
        public string Name { get; set; }
    }

   
}
