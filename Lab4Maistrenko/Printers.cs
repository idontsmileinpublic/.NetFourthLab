using System;
using Lab4Maistrenko.Documents;

namespace Lab4Maistrenko
{
    public class Printers
    {
        public static void PrintIfCanDrink()
        {
            var result = Data.CreateDocument();
            Console.WriteLine($"Can drink: {result.CanDrink()};");
        }

        public static void PrintPut()
        {
            var result = Data.CreateDocument();
            result.Card.Put(200);
            Console.WriteLine($"Can drink: {result.Card};");
        }

        public static void GetMoney()
        {
            var result = Data.CreateDocument();
            result.Insurance.GetMoney(500, "fjkdjfksjflkjdsklfjdskfjdlskjflkdsjfkdsjfkdsjfkdjskfjdsklfjkdlsjflkdsjfksdjfkldsjfkldsjfkldjsfksdjflkdsjfkdsjflksdjfklsdjfkdsjfklsdjfksdjflksdjfkldsjfkdsjflksdjfkldsjfksdjfksdjfklsdjfkldsjfkldsjfkldsjfklsdjfklsdjfksdjfkdsjfksdjlfksdjlfksdjflksdjflskdjflkdsjfksdljfkdsjfoerutioertierhgjkfdgjslfksdjfk;ldnvmcnv,fbglkdfjgfdsk", result.Card);
            Console.WriteLine($"Can drink: {result.Card};");
        }
    }
}
