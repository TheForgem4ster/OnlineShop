using DataLayer.Model;
using System.Collections;
using System.Collections.Generic;


namespace BusinessLayer.Interfaces
{
    /// <summary>
    /// The interface is used to work with books
    /// </summary>
    public interface IAllBooks
    {
        /// <summary>
        /// A function that returns all goods
        /// </summary>
        IEnumerable<Book> Books { get; }
        /// <summary>
        /// Return of Selected Items
        /// </summary>
        IEnumerable<Book> GetFarBooks { get; }

        /// <summary>
        /// Returning a specific item by tracking number
        /// </summary>
        /// <param name="bookid"></param>
        Book GetBookById(int bookid);
    }
}
