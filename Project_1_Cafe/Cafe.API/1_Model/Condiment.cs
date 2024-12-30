namespace Cafe.API.Items;

public class Condiment : ICafeItem
{
    private static int _CondimentIndex;
    public enum CondimentType
    {
        ketchup,
        mustard,
        sriracha,
        honey,
    }

    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public ItemType Item {get; set; }

    public CondimentType Type { get; set; }

    public Condiment(CondimentType type)
    {
        Name = nameof(type);
        Id = GetId();
        Type = type;
        Item = ItemType.Condiment;
        Price = 0;
    }

    public override string ToString()
    {
        return $"a packet of {nameof(Type)}";
    }
    public int GetId()
    {
        _CondimentIndex ++;
        return _CondimentIndex;
    }
}