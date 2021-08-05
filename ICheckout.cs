using Kata.Products;
using System.Collections.Generic;

namespace Kata
{
    public interface ICheckout
    {
        List<Item> ScannedItems { get; set; }

        void Scan(IEnumerable<Item> items);
        decimal GetTotalPrice();
    }
}