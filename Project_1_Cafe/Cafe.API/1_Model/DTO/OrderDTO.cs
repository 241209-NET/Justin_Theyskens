using System.ComponentModel.DataAnnotations;
using Cafe.API.Items;

namespace Cafe.API.DTOs;

public class OrderInDTO
{
    public required string Name { get; set; }

    public Order DtoToOrder()
    {
        var newOrder = new Order(Name);
        return newOrder;
    }
}

public class OrderOutDTO
{
    public string? Name {get; set; }
    public int Id {get; set; }
    public double Total {get; set; }

    public List<OrderInDTO> OrdersDTO = [];
    public List<FoodInDTO> FoodsDTO = [];
}