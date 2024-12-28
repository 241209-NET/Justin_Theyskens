using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class FoodService : IFoodService
{
    private readonly IFoodRepo _FoodRepository;

    public FoodService(IFoodRepo foodRepository) => _FoodRepository = foodRepository;

    public Food CreateNewFood(Food food)
    {
        var newFood = _FoodRepository.CreateNewFood(food);
        return newFood;
    }
    public IEnumerable<Food> GetAllFoods()
    {
        var allFood = _FoodRepository.GetAllFood();
        return allFood;
    }
    
    public IEnumerable<Food> GetFoodsByOrder(int orderId)
    {
        var food = _FoodRepository.GetFoodsByOrder(orderId);
        return food;
    }

    public Food GetFoodById(int id)
    {
        // if (id < 0)
        //     return null;

        var food = _FoodRepository.GetFoodById(id);

        return food!;
    }
}