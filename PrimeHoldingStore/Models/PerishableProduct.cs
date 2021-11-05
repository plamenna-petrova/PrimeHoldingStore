using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public class PerishableProduct : Product
    {
        public DateTime ExpirationDate { get; set; }

        public PerishableProduct(string name, string brand, double price, DateTime expirationDate)
            : base(name, brand, price)
        {
            ExpirationDate = expirationDate;
        }

        public override void PrintKeyProductInformation()
        {
            Console.WriteLine($"{name} {brand}");
        }

        public override void PrintBasePriceInformation()
        {
            base.PrintBasePriceInformation();
        }
    }
}
