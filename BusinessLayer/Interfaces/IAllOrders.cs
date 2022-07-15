using DataLayer.Model;

namespace BusinessLayer.Interfaces
{
    /// <summary>
    /// The interface is used to work with orders
    /// </summary>
    public interface IAllOrders
    {
        /// <summary>
        /// The function that creates the order
        /// </summary>
        /// <param name="order"></param>
        void CreateOrder(Order order);
    }
}
