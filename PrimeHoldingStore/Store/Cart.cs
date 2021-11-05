using PrimeHoldingStore.Models;
using PrimeHoldingStore.Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeHoldingStore.Store
{
    public class Cart : ICart
    {
        private List<Product> productsToPurchase;

        public Cart()
        {
            productsToPurchase = new List<Product>();
        }

        public void AddProductToCart(Product product, double quantity)
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
