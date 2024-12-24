using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IFoodService
{
    Food GetNewFood(Food Food);
    IEnumerable<Food> GetAllFoods();
    
    IEnumerable<Food> GetFoodsByOrder(int orderID);
    
}