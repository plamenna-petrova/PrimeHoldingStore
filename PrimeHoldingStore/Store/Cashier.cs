using PrimeHoldingStore.Models;
using PrimeHoldingStore.Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeHoldingStore.Store
{
    public class Cashier : ICashier
    {
        public Cashier()
        {
           
        }


        public void PrintDiscount(Product product, DateTime dateTimeOfPurchase)
        {
            var productType = product.GetType().Name;

            var purchaseDayOfWeek = dateTimeOfPurchase.DayOfWeek;

            var productDiscount = product.CalculateProductDiscount(dateTimeOfPurchase);

            switch (productType)
            {
                case "Food":
                case "Beverage":
                    var perishableProduct = product as PerishableProduct;
                    var totalDaysFromPurchaseDateTime = perishableProduct.ExpirationDate.Subtract(dateTimeOfPurchase).TotalDays;
                    if (perishableProduct.ExpirationDate.Date.Equals(dateTimeOfPurchase.Date))
                    {
                        Console.WriteLine($"#discount 50% ${productDiscount:F2}");
                    }
                    else if (totalDaysFromPurchaseDateTime > 0 && totalDaysFromPurchaseDateTime <= 5)
                    {
                        Console.WriteLine($"#discount 10% ${productDiscount:F2}");
                    }
                    break;
                case "Clothes":
                    if (purchaseDayOfWeek >= DayOfWeek.Monday && purchaseDayOfWeek <= DayOfWeek.Friday)
                    {
                        Console.WriteLine($"#discount 10% ${productDiscount:F2}");
                    }
                    break;
                case "Appliances":
                    if (product.Price > 999 && (purchaseDayOfWeek >= DayOfWeek.Saturday && purchaseDayOfWeek <= DayOfWeek.Sunday))
                    {
                        Console.WriteLine($"#discount 5% ${productDiscount:F2}");
                    }
                    break;
            }
        }

        public void PrintReceipt(Cart cart, DateTime dateTimeOfPurchase)
        {
            Console.WriteLine($"Date: {dateTimeOfPurchase.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine();
            Console.WriteLine("--Products--");
            Console.WriteLine();
            foreach (var shoppingItem in cart.GetProducts())
            {
                shoppingItem.PrintKeyProductInformation();
                shoppingItem.PrintBasePriceInformation();
                PrintDiscount(shoppingItem, dateTimeOfPurchase);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            cart.CalculatePayment(cart.GetProducts(), dateTimeOfPurchase);
        }
    }
}
