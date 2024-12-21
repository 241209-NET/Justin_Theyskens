using Cafe.Customers;
using Cafe.Items;

namespace Cafe;

public class Order
{
    private int _Id;
    public int customerId
    {
        get { return _Id; }
        set { _Id = value; }
    }

    private List<Item> Items = [];
    public Order(int customerId)
    {
        _Id = customerId;
    }

    public void AddItem(Item item)
    {
        if (item.CustomerID == _Id)
        {
            Items.Add(item);
            Console.WriteLine($"{item} has been added to the order.");
        }
            
        Console.WriteLine("That item does not belong to that customer");
    }
}