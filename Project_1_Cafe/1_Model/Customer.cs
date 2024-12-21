using Cafe.Items;
namespace Cafe.Customers;

public class Customer
{
    private int _Id;
    private string _Name;
    private double _Money;

    public int id
    {
        get { return _Id; }
        set { _Id = value; }
    }

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public double Money 
    { 
        get { return Math.Round(_Money, 2); } 
        set { _Money = Math.Round(value, 2); }
    }

    public Customer(int id, string name)
    {
        _Id = id;
        _Name = name;
        Money = 500.0;
    }
}