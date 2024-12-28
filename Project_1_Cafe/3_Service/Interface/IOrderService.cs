using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IOrderService
{
    Order CreateNewOrder(Order Order);
    IEnumerable<Order> GetAllOrders();
    
    Order GetOrderById(int id);
    
}