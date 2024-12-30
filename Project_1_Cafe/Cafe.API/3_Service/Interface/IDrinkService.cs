using Cafe.API.DTOs;
using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IDrinkService
{
    DrinkInDTO CreateNewDrink(Drink drink);
    IEnumerable<DrinkOutDTO> GetAllDrinks();
    
    IEnumerable<DrinkOutDTO> GetDrinksByOrder(int orderId);

    Drink GetDrinkById(int id);
    
}