namespace Cafe.API.Items;

    public enum ItemType
    {
        Drink,
        Food,
        Condiment
    }
public interface ICafeItem
{
    int Id { get; set; }
    int OrderId { get; set; }
    string Name { get; set; }

    double Price { get; set; }

    ItemType Item {get; set; }

    int GetId();
}