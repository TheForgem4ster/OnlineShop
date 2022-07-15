using BusinessLayer.Interfaces;
using DataLayer.Model;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    /// <summary>
    /// Класс контролеер заказа
    /// </summary>
    public class OrderController : Controller
    {
        /// <summary>
        /// Create a variable
        /// </summary>
        private readonly IAllOrders _allOrders;
        /// <summary>
        /// Create a variable
        /// </summary>
        private readonly ShopCart _shopCart;
        /// <summary>
        /// Creating a constructor with parameters
        /// </summary>
        /// <param name="allOrders"></param>
        /// <param name="shopCart"></param>
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
        }
        /// <summary>
        /// Function for displaying orders
        /// </summary>
        /// <returns>returns some html template</returns>
        public IActionResult Checkout()
        {
            return View();
        }
        /// <summary>
        /// The method is triggered when we submit the form and is used to fill in the product
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]

        public IActionResult Checkout(Order order)
        {
            _shopCart.ListShopItems = _shopCart.GetShopItems();
            
            if (_shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "You must have goods!");
            }

            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);
                //Return functions Complete
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        /// <summary>
        /// The class serves to display a message when we have made an order.
        /// </summary>
        /// <returns>returns the page</returns>
        public IActionResult Complete()
        {
            ViewBag.Message = "Order successfully processed";
            return View();
        }
    }
}
