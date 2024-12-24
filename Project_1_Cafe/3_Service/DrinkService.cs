using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class DrinkService : IDrinkService
{
    private readonly IDrinkRepo _DrinkRepository;

    public DrinkService(IDrinkRepo DrinkRepository) => _DrinkRepository = DrinkRepository;
    public Drink GetNewDrink(Drink Drink)
    {
        // TODO
        return Drink;
    }
    public IEnumerable<Drink> GetAllDrinks()
    {
        // TODO
        List<Drink> list = [];
        return list;

    }
    
    public IEnumerable<Drink> GetDrinksByOrder(int orderId)
    {
        // TODO
        throw new NotImplementedException();
    }

    //private readonly IDrinkRepo;
}