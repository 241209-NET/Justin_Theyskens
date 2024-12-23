namespace Cafe.API.Items;

public class Condiment : Item
{
    public enum CondimentType
    {
        ketchup,
        mustard,
        sriracha,
        honey,
    }

    public CondimentType Type { get; set; }

    public Condiment(CondimentType type, int id)
    : base(type.ToString(), 0, id)
    {
        Type = type;
    }

    public override string ToString()
    {
        return $"a packet of {Type}";
    }
}