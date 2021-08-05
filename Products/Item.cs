namespace Kata.Products
{
    /// <summary>
    /// Base class for all products
    /// Should not be instantiated, hence marked as abstract
    /// </summary>
    public abstract class Item : IItem
    {
        public decimal Price { get; set; }

        public Item(decimal price)
        {
            Price = price;
        }
    }
}
