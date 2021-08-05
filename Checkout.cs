using Kata.Products;

using System.Collections.Generic;

namespace Kata
{
    public class Checkout : ICheckout
    {
        public List<Item> ScannedItems { get; set; } = new();

        public void Scan(Item item)
        {
            ScannedItems.Add(item);
        }
    }
}