namespace Katas.ShoppingCart
{
    public interface IItemPriceCalculator
    {
        decimal CalculatePrice(string item, int quantity);
    }
}
