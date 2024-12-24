using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Cafe.API.Repo;

public class OrderRepo : IOrderRepo
{
    private readonly OrderContext _OrderContext;

    public OrderRepo(OrderContext OrderContext) => _OrderContext = OrderContext;

    public Order GetNewOrder(Order Order)
    {
        _OrderContext.Orders.Add(Order);
        _OrderContext.SaveChanges();
        return Order;
    }
    public IEnumerable<Order> GetAllOrders()
    {
        return _OrderContext.Orders;
    }


    public Order? GetOrderById(int id)
    {
        return _OrderContext.Orders.Find(id);
    }

}