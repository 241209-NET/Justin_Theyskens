using Cafe.API.Util;

namespace Cafe.API.Items;

public class Food : ICafeItem
{
    public enum FoodType
    {
        ButterCroissant = 1,
        HamAndSwissCroissant = 2,
        ChocolateCroissant = 3,
        BaconEggAndCheddarSandwich = 4,
        BaconEggAndGoudaSandwich = 5,
        GrilledCheeseSandwich = 6,
    }

    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Name { get; set; }
    
    public double Price { get; set; }
    public ItemType Item {get; set; }
    public FoodType Type {get; set; }
    public Food(FoodType type)
    {
        Id = GetId();
        Name = Utility.AddSpaces(nameof(type));
        Type = type;
        Item = ItemType.Food; 
        Price = GetPrice();       

    }

    public int GetId()
    {
        return 0;
    }

    public double GetPrice()
    {
        switch(Type)
        {
            case FoodType.GrilledCheeseSandwich: return 7.99;
            default: return 6.99;
        }
    }
}