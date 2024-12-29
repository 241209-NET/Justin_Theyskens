using AutoMapper;
using Cafe.API.DTOs;
using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class FoodService : IFoodService
{
    private readonly IFoodRepo _FoodRepository;
    private readonly IMapper _Mapper;

    public FoodService(IFoodRepo foodRepository, IMapper mapper)
    {
        _FoodRepository = foodRepository;
        _Mapper = mapper;
    }

    public FoodInDTO CreateNewFood(Food food)
    {
        var newFood = _FoodRepository.CreateNewFood(food);
        var foodDTO = _Mapper.Map<FoodInDTO>(newFood);
        return foodDTO;
    }
    public IEnumerable<FoodOutDTO> GetAllFoods()
    {
        var allFood = _FoodRepository.GetAllFood();
        var foodDtoList = _Mapper.Map<List<FoodOutDTO>>(allFood);
        return foodDtoList;
    }
    
    public IEnumerable<FoodOutDTO> GetFoodsByOrder(int orderId)
    {
        var foodList = _FoodRepository.GetFoodsByOrder(orderId);
        var foodDtoList = _Mapper.Map<List<FoodOutDTO>>(foodList);
        return foodDtoList;
    }

    public Food GetFoodById(int id)
    {
        var food = _FoodRepository.GetFoodById(id);
        //var foodDTO = _Mapper.Map<FoodOutDTO>(food);

        return food!;
    }
}