using BusinessLayer.Interfaces;
using DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Controller class for creating a shopping cart
    /// </summary>
    public class ShopCartController : Controller
    {
        private readonly IAllBooks _bookRep;
        private readonly ShopCart _shopCart;

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="bookRep"></param>
        /// <param name="shopCart"></param>
        public ShopCartController(IAllBooks bookRep, ShopCart shopCart)
        {
            _bookRep = bookRep;
            _shopCart = shopCart;
        }

        /// <summary>
        /// Method for displaying in the shopping cart
        /// </summary>
        /// <returns>Returns a specific html template and displays orders</returns>
        public ViewResult Index()
        {
            var item = _shopCart.GetShopItems();
            _shopCart.ListShopItems = item;

            var obj = new ShopCartViewModel { shopCart = _shopCart };

            return View(obj);
        }
        /// <summary>
        /// The method adds items to the cart
        /// </summary>
        /// <param name="id"></param>
        /// <returns>redirect the user to the shopping cart page</returns>
        public RedirectToActionResult addToCart(int id)
        {
            // selects the desired item from the database list
            var item = _bookRep.Books.FirstOrDefault(i => i.Id == id);

            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            // when we click on add product, we will redirect the user to the shopping cart page
            return RedirectToAction("Index");
        }
    }
}
