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

        public override void GetProductDiscount(DateTime purchaseDate)
        {
            double perishablesDiscount = 0;

            if (ExpirationDate.Date == purchaseDate.Date)
            {
                perishablesDiscount = 0.50 * (price * quantity);
                Console.WriteLine($"#discount 50% - ${Math.Round(perishablesDiscount, 2)}");
            }
            else if (ExpirationDate.Subtract(purchaseDate).TotalDays > 0 && ExpirationDate.Subtract(purchaseDate).TotalDays <= 5)
            {
                perishablesDiscount = 0.10 * (price * quantity);
                Console.WriteLine($"#discount 10% - ${Math.Round(perishablesDiscount, 2)}");
            }
        }
    }
}
