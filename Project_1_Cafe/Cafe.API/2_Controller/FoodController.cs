using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Cafe.API.DTOs;

namespace Cafe.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class FoodController : ControllerBase
{

    public List<string> FoodMenu = 
    [
        "Butter Croissant",
        "Ham & Swiss Croissant",
        "Chocolate Croissant",
        "Bacon, Egg, & Cheddar Sandwich",
        "Bacon, Egg, & Gouda Sandwich",
        "Grilled Cheese Sandwich",
    ];

    private readonly IFoodService _FoodService;
    public FoodController(IFoodService foodService)
    {
        _FoodService = foodService;
    }

    [HttpGet("FoodMenu")]
    public IActionResult GetFoodMenu()
    {
        return Ok(FoodMenu);
    }

    [HttpGet]
    public IActionResult GetAllFoods()
    {
        var foods = _FoodService.GetAllFoods();
        return Ok(foods);
    }

    [HttpPost]
    public IActionResult CreateNewFood(Food Food)
    {
        var newFood = _FoodService.CreateNewFood(Food);
        return Ok(newFood);
    }

    [HttpDelete]
    public Food DeleteFood(int id)
    {
        //var food = _FoodService.
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public IActionResult GetFoodByorder(int orderId)
    {
        IEnumerable<FoodOutDTO> food = _FoodService.GetFoodsByOrder(orderId);

        return Ok(food);
    }

}