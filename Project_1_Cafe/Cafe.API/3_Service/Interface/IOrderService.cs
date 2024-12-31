using Cafe.API.DTOs;
using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IOrderService
{
    OrderInDTO CreateNewOrder(Order Order);
    IEnumerable<OrderOutDTO> GetAllOrders();
    
    Order GetOrderById(int id);
    
    Order DeleteOrderById(int id);
}