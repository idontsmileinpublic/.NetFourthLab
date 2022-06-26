using System;
using Lab4Maistrenko.Helpers;

namespace Lab4Maistrenko.Documents
{
    public class Passport
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string RecordNumber { get; set; }
        public long DocumentNumber { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public DateTime DateOfIssue { get; set; }
        public int Authority { get; set; }
        public string PlaceOfBirth { get; set; }

        public bool CanDrink()
        {
            return DateTime.Now.AddYears(-DateOfBirth.Year)
                               .AddMonths(-DateOfBirth.Month)
                               .AddDays(-DateOfBirth.Day)
                               .Year >= 18;
        }
    }
}
