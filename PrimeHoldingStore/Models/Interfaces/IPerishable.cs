using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeHoldingStore.Models.Interfaces
{
    public interface IPerishable
    {
        DateTime ExpirationDate { get; set; }
    }
}
