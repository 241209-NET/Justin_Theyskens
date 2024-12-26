using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Cafe.API.Repo;

public class OrderRepo : IOrderRepo
{
    private readonly CafeContext _CafeContext;

    public OrderRepo(CafeContext cafeContext) => _CafeContext = cafeContext;

    public Order GetNewOrder(Order Order)
    {
        _CafeContext.Orders.Add(Order);
        _CafeContext.SaveChanges();
        return Order;
    }
    public IEnumerable<Order> GetAllOrders()
    {
        return _CafeContext.Orders;
    }


    public Order? GetOrderById(int id)
    {
        return _CafeContext.Orders.Find(id);
    }

}