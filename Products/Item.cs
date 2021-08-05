namespace Kata.Products
{
    /// <summary>
    /// Base class for all products
    /// Should not be instantiated, hence marked as abstract
    /// </summary>
    public abstract class Item : IItem
    {
        public decimal Price { get; set; }
        public int DiscountToQualifyQuantity { get; set; }
        public decimal DiscountAmount { get; set; }

        public Item(decimal price, int discountToQualifyQuantity, decimal discountAmount)
        {
            Price = price;
            DiscountToQualifyQuantity = discountToQualifyQuantity;
            DiscountAmount = discountAmount;
        }
    }
}
