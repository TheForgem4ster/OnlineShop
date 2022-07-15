using System.Collections.Generic;
using System;

namespace DataLayer.Model
{
    /// <summary>
    /// Class of Order Details, which contains the order identification code, the identification code
    /// order details, book identification code, order details price, book class properties,
    /// class properties orders
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Identification code for order details
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Order identification code
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Book identification code
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Order Detail Price
        /// </summary>
        public uint Price { get; set; }

        /// <summary>
        /// book class properties
        /// </summary>
        public Book book { get; set; }

        /// <summary>
        /// order class properties
        /// </summary>
        public Order order { get; set; }

    }
}
