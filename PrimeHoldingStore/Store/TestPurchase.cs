using PrimeHoldingStore.Models;
using PrimeHoldingStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Store
{
    public class TestPurchase
    {
        public TestPurchase()
        {

        }

        public void PrintTestPurchaseInformation()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------Test-Purchase-------------------------------------");
            Console.WriteLine();

            Product banana = new Food("banana", "BrandB", 2.15, new DateTime(2021, 11, 7));
            banana.Quantity = 4.35;

            Product cocaCola = new Beverage("coca cola", "BrandCC", 1.15, new DateTime(2021, 11, 6));
            cocaCola.Quantity = 1;

            Product orangeJuice = new Beverage("orange juice", "BrandOJ", 1.45, new DateTime(2021, 11, 11));
            orangeJuice.Quantity = 2;

            Product jumper = new Clothes("Jumper", "BrandJ", 39.99, Size.M, "red");
            jumper.Quantity = 3;

            Product playstation = new Appliances("PS5", "BrandS5", 999, "ModelS5", new DateTime(2021, 3, 3), 1.125);
            playstation.Quantity = 2;

            Product gamingPC = new Appliances("Gaming PC", "BrandPC", 999, "ModelPC", new DateTime(2020, 9, 8), 3.235);
            gamingPC.Quantity = 1;

            Cart testShoppingCart = new Cart();
            testShoppingCart.AddProductToCart(banana, banana.Quantity);
            testShoppingCart.AddProductToCart(orangeJuice, orangeJuice.Quantity);
            testShoppingCart.AddProductToCart(cocaCola, cocaCola.Quantity);
            testShoppingCart.AddProductToCart(jumper, jumper.Quantity);
            testShoppingCart.AddProductToCart(playstation, playstation.Quantity);
            testShoppingCart.AddProductToCart(gamingPC, gamingPC.Quantity);

            Cashier cashier = new Cashier();
            var testPurchaseDateTime = new DateTime(2021, 11, 6, 18, 30, 50);
            cashier.PrintReceipt(testShoppingCart, testPurchaseDateTime);
        }
    }
}
