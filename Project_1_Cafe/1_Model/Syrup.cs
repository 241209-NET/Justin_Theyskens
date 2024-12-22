namespace Cafe.API.Items;

public class Syrup
{
    public static int Index;
    public enum SyrupFlavor
    {
        Vanilla,
        Caramel,
        Mocha,
        Peppermint,
        BrownSugar,
        WhiteMocha,
        Pumpkin
    }

    public SyrupFlavor Flavor { get; set; }
    private int _Pumps;
    public int Pumps
    {
        get { return _Pumps; }
        set { _Pumps = value; }
    }

    public int ItemId { get; set; }
    public int SyrupId { get; set; }

    public Syrup(SyrupFlavor flavor, int pumps)
    {
        Flavor = flavor;
        _Pumps = pumps;
        SyrupId = GetID();
    }

    public static int GetID()
    {
        Index ++;
        return Index;
    }
}