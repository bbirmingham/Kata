using Kata.Products;

using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Checkout : ICheckout
    {
        public List<Item> ScannedItems { get; set; } = new();

        public void Scan(IEnumerable<Item> items)
        {
            ScannedItems = ScannedItems.Concat(items).ToList();
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0m;

            foreach (Item item in ScannedItems)
            {
                total += item.Price;
            }

            return total;
        }
    }
}