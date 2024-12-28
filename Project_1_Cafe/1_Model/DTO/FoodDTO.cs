using System.ComponentModel.DataAnnotations;
using Cafe.API.Items;

namespace Cafe.API.DTOs;

public class FoodInDTO
{
    public required Food.FoodType Type { get; set; }

    public Food DtoToFood()
    {
        var newFood = new Food(Type);
        return newFood;
    }
}

public class FoodOutDTO
{
    public Food.FoodType Type {get; set; }
    public int Id {get; set; }

    //public List<FoodInDTO> FoodsDTO = [];
}