using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public class Appliances : Product
    {
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Weight { get; set; }

        public Appliances(string name, string brand, double price, string model, DateTime productionDate, double weight)
            : base(name, brand, price)
        {
            Model = model;
            ProductionDate = productionDate;
            Weight = weight;
        }

        public override void PrintKeyProductInformation()
        {
            Console.WriteLine($"{name} {brand} {Model}");
        }

        public override void PrintBasePriceInformation()
        {
            base.PrintBasePriceInformation();
        }

        public override double CalculateProductDiscount(DateTime purchaseDateTime)
        {
            double appliancesDiscount = 0;

            var purchaseDayOfWeek = purchaseDateTime.DayOfWeek;

            if ((price * quantity) > 999 && (purchaseDayOfWeek == DayOfWeek.Saturday || purchaseDayOfWeek == DayOfWeek.Sunday))
            {
                appliancesDiscount = 0.05 * (price * quantity);
            }

            return Math.Round(appliancesDiscount, 2);
        }
    }
}
