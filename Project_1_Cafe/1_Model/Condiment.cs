namespace Cafe.API.Items;

public class Condiment
{
    public enum CondimentType
    {
        ketchup,
        mustard,
        sriracha,
        honey,
    }

    public CondimentType Type { get; set; }

    public int ItemId { get; set; }

    public Condiment(CondimentType type)
    {
        Type = type;
    }

    public override string ToString()
    {
        return $"a packet of {Type}";
    }
}