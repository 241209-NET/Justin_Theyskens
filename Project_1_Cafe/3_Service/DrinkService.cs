using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class DrinkService : IDrinkService
{
    private readonly IDrinkRepo _DrinkRepository;

    public DrinkService(IDrinkRepo DrinkRepository) => _DrinkRepository = DrinkRepository;
    public Drink CreateNewDrink(Drink drink)
    {
        var newDrink = _DrinkRepository.CreateNewDrink(drink);
        return newDrink;
    }
    public IEnumerable<Drink> GetAllDrinks()
    {
        var drinks = _DrinkRepository.GetAllDrinks();
        return drinks;

    }
    
    public IEnumerable<Drink> GetDrinksByOrder(int orderId)
    {
        var drinks = _DrinkRepository.GetDrinksByOrder(orderId);
        throw new NotImplementedException();
    }
}