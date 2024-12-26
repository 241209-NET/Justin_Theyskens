using System.Data.SqlTypes;
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
    public string Name { get; set; }
    public double Price { get; set; }

    public ICafeItem.ItemType Type {get; set; }

    public DrinkSize Size { get; set; }

    public DrinkType DrinkSelection { get; set; }

    private int _Shots;
    public int Shots
    {
        get { return _Shots; }
        set { _Shots = value; }
    }

    public List<Syrup> Syrups = [];

    public Drink(DrinkSize size, string name, double price)
    {
        Id = GetId();
        Size = size;
        Name = name;
        DrinkSelection = DrinkType.Coffee;
        Type = ICafeItem.ItemType.Drink;
        Price = price;
    }


    public Syrup AddSyrup(Syrup.SyrupFlavor flavor, int pumps)
    {
        var syrup = new Syrup(flavor, pumps);
        Syrups.Add(syrup);
        
        syrup.ItemId = Id;
        string sName = nameof(flavor);
        UpdateName(sName);

        return syrup;
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