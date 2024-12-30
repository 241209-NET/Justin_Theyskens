using System.Data.SqlTypes;
using Cafe.API.Util;
using Microsoft.OpenApi.Extensions;

namespace Cafe.API.Items;

public class Drink : ICafeItem
{
    private static int _DrinkIndex;
    public enum DrinkSize
    {
        Tall = 1,
        Grande = 2,
        Venti = 3
    }

    public enum DrinkType
    {
        water = 1,
        Coffee = 2,
        Tea = 3,
        Latte = 4,
        Cappucino = 5,
        Macchiato = 6
    }

    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public ItemType Item {get; set; }
    public DrinkSize Size { get; set; }
    public DrinkType Type { get; set; }

    public int Shots { get; set; }

    public List<Syrup> Syrups = [];

    public Drink(DrinkSize size, DrinkType type)
    {
        Id = GetId();
        Size = size;
        Name = Enum.GetName(type)!;
        Type = type;
        Item = ItemType.Drink;
        Price = GetPrice();
    }


    public Syrup AddSyrup(Syrup.SyrupFlavor flavor, int pumps)
    {
        var syrup = new Syrup(flavor, pumps);
        Syrups.Add(syrup);
        
        syrup.ItemId = Id;
        string sName = Enum.GetName(flavor)!;
        UpdateName(sName);
        UpdatePrice();

        return syrup;
    }

    public void UpdatePrice()
    {
        double newPrice = GetPrice();
        switch(Size)
        {
            case DrinkSize.Tall: newPrice *= 0.95; break;
            case DrinkSize.Grande: newPrice += (newPrice * 0.20); break;
            case DrinkSize.Venti: newPrice += (newPrice * 0.45); break;
        }

        newPrice += ( Syrups.Count * 0.8);
        Price = newPrice;
    }

    public double GetPrice()
    {
        switch(Type)
        {
            case DrinkType.water: return 0;
            case DrinkType.Cappucino: return 6.99 + ((int)Size * 0.2);
            case DrinkType.Coffee: return 3.99 + ((int)Size * 0.2);
            case DrinkType.Latte: return 5.89 + ((int)Size * 0.2);
            case DrinkType.Tea: return 2.99 + ((int)Size * 0.2);
            default: return 1.99 + ((int)Size * 0.2);
        }
    }

    public void UpdateName(string toAdd)
    {
        Name = $"{toAdd} {Name}";
    }

    public int AddShots(int amount)
    {
        Shots += amount;
        return Shots;
    }

    public int GetId()
    {
        _DrinkIndex ++;
        return _DrinkIndex;
    }
    public int GetShots()
    {
        if(Type == DrinkType.Latte || Type == DrinkType.Cappucino || Type == DrinkType.Macchiato)
        {
            if (Size == DrinkSize.Tall)
                return 1;
            else
                return 2;
        }
        
        return 0;
    }

    public void SetVariables()
    {
        Name = Enum.GetName(Type)!;
        Item = ItemType.Drink;
        Price = GetPrice(); 
        Shots = GetShots();
    }
}