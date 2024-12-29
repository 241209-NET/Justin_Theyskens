using System.ComponentModel.DataAnnotations;
using Cafe.API.Items;
using Cafe.API.Util;

namespace Cafe.API.DTOs;

public class DrinkInDTO
{
    public required Drink.DrinkType Type { get; set; }

    public required Drink.DrinkSize Size { get; set; }
    public string Name
    {
        get
        {
            return $"{Utility.AddSpaces(Enum.GetName(Size)!)} {Utility.AddSpaces(Enum.GetName(Type)!)}";
        }
    }

    public int OrderId { get; set; }

    public Drink DtoToDrink()
    {
        var newDrink = new Drink(Size, Type);
        return newDrink;
    }
}

public class DrinkOutDTO
{
    public Drink.DrinkType Type {get; set; }
    public Drink.DrinkSize Size { get; set; }
    public int Id {get; set; }
    public string Name
    {
        get
        {
            return $"{Utility.AddSpaces(Enum.GetName(Size)!)} {Utility.AddSpaces(Enum.GetName(Type)!)}";
        }
    }

    //public List<SyrupInDTO> SyrupsDTO = [];
}
