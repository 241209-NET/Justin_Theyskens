namespace Cafe.API.Items;

public interface ICafeItem
{
    public enum ItemType
    {
        Drink,
        Food,
        Condiment
    }
    int Id { get; set; }
    string Name { get; set; }

    ItemType Type {get; set; }

    int GetId();
}