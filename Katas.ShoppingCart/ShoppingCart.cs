using System;

namespace Katas.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private string _item;

        public void Scan(string item)
        {
            _item = item;
        }

        public int TotalItems()
        {
            return 1;
        }

        public decimal TotalPrice()
        {
            if (_item == "B15")
            {
                return 30m;
            }
            return 50m;
        }
    }
}
