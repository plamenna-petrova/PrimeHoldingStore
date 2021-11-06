using PrimeHoldingStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public class Clothes : Product
    {
        public Size Size { get; set; }

        public string Color { get; set; }

        public Clothes(string name, string brand, double price, Size size, string color)
            : base(name, brand, price)
        {
            Size = size;
            Color = color;
        }

        public override void PrintKeyProductInformation()
        {
            Console.WriteLine($"{name} {brand} {Size} {Color}");
        }

        public override void PrintBasePriceInformation()
        {
            base.PrintBasePriceInformation();
        }

        public override double CalculateProductDiscount(DateTime purchaseDateTime)
        {
            double clothesDiscount = 0;

            var purchaseDayOfWeek = purchaseDateTime.DayOfWeek;

            if (purchaseDayOfWeek >= DayOfWeek.Monday && purchaseDayOfWeek <= DayOfWeek.Friday)
            {
                clothesDiscount = 0.10 * (price * quantity);
            }

            return Math.Round(clothesDiscount, 2);
        }
    }
}
