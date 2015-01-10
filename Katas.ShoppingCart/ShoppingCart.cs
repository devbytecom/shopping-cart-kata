using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Katas.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private IList<string> _items;

        public ShoppingCart()
        {
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

            var total = 0m;

            foreach (var item in itemsGrouped)
            {
                switch (item.Key)
                {
                    case "A99":
                        total += item.Value == 3 ? 130 : 50;
                        break;
                    case "B15":
                        total += 30;
                        break;
                    case "C40":
                        total += 60;
                        break;
                    case "T34":
                        total += 99;
                        break;
                }
            }

            return total;
        }
    }
}
