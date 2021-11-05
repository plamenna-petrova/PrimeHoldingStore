using PrimeHoldingStore.Models;
using PrimeHoldingStore.Models.Enums;
using System;

namespace PrimeHoldingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apples = new Food("apple", "BrandA", 1.50, new DateTime(2021-06-14));
            apples.PrintKeyProductInformation();

            Product milk = new Beverage("milk", "BrandM", 0.99, new DateTime(2022-02-02));
            milk.PrintKeyProductInformation();

            Product tShirt = new Clothes("T-shirt", "BrandT", 15.99, Size.M, "violet");
            tShirt.PrintKeyProductInformation();

            Product laptop = new Appliances("laptop", "BrandL", 2345, "ModelL", new DateTime(2021 - 03 - 03), 1.125);
            laptop.PrintKeyProductInformation();
        }
    }
}
