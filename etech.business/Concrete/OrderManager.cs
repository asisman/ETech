using System.Collections.Generic;
using etech.business.Abstract;
using etech.data.Abstract;
using etech.entity;

namespace etech.business.Concrete
{
    public class OrderManager : IOrderService
    {
         private readonly IUnitOfWork _unitofwork;
        public OrderManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public void Create(Order entity)
        {
            _unitofwork.Orders.Create(entity);
            _unitofwork.Save();
        }

        public List<Order> GetOrders(string userId)
        {
            return  _unitofwork.Orders.GetOrders(userId);
        }
    }
}