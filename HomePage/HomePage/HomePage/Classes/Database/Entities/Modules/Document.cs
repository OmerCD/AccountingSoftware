using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
   public class Document : DbObject
    {
        [Custom(FieldName ="Evrak Adı",MinLength = 3,MaxLength = 128,PlaceHolderText ="Evrak Adı")]
        public string DocumentName { get; set; }
        public string UserId { get; set; }
        public DateTime LastEdit { get; set; }

    }
    public class Column : DbObject
    {
        public string DocumentId { get; set; }
        public string ColumnName { get; set; }
        public string[] Answers { get; set; }
        public int SelectedAnswerIndex { get; set; }
    }
   
}
