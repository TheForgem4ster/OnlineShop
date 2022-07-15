using System.Collections.Generic;

namespace DataLayer.Model
{
    /// <summary>
    /// Book category class that contains identification code, name, description
    /// List of books
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Category identification code
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// name of category
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Category Description
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Sheet of books
        /// </summary>
        public List<Book> Books { get; set; }
    }
}
