using PrimeHoldingStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Store.Interfaces
{
    public interface ICashier
    {
        void PrintDiscount(Product product, DateTime dateTimeOfPurchase);

        void PrintReceipt(Cart cart, DateTime dateTimeOfPurchase);
    }
}
