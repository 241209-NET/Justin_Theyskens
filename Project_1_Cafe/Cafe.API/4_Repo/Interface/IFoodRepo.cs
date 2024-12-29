using Cafe.API.Items;

namespace Cafe.API.Repo;

public interface IFoodRepo
{
    Food CreateNewFood(Food Food);
    IEnumerable<Food> GetAllFood();
    IEnumerable<Food> GetFoodsByOrder(int orderId);

    Food? GetFoodById(int id);
}