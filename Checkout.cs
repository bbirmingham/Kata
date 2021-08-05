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

        public decimal GetTotalPriceWithSpecialOffers()
        {
            decimal total = GetTotalPrice();

            int countApple = 0;
            int countBiscuits = 0;
            //int countCarrot = 0;

            foreach (Item item in ScannedItems)
            {
                bool applyDiscount = false;

                // calculate if discount applicable with modulus operator on discount to qualify
                if (item.GetType() == typeof(Apple))
                {
                    countApple += 1;
                    applyDiscount = countApple % item.DiscountToQualifyQuantity == 0;
                }

                if (item.GetType() == typeof(Biscuits))
                {
                    countBiscuits += 1;
                    applyDiscount = countBiscuits % item.DiscountToQualifyQuantity == 0;
                }

                // Carrot has no special offer currently - unused
                //if (item.GetType() == typeof(Carrot))
                //{
                //    countCarrot += 1;
                //    applyDiscount = countCarrot % item.DiscountToQualifyQuantity == 0;
                //}

                // if we have to apply discount deduct from total
                if (applyDiscount)
                {
                    total -= item.DiscountAmount;
                }
            }

            return total;
        }
    }
}