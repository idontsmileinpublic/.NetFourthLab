using System;
namespace Lab4Maistrenko.Documents
{
    public class UniversalDocument
    {
        public Passport Passport { get; set; }
        public Insurance Insurance { get; set; }
        public Card Card { get; set; }

        public UniversalDocument(Passport passport, Insurance insurance, Card card)
        {
            Passport = passport;
            Insurance = insurance;
            Card = card;

        }

        public bool CanDrink()
        {
            return Passport.CanDrink();
        }

        public bool GetMoney(int sum, string reason)
        {
            return Insurance.GetMoney(sum, reason, Card);
        }

        public void Put(int sum)
        {
            Card.Put(sum);
        }
    }
}
