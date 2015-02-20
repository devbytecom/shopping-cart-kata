using System.Collections.Generic;
using System.Linq;

namespace Katas.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IItemPriceCalculator _itemPriceCalculator;
        private readonly IList<string> _items;

        public ShoppingCart(IItemPriceCalculator itemPriceCalculator)
        {
            _itemPriceCalculator = itemPriceCalculator;
            _items = new List<string>();
        }

        public void Scan(string item)
        {
            _items.Add(item);
        }

        public int TotalItems()
        {
            return _items.Count;
        }

        public decimal TotalPrice()
        {
            var itemsGrouped = _items
                .GroupBy(x => x)
                .ToDictionary(item => item.Key, itemCount => itemCount.Count());
            
            return itemsGrouped.Sum(item => _itemPriceCalculator.CalculatePrice(item.Key, item.Value));
        }
    }
}
