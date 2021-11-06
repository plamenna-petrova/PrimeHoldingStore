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

            var productDiscount = product.CalculateProductDiscount(dateTimeOfPurchase);

            var baseProductPrice = Math.Round(product.Price * product.Quantity, 2);

            var discountPercentage = Math.Round((productDiscount / baseProductPrice) * 100);

            switch (productType)
            {
                case "Food":
                case "Beverage":
                    if (discountPercentage == 50)
                    {
                        Console.WriteLine($"#discount 50% -${Math.Round(productDiscount, 2):F2}");
                    }
                    else if (discountPercentage == 10)
                    {
                        Console.WriteLine($"#discount 10% -${Math.Round(productDiscount, 2):F2}");
                    }
                    break;
                case "Clothes":
                    if (discountPercentage == 10)
                    {
                        Console.WriteLine($"#discount 10% -${Math.Round(productDiscount, 2):F2}");
                    }
                    break;
                case "Appliances":
                    if (discountPercentage == 5)
                    {
                        Console.WriteLine($"#discount 5% -${Math.Round(productDiscount, 2):F2}");
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
