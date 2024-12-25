using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;
using Microsoft.AspNetCore.Http.HttpResults;

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
    public FoodController(IFoodService FoodService)
    {
        _FoodService = FoodService;
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
    public Food CreateNewFood(Food Food)
    {


        //var newFood = _FoodServices.GetNewFood(Food);
        throw new NotImplementedException();
    }

    [HttpDelete]
    public Food DeleteFood(Food Food)
    {

        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public Food GetFoodByorder(int orderId)
    {
        throw new NotImplementedException();
    }

}