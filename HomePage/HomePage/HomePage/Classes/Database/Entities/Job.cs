using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
    public class Job : DbObject
    {  //Sequential mantığı eklenecek
      
        public Job()
        {

        }

        public Job(User[] personnel, DateTime deadLine, Company company, string description, string documentAddress,int lastWarningDays)
        {
            Personnel = personnel;
            DeadLine = deadLine;
            Company = company;
            Description = description;
            DocumentAddress = documentAddress;
            IsDone = false;
            SetWarningDay(lastWarningDays);
        }

        public void JobDone()
        {
            IsDone = true;
        }
        public void SetWarningDay(int numberOfDays)
        {
            WarningDay = DeadLine.AddDays(numberOfDays * -1);
        }

        [Custom(FieldName ="Personel Adı")]
        public User[] Personnel { get; set; } // if null it means all personnel is atented to this Job
        [Custom(FieldName ="Bitiş Tarihi")]
        public DateTime DeadLine { get; set; }
        [Custom(FieldName = "Firma Adı")]
        public Company Company { get; set; }
        [Custom(FieldName = "Açıklama")]
        public string Description { get; set; }//Description
        public string DocumentAddress { get; set; } // Pdf jpeg etc
        [Custom(FieldName = "Tamamlandı mı ?")]
        public bool IsDone { get; set; }
        public DateTime WarningDay { get; set; }
       
    }
}
