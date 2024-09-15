using etech.entity;

namespace etech.data.Abstract
{
    public interface ICartRepository: IRepository<Cart>
    {
        Cart GetByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
        void ClearCart(int cartId);
    }
}