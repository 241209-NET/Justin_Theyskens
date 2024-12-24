using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IOrderService
{
    Order GetNewOrder(Order Order);
    IEnumerable<Order> GetAllOrders();
    
    Order GetOrderById(int id);
    
}