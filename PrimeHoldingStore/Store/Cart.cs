using PrimeHoldingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeHoldingStore.Store
{
    public class Cart
    {
        private List<Product> productsToPurchase;

        public Cart()
        {
            productsToPurchase = new List<Product>();
        }

        public void AddProductToCart(Product product)
        {
            if (product != null)
            {
                productsToPurchase.Add(product);
            }
        }

        public List<Product> GetProducts()
        {
            return productsToPurchase.ToList();
        }
    }
}
