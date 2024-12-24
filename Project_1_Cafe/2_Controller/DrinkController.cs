using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;

namespace Cafe.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class DrinkController : ControllerBase
{

    private readonly IDrinkService _DrinkService;
    public DrinkController(IDrinkService DrinkService)
    {
        _DrinkService = DrinkService;
    }

    [HttpGet]
    public IActionResult GetAllDrinks()
    {
        var drinks = _DrinkService.GetAllDrinks();
       return Ok(drinks);
    }

    [HttpPost]
    public IActionResult GetNewDrink(Drink drink)
    {
        var newDrink = _DrinkService.GetNewDrink(drink);

        return Ok(newDrink);
    }


    [HttpGet("{id}")]
    public IActionResult GetDrinksByOrder(int id)
    {
        var drinks = _DrinkService.GetDrinksByOrder(id);

        return Ok(drinks);
    }

    [HttpDelete]
    public IActionResult DeleteDrink(int id)
    {
        //var toDelete = _DrinkService.DeleteById(id);
        /*
        if (toDelete is null)
            return NotFound();

        return Ok(toDelete);
        */

        return NotFound();
    }

}