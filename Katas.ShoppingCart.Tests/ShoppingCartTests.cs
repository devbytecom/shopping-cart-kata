using NUnit.Framework;

namespace Katas.ShoppingCart.Tests
{
    public class ShoppingCartTests
    {
        private IShoppingCart _shoppingCart;

        [SetUp]
        public void SetUpShoppingCart()
        {
            _shoppingCart = new ShoppingCart();
        }

        [Test]
        public void ensure_one_item_can_be_added_to_cart()
        {
            _shoppingCart.Scan("A99");
            Assert.That(_shoppingCart.TotalItems(), Is.EqualTo(1));
        }

        [TestCase("A99", 50)]
        [TestCase("B15", 30)]
        [TestCase("C40", 60)]
        [TestCase("T34", 99)]
        public void ensure_one_of_each_item_costs_right(string item, decimal priceExpected)
        {
            _shoppingCart.Scan(item);
            Assert.That(_shoppingCart.TotalPrice(), Is.EqualTo(priceExpected));
        }
    }
}
