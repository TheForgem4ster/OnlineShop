using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Model;
using System;

namespace BusinessLayer.Repository
{
    /// <summary>
    /// Order storage class - for getting data from the database
    /// </summary>
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly ShopCart _shopCart;
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="appDBContent"></param>
        /// <param name="shopCart"></param>
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }

        /// <summary>
        /// The method that creates the order
        /// </summary>
        /// <param name="order"></param>
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDBContent.Order.Add(order);

            _appDBContent.SaveChanges();
            var item = _shopCart.ListShopItems;

            foreach(var elem in item)
            {
                var orderDetail = new OrderDetail()
                {
                    BookId = elem.book.Id,
                    OrderId = order.Id,
                    Price = elem.book.price
                    
                };
                _appDBContent.OrderDetail.Add(orderDetail);
                _appDBContent.SaveChanges();
            }
            
        }
    }
}
