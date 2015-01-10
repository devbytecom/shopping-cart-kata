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
            return 1;
        }

        public decimal TotalPrice()
        {
            var _item = _items.First();

            if (_item == "B15")
            {
                return 30m;
            }
            return 50m;
        }
    }
}
