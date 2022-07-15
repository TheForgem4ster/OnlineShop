using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Create a variable
        /// </summary>
        private readonly IAllBooks _bookRep;

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="bookRep"></param>
        public HomeController(IAllBooks bookRep)
        {
            _bookRep = bookRep;

        }
        [Authorize(Roles = "admin,user")]
        public IActionResult Index()
        {
            ViewBag.Name = User.Identity.Name;
            ViewBag.IsAuthenticated = User.Identity.IsAuthenticated;
            var homeBook = new HomeViewModel
            {
                favBook = _bookRep.GetFarBooks
            };
            return View(homeBook);
        }
        [Authorize(Roles = "admin")]
        public IActionResult AdminArea()
        {
            return Content("Admin only login");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
