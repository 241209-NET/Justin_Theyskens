using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IDrinkService
{
    Drink GetNewDrink(Drink Drink);
    IEnumerable<Drink> GetAllDrinks();
    
    IEnumerable<Drink> GetDrinksByOrder(int orderId);
    
}