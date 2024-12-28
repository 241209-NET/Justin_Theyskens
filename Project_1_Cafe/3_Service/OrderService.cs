using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class OrderService : IOrderService
{
    private readonly IOrderRepo _OrderRepository;

    public OrderService(IOrderRepo orderRepository) => _OrderRepository = orderRepository;
    public Order CreateNewOrder(Order Order)
    {
        return _OrderRepository.CreateNewOrder(Order);
    }
    public IEnumerable<Order> GetAllOrders()
    {
        return _OrderRepository.GetAllOrders();
    }
    
    public Order GetOrderById(int orderId)
    {
        return _OrderRepository.GetOrderById(orderId)!;
    }
}