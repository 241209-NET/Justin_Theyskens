namespace Cafe.Items;

public class Item
{
    private string _Name;
    private double _Price;
    private int _CustomerId;

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

    public int CustomerID 
    {
        get { return _CustomerId; }
        set { _CustomerId = value; }
    }

    public Item(string name, double price, int id)
    {
        _Name = name;
        _Price = price;
        _CustomerId = id;
    }

}