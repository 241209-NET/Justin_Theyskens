using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;

namespace Cafe.API.Repo;

public class DrinkRepo : IDrinkRepo
{
    private readonly DrinkContext _DrinkContext;

    public DrinkRepo(DrinkContext DrinkContext) => _DrinkContext = DrinkContext;

    public Drink GetNewDrink(Drink Drink)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Drink> GetAllDrinks()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Drink> GetDrinksByDrink()
    {
        throw new NotImplementedException();
    }

    public Drink? GetDrink(int itemID, int index)
    {

        /* something like this
        var drink? = something.FindById(itemID)
        List<Drink> list = drink.Drinks;
        var Drink = drink?.Drinks[index];
        return Drink;
        */
        throw new NotImplementedException();
    }

}