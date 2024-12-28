using Cafe.API.Items;

namespace Cafe;

public class Order
{
    private static int _OrderIndex;

    public int Id { get; set; }

    public string Name { get; set; }

    public double Tax = 0.09;

    public double Total
    {
        get 
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            total = total + (total * Tax);

            return Math.Round(total, 2);
        }
    }

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
            Console.WriteLine($"{item} has been added to the order.");
        }
            
        Console.WriteLine("That item does not belong to this order.");
    }

    private static int NextOrder()
    {
        _OrderIndex++;

        return _OrderIndex;
    }
}