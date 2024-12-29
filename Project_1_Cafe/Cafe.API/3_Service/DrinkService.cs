using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class DrinkService : IDrinkService
{
    private readonly IDrinkRepo _DrinkRepository;

    public DrinkService(IDrinkRepo drinkRepository) => _DrinkRepository = drinkRepository;
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
        return drinks;
    }

    public Drink GetDrinkById(int id)
    {
        var drink = _DrinkRepository.GetDrinkById(id);
        return drink!;
    }
}