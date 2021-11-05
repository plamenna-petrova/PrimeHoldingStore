using PrimeHoldingStore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public class Beverage : Product, IPerishable
    {
        public DateTime ExpirationDate { get; set; }

        public Beverage(string name, string brand, double price, DateTime expirationDate)
            : base(name, brand, price)
        {
            ExpirationDate = expirationDate;
        }

        public override void PrintKeyProductInformation()
        {
            Console.WriteLine($"{name} {brand}");
        }
    }
}
