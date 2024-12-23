using Cafe.API.Items;

namespace Cafe;

public class Order
{
    private static int _OrderIndex;
    private int _Id;
    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }

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

    private List<Item> Items = [];
    public Order()
    {
        _Id = NextOrder();
    }

    public void AddItem(Item item)
    {
        if (item.OrderId == _Id)
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