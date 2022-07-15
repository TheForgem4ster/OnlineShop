

namespace DataLayer.Model
{
    /// <summary>
    /// The class of the element of the shopping cart, which contains the identification code, 
    /// properties of the book class, price and product identification code inside the cart
    /// </summary>
    public class ShopCartItem
    {
        /// <summary>
        /// Shopping cart item identification code
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// book class property
        /// </summary>
        public Book book { get; set; }

        /// <summary>
        /// Shop cart item price
        /// </summary>
        public int price { get; set; }

        /// <summary>
        /// Identification code of the item inside the cart
        /// </summary>
        public string ShopCartId { get; set; }
    }
}
