using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;

namespace Cafe.API.Repo;

public class DrinkRepo : IDrinkRepo
{
    private readonly CafeContext _CafeContext;

    public DrinkRepo(CafeContext cafeContext) => _CafeContext = cafeContext;

    public Drink CreateNewDrink(Drink drink)
    {
        drink.SetVariables();
        _CafeContext.Drinks?.Add(drink);
        Order order = _CafeContext.Orders?.Find(drink.OrderId)!;
        order?.AddItem(drink);
        _CafeContext.SaveChanges();
        return drink;
    }
    public IEnumerable<Drink> GetAllDrinks()
    {
        return _CafeContext.Drinks!;
    }

    public IEnumerable<Drink> GetDrinksByOrder(int orderId)
    {
        var drinkList = _CafeContext.Drinks?.Where(d => d.OrderId == orderId);
        return drinkList!;
    }

    public Drink? GetDrinkById(int id)
    {
        var drink = _CafeContext.Drinks?.Find(id);
        return drink!;
    }

}