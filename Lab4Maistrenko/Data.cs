using System;
using System.Collections.Generic;
using Lab4Maistrenko.Documents;

namespace Lab4Maistrenko
{
    public class Data
    {
        public static List<Passport> Passports = new List<Passport>
        {
            new Passport ()
            {
                Name = "Mariana",
                Patronymic = "Ivanivna",
                Surname = "Tkachenko",
                Sex = Helpers.Sex.Female,
                DateOfBirth = new DateTime(1991, 08, 24),
                DateOfExpiry = new DateTime(2025, 12, 13),
                DateOfIssue = new DateTime(2015, 12, 13),
                Nationality = "UKR",
                RecordNumber = "19910824-00026",
                DocumentNumber = 000000000,
                Authority = 1234,
                PlaceOfBirth = "Kyiv"
            },

            new Passport ()
            {
                Name = "Sofiia",
                Patronymic = "Oleksandrivna",
                Surname = "Soniashnykova",
                Sex = Helpers.Sex.Female,
                DateOfBirth = new DateTime(2005, 07, 21),
                DateOfExpiry = new DateTime(2024, 01, 08),
                DateOfIssue = new DateTime(2018, 01, 08),
                Nationality = "UKR",
                RecordNumber = "19910823-00021",
                DocumentNumber = 000000000,
                Authority = 1652,
                PlaceOfBirth = "Kherson"
            }
        };

        public static List<Card> Cards = new List<Card>
        {
            new Card ()
            {
                CardNumber = 1234_5678_9012_3456,
                Bank = "Ukraine_Bank",
                CVV2 = 123,
                DateOfExpiry = new DateTime(2025, 11, 01),
                Sum = 5000
            },

            new Card ()
            {
                CardNumber = 8899_4478_1012_8438,
                Bank = "MonoBank",
                CVV2 = 788,
                DateOfExpiry = new DateTime(2022, 09, 01),
                Sum = 250
            }
        };

        public static List<Insurance> Insurances = new List<Insurance>
        {
            new Insurance()
            {
                Name = "Mariana",
                Patronymic = "Ivanivna",
                Surname = "Tkachenko",
                PassportNumber = 1902642,
                Company = 1817,
                DocumentNumber = 19028_78923,
                DateOfExpiry = new DateTime(2029, 10, 01),
                DateOfIssue = new DateTime (2019, 10, 01)
            }
        };

        public static Insurance GetInsurance()
        {
            var result = Data.Insurances[0];
            return result;
        }

        public static Card GetCard()
        {
            var result = Data.Cards[0];
            return result;
        }

        public static Passport GetPassport()
        {
            var result = Data.Passports[0];
            return result;
        }

        public static UniversalDocument CreateDocument()
        {
            var passport = GetPassport();
            var insurance = GetInsurance();
            var card = GetCard();
            var doc = new UniversalDocument(passport, insurance, card);

            return doc;
        }
    }
}
