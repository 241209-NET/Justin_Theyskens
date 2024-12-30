using Cafe.API.Items;

namespace Cafe.API.Repo;

public interface IDrinkRepo
{
    Drink CreateNewDrink(Drink Drink);
    IEnumerable<Drink> GetAllDrinks();
    IEnumerable<Drink> GetDrinksByOrder(int orderId);

    Drink? GetDrinkById(int id);
}