using Cafe.API.Items;

namespace Cafe.API.Repo;

public interface IOrderRepo
{
    Order CreateNewOrder(Order Order);
    IEnumerable<Order> GetAllOrders();
    Order? GetOrderById(int id);

    Order? DeleteOrderById(int id);
}