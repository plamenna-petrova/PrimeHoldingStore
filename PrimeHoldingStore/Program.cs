using PrimeHoldingStore.Models;
using PrimeHoldingStore.Models.Enums;
using PrimeHoldingStore.Store;
using System;

namespace PrimeHoldingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apples = new Food("apple", "BrandA", 1.50, new DateTime(2021, 6, 14));

            Product milk = new Beverage("milk", "BrandM", 0.99, new DateTime(2022, 2, 2));

            Product tShirt = new Clothes("T-shirt", "BrandT", 15.99, Size.M, "violet");

            Product laptop = new Appliances("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 3, 3), 1.125);

            Cart sampleCart = new Cart();
            sampleCart.AddProductToCart(apples);
            sampleCart.AddProductToCart(milk);
            sampleCart.AddProductToCart(tShirt);
            sampleCart.AddProductToCart(laptop);

            Cashier cashier = new Cashier();
            cashier.PrintReceipt(sampleCart, new DateTime(2021, 6, 14, 12, 34, 56));
        }
    }
}
