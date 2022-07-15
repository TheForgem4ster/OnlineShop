using DataLayer.Model;
using System.Collections;
using System.Collections.Generic;


namespace WebApplication1.ViewModels
{
    public class BooksListViewModel
    {
        // A function that will get all products
        public IEnumerable<Book> AllBooks { get; set; }

        public string CurrectCategory { get; set; }
    }
}
