using Cafe.API.Util;

namespace Cafe.API.Items;

public abstract class Item
{


    private string _Name;
    private double _Price;
    private int _OrderId;

    private int _ItemId;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    

    public double Price
    {
        get { return Math.Round(_Price, 2); }

        set { _Price = Math.Round(value, 2); }
    }

    public int ItemId
    {
        get {return _ItemId; }
        set { _ItemId = value; }
    }

    public int OrderId 
    {
        get { return _OrderId; }
        set { _OrderId = value; }
    }

    public List<Condiment> Condiments = new();

    public Item(string name, double price, int id)
    {
        _Name = name;
        _Price = price;
        _OrderId = id;
    }

    public Condiment AddCondiment(Condiment.CondimentType type)
    {
        var newCondiment = new Condiment(type, Utility.SetItemId(this));
        Condiments.Add(newCondiment);

        newCondiment.ItemId = _ItemId;

        return newCondiment;
    }

}