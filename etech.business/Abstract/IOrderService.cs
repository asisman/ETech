using System.Collections.Generic;
using etech.entity;

namespace etech.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}