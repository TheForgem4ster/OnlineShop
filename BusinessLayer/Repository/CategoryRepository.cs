using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace BusinessLayer.Repository
{
    /// <summary>
    /// Category storage class - for getting data from the database
    /// </summary>
    public class CategoryRepository : IBooksCategory
    {
        /// <summary>
        /// The _appDBContent variable is needed so that we pull data from the database
        /// </summary>
        private readonly AppDBContent _appDBContent;
        /// <summary>
        /// The constructor with the parameter sets the value we pass to what we get
        /// </summary>
        /// <param name="appDBContent"></param>
        public CategoryRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        /// <summary>
        /// Function to get all categories
        /// </summary>
        public IEnumerable<Category> AllCategories => _appDBContent.Category;
    }
}
