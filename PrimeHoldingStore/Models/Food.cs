using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public class Food : PerishableProduct
    {
        public Food(string name, string brand, double price, DateTime expirationDate)
            : base(name, brand, price, expirationDate)
        {

        }
    }
}
