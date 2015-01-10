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

        [Test]
        public void ensure_one_item_of_a99_costs_right()
        {
            _shoppingCart.Scan("A99");
            Assert.That(_shoppingCart.TotalPrice(), Is.EqualTo(50));
        }
    }
}
