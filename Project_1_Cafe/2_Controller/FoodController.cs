using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Cafe.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class FoodController : ControllerBase
{

    private readonly IFoodService _FoodService;
    public FoodController(IFoodService FoodService)
    {
        _FoodService = FoodService;
    }

    [HttpGet]
    public IActionResult GetAllFoods()
    {
        //var Foods = _FoodService.GetAllFoods():
        throw new NotImplementedException();
    }

    [HttpPost]
    public Food GetNewFood(Food Food)
    {


        //var newFood = _FoodServices.GetNewFood(Food);
        throw new NotImplementedException();
    }

    [HttpDelete]
    public Food DeleteFood(Food Food)
    {

        throw new NotImplementedException();
    }

    public Food GetFoodByorder(int orderId)
    {
        throw new NotImplementedException();
    }

}