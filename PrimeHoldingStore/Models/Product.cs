using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models
{
    public abstract class Product
    {
        protected string name;
        protected string brand;
        protected double price;
        protected double quantity;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public double Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Product(string name, string brand, double price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
        }

        public abstract void PrintKeyProductInformation();

        public virtual void PrintBasePriceInformation()
        {
            Console.WriteLine($"{quantity} x ${price:F2} = ${Math.Round(price * quantity, 2):F2}");
        }

        public abstract double CalculateProductDiscount(DateTime purchaseDateTime);
    }
}
