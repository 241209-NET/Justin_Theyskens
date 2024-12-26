using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IDrinkService
{
    Drink CreateNewDrink(Drink drink);
    IEnumerable<Drink> GetAllDrinks();
    
    IEnumerable<Drink> GetDrinksByOrder(int orderId);

    Drink GetDrinkById(int itemId);
    
}