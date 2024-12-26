using Cafe.API.Util;

namespace Cafe.API.Items;

public class Food : ICafeItem
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
    public int Id { get; set; }
    public string Name { get; set; }

    public double Price { get; set; }

    public ICafeItem.ItemType Type {get; set; }


    public FoodType SelectedFood { get; set; }
    public Food(string name, double price)
        {
            Id = GetId();
            Name = name;
            SelectedFood = FoodType.ButterCroissant; 
            Type = ICafeItem.ItemType.Food;   
            Price = price;         

        }

    public int GetId()
    {
        return 0;
    }
}