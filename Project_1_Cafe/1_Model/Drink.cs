using System.Data.SqlTypes;
using Cafe.API.Util;
using Microsoft.OpenApi.Extensions;

namespace Cafe.API.Items;

public class Drink : ICafeItem
{
    public enum DrinkSize
    {
        Tall,
        Grande,
        Venti
    }

    public enum DrinkType
    {
        water,
        Coffee,
        Tea,
        Latte,
        Cappucino,
        Macchiato
    }

    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public ItemType Item {get; set; }
    public DrinkSize Size { get; set; }
    public DrinkType Type { get; set; }

    private int _Shots;
    public int Shots
    {
        get { return _Shots; }
        set { _Shots = value; }
    }

    public List<Syrup> Syrups = [];

    public Drink(DrinkSize size, DrinkType type)
    {
        Id = GetId();
        Size = size;
        Name = nameof(type);
        Type = type;
        Item = ItemType.Drink;
        Price = GetPrice();
    }


    public Syrup AddSyrup(Syrup.SyrupFlavor flavor, int pumps)
    {
        var syrup = new Syrup(flavor, pumps);
        Syrups.Add(syrup);
        
        syrup.ItemId = Id;
        string sName = nameof(flavor);
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
            case DrinkType.Cappucino: return 6.99;
            case DrinkType.Coffee: return 3.99;
            case DrinkType.Latte: return 5.89;
            case DrinkType.Tea: return 2.99;
            default: return 1.99;
        }
    }

    public void UpdateName(string toAdd)
    {
        Name = $"{toAdd} {Name}";
    }

    public int AddShots(int amount)
    {
        _Shots += amount;
        return _Shots;
    }

    public int GetId()
    {
        return 0;
    }
}