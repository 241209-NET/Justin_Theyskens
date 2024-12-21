namespace Cafe.API.Items;

public class Drink : Item
{
    public enum DrinkSize
    {
        Tall,
        Grande,
        Venti
    }
    public DrinkSize Size { get; set; }

    private int _Shots;
    public int Shots
    {
        get { return _Shots; }
        set { _Shots = value; }
    }

    public List<Syrup> Syrups = [];

    public Drink(DrinkSize size, string name, double price, int id)
        : base(name, price, id)
    {
        Size = size;
    }


    public Syrup AddSyrup(Syrup.SyrupFlavor flavor, int pumps)
    {
        var syrup = new Syrup(flavor, pumps);
        Syrups.Add(syrup);
        
        // Syrup's ID is tied to the drink's ID.
        syrup.ItemId = ItemId;

        return syrup;
    }

    public int AddShots(int amount)
    {
        _Shots += amount;
        return _Shots;
    }
}