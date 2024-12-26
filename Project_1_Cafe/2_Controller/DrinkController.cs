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
    public DrinkController(IDrinkService drinkService)
    {
        _DrinkService = drinkService;
    }

    [HttpGet("DrinkMenu")]
    public IActionResult GetDrinkMenu()
    {
        return Ok(DrinkMenu);
    }

    [HttpGet]
    public IActionResult GetAllDrinks()
    {
        var drinks = _DrinkService.GetAllDrinks();
       return Ok(drinks);
    }

    [HttpPost]
    public IActionResult CreateNewDrink(Drink drink)
    {
        var newDrink = _DrinkService.CreateNewDrink(drink);

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
        return NotFound();
    }

}