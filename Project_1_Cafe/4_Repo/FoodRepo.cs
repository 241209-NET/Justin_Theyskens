using Cafe.API.Service;
using Cafe.API.Items;

namespace Cafe.API.Repo;

public class FoodRepo : IFoodRepo
{

    public Food GetNewFood(Food Food)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Food> GetAllFood()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Food> GetFoodsByDrink()
    {
        throw new NotImplementedException();
    }

    public Food? GetFood(int itemID, int index)
    {

        /* something like this
        var drink? = something.FindById(itemID)
        List<Food> list = drink.Foods;
        var Food = drink?.Foods[index];
        return Food;
        */
        throw new NotImplementedException();
    }

}