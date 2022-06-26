using System;

namespace Lab4Maistrenko.Documents
{
    public class Card
    {
        public long CardNumber { get; set; }
        public string Bank { get; set; }
        public int CVV2 { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public int Sum { get; set; }

        public void Put(int sum)
        {
            Sum += sum;
        }

        public override string ToString()
        {
            return $"{Sum}";
        }
    }
}
