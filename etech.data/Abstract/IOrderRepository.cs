using System.Collections.Generic;
using etech.entity;

namespace etech.data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}