using NUnit.Framework;

namespace Katas.ShoppingCart.Tests
{
    public class ShoppingCartTests
    {
        [Test]
        public void ensure_one_item_can_be_added_to_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Scan("A99");

            Assert.That(shoppingCart.Total(), Is.EqualTo(1));
        }
    }
}
