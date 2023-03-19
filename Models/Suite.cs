using System;
using hotelChallengeDio;

namespace hotelChallengeDio.Models
{
    public class Suite
    {
        public Suite() {}
        public Suite(String suiteType, int capacity, decimal price)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            Price = price;
        }

        public string SuiteType { set; get; }
        public int Capacity { set; get; }
        public decimal Price { set; get; }
    }
}