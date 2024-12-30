using AutoMapper;
using Cafe.API.DTOs;
using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class OrderService : IOrderService
{
    private readonly IOrderRepo _OrderRepository;
    private readonly IMapper _Mapper;

    public OrderService(IOrderRepo orderRepository, IMapper mapper)
    {
        _OrderRepository = orderRepository;
        _Mapper = mapper;
    }
    
    public OrderInDTO CreateNewOrder(Order order)
    {
        var newOrder = _OrderRepository.CreateNewOrder(order);
        var orderDTO = _Mapper.Map<OrderInDTO>(newOrder);
        return orderDTO;
    }
    public IEnumerable<OrderOutDTO> GetAllOrders()
    {
        var orderList = _OrderRepository.GetAllOrders();
        var orderDtoList = _Mapper.Map<List<OrderOutDTO>>(orderList);
        return orderDtoList;
    }
    
    public Order GetOrderById(int orderId)
    {
        return _OrderRepository.GetOrderById(orderId)!;
    }

    public Order DeleteOrderById(int id)
    {
        var order = GetOrderById(id);

        if(order is not null) 
            _OrderRepository.DeleteOrderById(id);

        return order!;
    }
}