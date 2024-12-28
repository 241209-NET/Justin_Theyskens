using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;

namespace Cafe.API.Repo;

public class FoodRepo : IFoodRepo
{

    private readonly CafeContext _CafeContext;

    public FoodRepo(CafeContext cafeContext) => _CafeContext = cafeContext;

    public Food CreateNewFood(Food food)
    {
        _CafeContext.Food?.Add(food);
        _CafeContext.SaveChanges();
        return food;
    }
    public IEnumerable<Food> GetAllFood()
    {
        return _CafeContext.Food!;
    }

    public IEnumerable<Food> GetFoodsByOrder(int orderId)
    {
        var foodList = _CafeContext.Food?.Where(f => f.OrderId == orderId);
        return foodList!;
    }

    public Food? GetFoodById(int id)
    {
        var food = _CafeContext.Food?.Find(id);
        return food;
    }

}