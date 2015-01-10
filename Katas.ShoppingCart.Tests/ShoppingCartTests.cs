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

        [Test]
        public void ensure_one_item_of_b15_costs_right()
        {
            _shoppingCart.Scan("B15");
            Assert.That(_shoppingCart.TotalPrice(), Is.EqualTo(30));
        }

        [Test]
        public void ensure_one_item_of_c40_costs_right()
        {
            _shoppingCart.Scan("C40");
            Assert.That(_shoppingCart.TotalPrice(), Is.EqualTo(60));
        }

        [Test]
        public void ensure_one_item_of_t34_costs_right()
        {
            _shoppingCart.Scan("T34");
            Assert.That(_shoppingCart.TotalPrice(), Is.EqualTo(99));
        }
    }
}
