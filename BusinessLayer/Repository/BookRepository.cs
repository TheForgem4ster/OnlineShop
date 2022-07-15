using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Repository
{
    /// <summary>
    /// Book storage class - for getting data from the database
    /// </summary>
    public class BookRepository : IAllBooks
    {
        /// <summary>
        /// The _appDBContent variable is needed so that we pull data from the database
        /// </summary>
        private readonly AppDBContent _appDBContent;

        /// <summary>
        /// The constructor with the parameter sets the value we pass to what we get
        /// </summary>
        /// <param name="appDBContent"></param>
        public BookRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        /// <summary>
        /// A function that receives data and writes category data
        /// </summary>
        public IEnumerable<Book> Books => _appDBContent.Books.Include(b => b.Category);
        /// <summary>
        /// A function that selects all records that will be true
        /// </summary>
        public IEnumerable<Book> GetFarBooks => _appDBContent.Books.Where(b => b.isFavourite)
            .Include(f => f.Category);
        /// <summary>
        /// A function that selects one book by ID
        /// </summary>
        /// <param name="bookid"></param>
        /// <returns>returns the first element</returns>
        public Book GetBookById(int bookid) => _appDBContent.Books.FirstOrDefault(b => b.Id == bookid);
    }
}
