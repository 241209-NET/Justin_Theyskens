using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;

namespace Cafe.API.Repo;

public class OrderRepo : IOrderRepo
{
    private readonly OrderContext _OrderContext;

    public OrderRepo(OrderContext OrderContext) => _OrderContext = OrderContext;

    public Order GetNewOrder(Order Order)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Order> GetAllOrders()
    {
        throw new NotImplementedException();
    }


    public Order? GetOrderById(int id)
    {

        /* something like this
        var Order? = something.FindById(itemID)
        List<Order> list = Order.Orders;
        var Order = Order?.Orders[index];
        return Order;
        */
        throw new NotImplementedException();
    }

}