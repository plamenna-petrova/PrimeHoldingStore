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

        public override double CalculateProductDiscount(DateTime purchaseDateTime)
        {
            double perishablesDiscount = 0;

            var totalDaysFromPurchaseDate = ExpirationDate.Subtract(purchaseDateTime).TotalDays;
            
            if (ExpirationDate.Date.Equals(purchaseDateTime.Date))
            {
                perishablesDiscount = 0.50 * (price * quantity);
            }
            else if (totalDaysFromPurchaseDate > 0 && totalDaysFromPurchaseDate <= 5)
            {
                perishablesDiscount = 0.10 * (price * quantity);
            }

            double roundedPerishablesDiscount = Math.Round(perishablesDiscount, 2);
            return roundedPerishablesDiscount;
        }
    }
}
