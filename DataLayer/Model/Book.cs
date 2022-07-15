using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    /// <summary>
    /// Book class that contains an identification code, name, short description, product rating
    /// photo, price, popularity, availability, category identification code, category class  
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Book identification code
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the book
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Brief description of the book
        /// </summary>
        public string shortDesc { get; set; }
        /// <summary>
        /// Book rating
        /// </summary>
        public string grade { get; set; }
        /// <summary>
        /// Book photography
        /// </summary>
        public string img { get; set; }
        /// <summary>
        /// Вook price
        /// </summary>
        public ushort price { get; set; }
        /// <summary>
        /// Best Books
        /// </summary>
        public bool isFavourite { get; set; }
        /// <summary>
        /// book availability
        /// </summary>
        public bool available { get; set; }
        /// <summary>
        /// Category identification code
        /// </summary>
        public int categoryId { get; set; }
        /// <summary>
        /// category class property
        /// </summary>
        public Category Category { get; set; }

    }
}
