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

        public void CalculatePayment(List<Product> products, DateTime purchaseDateTime)
        {
            double subtotal = 0;
            double discountSum = 0;

            foreach (var product in products)
            {
                subtotal += Math.Round((product.Price * product.Quantity), 2);
                discountSum += product.CalculateProductDiscount(purchaseDateTime);
            }

            Console.WriteLine($"SUBTOTAL: ${subtotal}");
            Console.WriteLine($"DISCOUNT: -${discountSum}");
            Console.WriteLine();
            Console.WriteLine($"TOTAL: ${subtotal - discountSum}");
        }
    }
}
