using Cafe.API.DTOs;
using Cafe.API.Items;

namespace Cafe.API.Service;

public interface IFoodService
{
    FoodInDTO CreateNewFood(Food Food);
    IEnumerable<FoodOutDTO> GetAllFoods();
    
    IEnumerable<FoodOutDTO> GetFoodsByOrder(int orderID);

    Food GetFoodById(int id);
    
}