using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Cafe.API.Repo;

public class OrderRepo : IOrderRepo
{
    private readonly CafeContext _CafeContext;

    public OrderRepo(CafeContext cafeContext) => _CafeContext = cafeContext;

    public Order CreateNewOrder(Order Order)
    {
        _CafeContext.Orders?.Add(Order);
        _CafeContext.SaveChanges();
        return Order;
    }
    public IEnumerable<Order> GetAllOrders()
    {
        return _CafeContext.Orders!;
    }

    public Order? GetOrderById(int id)
    {
        return _CafeContext.Orders?.Find(id);
    }

    public Order DeleteOrderById(int id)
    {
        var order = GetOrderById(id);
        _CafeContext.Orders?.Remove(order!);
        _CafeContext.SaveChanges();
        return order!;

    }

    public Order DeleteOrder(Order order)
    {
        _CafeContext.Orders?.Remove(order);
        _CafeContext.SaveChanges();
        return order;
    }

}