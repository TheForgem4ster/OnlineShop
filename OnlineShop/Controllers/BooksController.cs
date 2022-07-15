using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Book controller class
    /// </summary>
    public class BooksController : Controller
    {
        /// <summary>
        /// Create a variable
        /// </summary>
        private readonly IAllBooks _allBooks;
        /// <summary>
        /// Create a variable
        /// </summary>
        private readonly IBooksCategory _allCategory;
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="iAllBooks">Passing the IAllBooks interface parameter and setting it</param>
        /// <param name="iAllCategory">Passing the IBooksCategory interface parameter and setting it</param>
        public BooksController(IAllBooks iAllBooks, IBooksCategory iAllCategory)
        {
            _allBooks = iAllBooks;
            _allCategory = iAllCategory;
        }
        /// <summary>
        /// Specify the URL at which the function will work
        /// </summary>
        [Route("Books/List")]
        [Route("Books/List/{category}")]
        /// <summary>
        /// Method that returns an html page with a list of all products
        /// </summary>
        /// <param name="category"></param>
        /// <returns>returns the result of the html page</returns>
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                books = _allBooks.Books.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("horror", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.CategoryName.Equals("Horror")).OrderBy(i => i.Id);
                    currCategory = "Horror";
                }
                else if (string.Equals("detective", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i => i.Category.CategoryName.Equals("Detective")).OrderBy(i => i.Id);
                    currCategory = "Detective";
                }
            }
            var bookObj = new BooksListViewModel
            {
                AllBooks = books,
                CurrectCategory = currCategory
            };
            ViewBag.Title = "Page with books";
            
            return View(bookObj);
        }
        [HttpGet]   
        public ViewResult Find(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Book> books = null;
            if (string.IsNullOrEmpty(_searchString))
            {
                ModelState.AddModelError("", "empty!");                
            }
            else
            {
                books = _allBooks.Books.Where(s => s.Name.Contains(searchString)).ToList();
            }

            return View(books);
        }
    }
}
