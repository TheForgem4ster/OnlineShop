using DataLayer.Model;
using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    /// <summary>
    /// The interface that is responsible for getting all the categories
    /// </summary>
    public interface IBooksCategory
    {
        /// <summary>
        /// A function that returns all models from a category
        /// </summary>
        IEnumerable<Category> AllCategories { get; }
    }
}
