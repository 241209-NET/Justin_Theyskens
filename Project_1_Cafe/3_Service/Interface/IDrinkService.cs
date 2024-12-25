using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IDrinkService
{
    Drink CreateNewDrink(Drink Drink);
    IEnumerable<Drink> GetAllDrinks();
    
    IEnumerable<Drink> GetDrinksByOrder(int orderId);
    
}