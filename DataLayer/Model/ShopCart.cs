using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataLayer.Model
{
    /// <summary>
    /// Cart class, which has a list of elements of the shopping cart, constructor with a parameter
    /// methods for getting, adding and getting goods from the store
    /// </summary>
    public class ShopCart
    {
        /// <summary>
        /// Creating a field for reading AppDBContent to implement the constructor
        /// </summary>
        private readonly AppDBContent _appDBContent;
        /// <summary>
        /// Shopping cart ID
        /// </summary>
        public string ShopCartId { get; set; }
        /// <summary>
        /// List of items in the shopping cart
        /// </summary>
        public List<ShopCartItem> ListShopItems { get; set; }

        /// <summary>
        /// Constructor with parameter
        /// </summary>
        /// <param name="appDBContent"></param>
        public ShopCart(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        /// <summary>
        /// Static method that receives
        /// </summary>
        /// <param name="services"></param>
        /// <returns>Returns an object of class cart</returns>
        public static ShopCart GetCart(IServiceProvider services)
        {
            // created an object for the session
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();

            // check if it does not exist with this key CartId create a new one
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            // setting a new session
            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }
        /// <summary>
        /// Method that adds a book to the cart
        /// </summary>
        /// <param name="book"></param>
        public void AddToCart(Book book)
        {
            _appDBContent.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                book = book,
                price = book.price,
            });
            // Saving all data
            _appDBContent.SaveChanges();
        }

        /// <summary>
        /// List of items from the cart
        /// </summary>
        /// <returns>Returns a list of products by ShopCartId</returns>
        public List<ShopCartItem> GetShopItems()
        {
            return _appDBContent.ShopCartItems.Where(b => b.ShopCartId == ShopCartId)
                .Include(s => s.book).ToList();
        }
    }
}
