using Cafe.API.Items;

namespace Cafe.API.Repo;

public interface IOrderRepo
{
    Order GetNewOrder(Order Order);
    IEnumerable<Order> GetAllOrders();
    Order? GetOrderById(int id);
}