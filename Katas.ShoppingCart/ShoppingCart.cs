﻿using System;

namespace Katas.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        public void Scan(string item)
        {
            
        }

        public int TotalItems()
        {
            return 1;
        }

        public decimal TotalPrice()
        {
            return 50m;
        }
    }
}
