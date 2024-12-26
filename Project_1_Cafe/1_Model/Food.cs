using Cafe.API.Util;

namespace Cafe.API.Items;

public class Food : Item
{
    public enum FoodType
    {
        ButterCroissant,
        HamAndSwissCroissant,
        ChocolateCroissant,
        BaconEggAndCheddarSandwich,
        BaconEggAndGoudaSandwich,
        GrilledCheeseSandwich,
    }

    public FoodType SelectFoodType { get; set; }
    public Food(FoodType type, double price, int id)
        : base(Utility.AddSpaces(nameof(type)), price, id)
        {        
            SelectFoodType = type;  
        }
        
}