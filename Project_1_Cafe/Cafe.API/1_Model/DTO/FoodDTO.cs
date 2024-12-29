using System.ComponentModel.DataAnnotations;
using Cafe.API.Items;
using Cafe.API.Util;

namespace Cafe.API.DTOs;

public class FoodInDTO
{
    public required Food.FoodType Type { get; set; }
    public string Name
    {
        get
        {
            return Utility.AddSpaces(Enum.GetName(Type)!);
        }
    }

    public int OrderId { get; set; }

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
    public string Name
    {
        get
        {
            return Utility.AddSpaces(Enum.GetName(Type)!);
        }
    }
}
