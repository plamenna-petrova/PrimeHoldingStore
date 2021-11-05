using PrimeHoldingStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Store.Interfaces
{
    public interface ICart
    {
        void AddProductToCart(Product product);

        List<Product> GetProducts();
    }
}
