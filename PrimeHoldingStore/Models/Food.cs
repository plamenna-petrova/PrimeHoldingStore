using PrimeHoldingStore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public class Food : Product, IPerishable
    {
        public DateTime ExpirationDate { get; set; }

        public Food(string name, string brand, double price, DateTime expirationDate)
            : base(name, brand, price)
        {
            ExpirationDate = expirationDate;
        }

        public override void PrintKeyProductInformation()
        {
            Console.WriteLine($"{name} {brand} {ExpirationDate}");
        }
    }
}
