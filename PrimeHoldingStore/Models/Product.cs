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

        public Product(string name, string brand, double price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
        }

        public abstract void PrintKeyProductInformation();
    }
}
