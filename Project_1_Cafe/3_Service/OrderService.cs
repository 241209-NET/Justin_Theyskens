using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class OrderService : IOrderService
{
    private readonly IOrderRepo _OrderRepository;

    public OrderService(IOrderRepo orderRepository) => _OrderRepository = orderRepository;
    public Order GetNewOrder(Order Order)
    {
        return _OrderRepository.GetNewOrder(Order);
    }
    public IEnumerable<Order> GetAllOrders()
    {
        return _OrderRepository.GetAllOrders();
    }
    
    public Order? GetOrderById(int orderId)
    {
        if (orderId < 0) 
            return null;

        return _OrderRepository.GetOrderById(orderId)!;
    }
}