using Cafe.API.Items;

namespace Cafe;

public class Order
{
    private static int _OrderIndex;

    public int Id { get; set; }

    public string Name { get; set; }

    public double Tax = 0.09;

    public double Total { get; set; }

    public List<ICafeItem> Items = [];
    public Order(string name)
    {
        Name = name;
        Id = NextOrder();
    }

    public void AddItem(ICafeItem item)
    {
        if (item.OrderId == Id)
        {
            Items.Add(item);
            UpdateTotal();
            Console.WriteLine($"Item has been added to order number: {Id}.");
            Console.WriteLine($"For a total of: {Items.Count} items.");
            Console.WriteLine($"{Name}'s new total is: {Total}.");
            return;
        }
            
        Console.WriteLine("That item does not belong to this order.");
    }

    public void UpdateTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Price;
        }
        total = total + (total * Tax);

        Total = Math.Round(total, 2);
    }

    private static int NextOrder()
    {
        _OrderIndex++;

        return _OrderIndex;
    }
}