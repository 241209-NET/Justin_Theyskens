using System.Data.SqlTypes;
using Microsoft.OpenApi.Extensions;

namespace Cafe.API.Items;

public class Drink : Item
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

    public DrinkSize Size { get; set; }

    public DrinkType SelectDrinkType { get; set; }

    private int _Shots;
    public int Shots
    {
        get { return _Shots; }
        set { _Shots = value; }
    }

    public List<Syrup> Syrups = [];

    public Drink(DrinkSize size, DrinkType type, double price, int id)
        : base(nameof(type), price, id)
    {
        Size = size;
        SelectDrinkType = type;
    }


    public Syrup AddSyrup(Syrup.SyrupFlavor flavor, int pumps)
    {
        var syrup = new Syrup(flavor, pumps);
        Syrups.Add(syrup);
        
        syrup.ItemId = ItemId;
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
}