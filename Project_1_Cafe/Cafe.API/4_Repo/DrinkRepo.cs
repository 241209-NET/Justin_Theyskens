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
        _CafeContext.Drinks?.Add(drink);
        _CafeContext.SaveChanges();
        return drink;
    }
    public IEnumerable<Drink> GetAllDrinks()
    {
        return _CafeContext.Drinks!;
    }

    public IEnumerable<Drink> GetDrinksByOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public Drink? GetDrink(int itemID, int index)
    {

        throw new NotImplementedException();
    }

    public Drink? GetDrinkById(int id)
    {
        throw new NotImplementedException();
    }

}