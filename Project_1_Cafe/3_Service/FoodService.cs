using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class FoodService : IFoodService
{
    private readonly IFoodRepo _FoodRepository;

    public FoodService(IFoodRepo FoodRepository) => _FoodRepository = FoodRepository;

    public Food CreateNewFood(Food Food)
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
    
    public IEnumerable<Food> GetFoodsByOrder(int orderId)
    {
        // TODO
        throw new NotImplementedException();
    }

    //private readonly IFoodRepo;
}