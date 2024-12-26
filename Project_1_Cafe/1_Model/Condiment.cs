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
    : base(id, nameof(type), 0)
    {
        Type = type;
    }

    public override string ToString()
    {
        return $"a packet of {nameof(Type)}";
    }
}