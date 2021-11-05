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

        public void PrintReceipt(Cart cart)
        {
            foreach (var shoppingItem in cart.GetProducts())
            {
                shoppingItem.PrintKeyProductInformation();
            }
        }
    }
}
