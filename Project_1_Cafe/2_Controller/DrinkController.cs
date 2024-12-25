using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Cafe.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class DrinkController : ControllerBase
{
    public List<string> DrinkMenu = 
    [
        "water\n",
        "Coffee\n",
        "Tea\n",
        "Latte\n",
        "Cappucino\n",
        "Macchiato\n"
    ];

    private readonly IDrinkService _DrinkService;
    public DrinkController(IDrinkService DrinkService)
    {
        _DrinkService = DrinkService;
    }

    [HttpGet("DrinkMenu")]
    public IActionResult GetDrinkMenu()
    {
        return Ok(DrinkMenu);
    }

    [HttpGet]
    public IActionResult GetAllDrinks()
    {
        /* TODO:
        Change functionality to return menu list
        */
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