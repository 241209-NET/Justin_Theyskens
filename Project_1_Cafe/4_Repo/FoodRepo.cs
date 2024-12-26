using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;

namespace Cafe.API.Repo;

public class FoodRepo : IFoodRepo
{

    private readonly CafeContext _CafeContext;

    public FoodRepo(CafeContext CafeContext) => _CafeContext = CafeContext;

    public Food CreateNewFood(Food Food)
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