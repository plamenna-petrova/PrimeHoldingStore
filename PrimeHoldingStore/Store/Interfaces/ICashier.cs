using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Store.Interfaces
{
    public interface ICashier
    {
        void PrintReceipt(Cart cart, DateTime dateTimeOfPurchase);
    }
}
