using System;

namespace HomePage.Classes.Database.Entities
{
    public class Job : DbObject
    {  //Sequential mantığı eklenecek
      
        public Job()
        {

        }

        public Job(User[] personnel, DateTime eventDate, Company company, string description, string documentAddress,int lastWarningDays)
        {
            Personnel = personnel;
            EventDate = eventDate;
            Company = company;
            Description = description;
            DocumentAddress = documentAddress;
            IsDone = false;
            SetWarningDay(lastWarningDays);
        }

        public override string ToString()
        {
            return Name;
        }

        public void JobDone()
        {
            IsDone = true;
        }
        public void SetWarningDay(int numberOfDays)
        {
            WarningDay = EventDate.AddDays(numberOfDays * -1);
        }

        [Custom(FieldName ="Personel Adı",Searchable = true)]
        public User[] Personnel { get; set; } // if null it means all personnel is atented to this Job
        [Custom(FieldName ="Bitiş Tarihi")]
        public DateTime EventDate { get; set; }
        [Custom(FieldName = "Firma Adı",Searchable = true)]
        public Company Company { get; set; }
        [Custom(FieldName = "Açıklama",MaxLength = 500,Searchable = true)]
        public string Description { get; set; }//Description
        public string DocumentAddress { get; set; } // Pdf jpeg etc
        [Custom(FieldName = "Tamamlandı mı ?")]
        public bool IsDone { get; set; }
        public DateTime WarningDay { get; set; }
        [Custom(FieldName = "Önceki İş")]
        public Job PreviousJob { get; set; }
        [Custom(FieldName = "İş Adı",MinLength = 4,MaxLength = 25,Searchable = true)]
        public string Name { get; set; }
        [Custom(FieldName = "Yorumlar")]
        public Comment[] Comments { get; set; }

        public struct Comment
        {
            public Comment(User user, string message) : this()
            {
                User = user;
                Message = message;
                CreationTime = DateTime.Now;
            }

            public User User { get; set; }
            public string Message { get; set; }
            public DateTime CreationTime { get; set; }

        }
    }
}
