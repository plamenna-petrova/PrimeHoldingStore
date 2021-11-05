using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public class Beverage : PerishableProduct
    {
        public Beverage(string name, string brand, double price, DateTime expirationDate)
            :base(name, brand, price, expirationDate)
        {

        }
    }
}
