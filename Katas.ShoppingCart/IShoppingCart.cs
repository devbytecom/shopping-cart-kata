namespace Katas.ShoppingCart
{
    public interface IShoppingCart
    {
        void Scan(string item);
        int TotalItems();
        decimal TotalPrice();
    }
}
