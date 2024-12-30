using AutoMapper;
using Cafe.API.DTOs;
using Cafe.API.Items;
using Cafe.API.Repo;

namespace Cafe.API.Service;

public class DrinkService : IDrinkService
{
    private readonly IDrinkRepo _DrinkRepository;
    private readonly IMapper _Mapper;

    public DrinkService(IDrinkRepo drinkRepository, IMapper mapper)
    {
        _DrinkRepository = drinkRepository;
        _Mapper = mapper;
    }
    public DrinkInDTO CreateNewDrink(Drink drink)
    {
        var newDrink = _DrinkRepository.CreateNewDrink(drink);
        var drinkDTO = _Mapper.Map<DrinkInDTO>(newDrink);
        return drinkDTO;
    }
    public IEnumerable<DrinkOutDTO> GetAllDrinks()
    {
        var drinks = _DrinkRepository.GetAllDrinks();
        var drinksDTO = _Mapper.Map<List<DrinkOutDTO>>(drinks);
        return drinksDTO;

    }
    
    public IEnumerable<DrinkOutDTO> GetDrinksByOrder(int orderId)
    {
        var drinks = _DrinkRepository.GetDrinksByOrder(orderId);
        var drinksDTO = _Mapper.Map<List<DrinkOutDTO>>(drinks);
        return drinksDTO;
    }

    public Drink GetDrinkById(int id)
    {
        var drink = _DrinkRepository.GetDrinkById(id);
        return drink!;
    }

    public Drink UpdateDrink(int id)
    {
        var drink = _DrinkRepository.GetDrinkById(id);
        //TODO: add to this?
        return drink!;
    }
}