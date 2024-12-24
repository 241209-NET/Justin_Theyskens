using Cafe.API.Items;

namespace Cafe.API.Repo;

public interface IDrinkRepo
{
    Drink GetNewDrink(Drink Drink);
    IEnumerable<Drink> GetAllDrinks();
    IEnumerable<Drink> GetDrinksByDrink();

    Drink? GetDrink(int itemID, int index);
}