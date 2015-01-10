# shopping-cart-kata
C# Shopping cart kata

After playing too much destiny, I thought enough was enough and time I started doing some TDD in spare time to keep my skills in the know.

After coming across http://rubygem.me/2014/01/16/shopping-cart-kata/ I thought I'd attempt it with some slight twists of my own, afterall this was for fun, so I wanted to add some bits of my own to it.  I changed the signature to follow:

    public interface IShoppingCart
    {
        void Scan(string item);
        int TotalItems();
        decimal TotalPrice();
    }
    
Just so I could test the item count and price.

I could have gone all out and created proper structures for the items, but as this was just checking the item name and price, a simple dictionary/check would be more than enough, afterall I'm testing my TDD knowledge than coding abilities on this one.  There's a lot I'd do differently if I was writing this code for an actual shopping place such as ASDA, as no doubt their specs would be more complicated therefore requring more complex types to check...
