using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class OrderService : IOrderService
{
    private readonly IOrderRepo _OrderRepository;

    public OrderService(IOrderRepo OrderRepository) => _OrderRepository = OrderRepository;
    public Order GetNewOrder(Order Order)
    {
        // TODO
        return Order;
    }
    public IEnumerable<Order> GetAllOrders()
    {
        // TODO
        List<Order> list = [];
        return list;

    }
    
    public Order GetOrderById(int orderId)
    {
        // TODO
        throw new NotImplementedException();
    }

    //private readonly IOrderRepo;
}