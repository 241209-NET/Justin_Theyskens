using Cafe.API.Items;

namespace Cafe.API.Service;

public class FoodService : IFoodService
{
    public Food GetNewFood(Food Food)
    {
        // TODO
        return Food;
    }
    public IEnumerable<Food> GetAllFoods()
    {
        // TODO
        List<Food> list = [];
        return list;

    }
    
    public IEnumerable<Food> GetFoodsByDrink(int itemID)
    {
        // TODO
        throw new NotImplementedException();
    }

    //private readonly IFoodRepo;
}