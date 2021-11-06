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
            apples.Quantity = 2.45;

            Product milk = new Beverage("milk", "BrandM", 0.99, new DateTime(2022, 2, 2));
            milk.Quantity = 3;

            Product tShirt = new Clothes("T-shirt", "BrandT", 15.99, Size.M, "violet");
            tShirt.Quantity = 2;

            Product laptop = new Appliances("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 3, 3), 1.125);
            laptop.Quantity = 1;

            Cart sampleCart = new Cart();
            sampleCart.AddProductToCart(apples, apples.Quantity);
            sampleCart.AddProductToCart(milk, milk.Quantity);
            sampleCart.AddProductToCart(tShirt, tShirt.Quantity);
            sampleCart.AddProductToCart(laptop, laptop.Quantity);

            Cashier cashier = new Cashier();
            var purchaseDate = new DateTime(2021, 6, 14, 12, 34, 56);
            cashier.PrintReceipt(sampleCart, purchaseDate);
        }
    }
}
