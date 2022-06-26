using System;
namespace Lab4Maistrenko.Documents
{
    public class Insurance
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public long PassportNumber { get; set; }

        public DateTime DateOfExpiry { get; set; }
        public long DocumentNumber { get; set; }

        public DateTime DateOfIssue { get; set; }
        public int Company { get; set; }

        public bool GetMoney(int sum, string reason, Card card)
        {
            if (!IsSignificant(reason))
                return false;

            card.Put(sum);
            return true;
        }

        private bool IsSignificant(string reason)
        {
            return reason.Length > 300;
        }
    }
}
