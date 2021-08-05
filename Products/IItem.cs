namespace Kata.Products
{
    public interface IItem
    {
        decimal DiscountAmount { get; set; }
        int DiscountToQualifyQuantity { get; set; }
        decimal Price { get; set; }
    }
}