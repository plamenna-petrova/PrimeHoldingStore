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
                shoppingItem.GetProductDiscount(dateTimeOfPurchase);
                Console.WriteLine();
            }
        }
    }
}
