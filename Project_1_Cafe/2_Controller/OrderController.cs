using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;

namespace Cafe.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _OrderService;

    public OrderController(IOrderService orderService)
    {
        _OrderService = orderService;
    }

    [HttpGet]
    public IActionResult GetAllOrders()
    {
        var OrderList = _OrderService.GetAllOrders();        
        return Ok(OrderList);
    }

    [HttpPost]
    public IActionResult CreateNewOrder(Order newOrder)
    {
        var Order = _OrderService.GetNewOrder(newOrder);
        return Ok(Order);
    }

    [HttpGet("{id}")]
    public IActionResult GetOrderById(int id)
    {
        var findOrder = _OrderService.GetOrderById(id);

        if(findOrder is null) return NotFound();
        
        return Ok(findOrder);
    }
}