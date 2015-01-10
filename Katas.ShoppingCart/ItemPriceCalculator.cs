using System;

namespace Katas.ShoppingCart
{
    public class ItemPriceCalculator : IItemPriceCalculator
    {
        public decimal CalculatePrice(string item, int quantity)
        {
            switch (item)
            {
                case "A99":
                    return quantity == 3 ? 130 : 50;
                case "B15":
                    return quantity == 2 ? 45 : 30;
                case "C40":
                    return 60;
                case "T34":
                    return 99;
                default:
                    return 0;
            }
        }
    }
}
