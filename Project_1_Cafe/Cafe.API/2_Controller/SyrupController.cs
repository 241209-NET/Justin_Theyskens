using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Cafe.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class SyrupController : ControllerBase
{

    private readonly ISyrupService _SyrupService;
    public SyrupController(ISyrupService syrupService)
    {
        _SyrupService = syrupService;
    }

    [HttpGet]
    public IActionResult GetAllSyrups()
    {
        var syrups = _SyrupService.GetAllSyrups();
        return Ok(syrups);
    }

    [HttpPost]
    public IActionResult GetNewSyrup(Syrup syrup)
    {

        var newSyrup = _SyrupService.CreateNewSyrup(syrup);
        return Ok(newSyrup);
    }

    [HttpDelete]
    public Syrup DeleteSyrup(Syrup syrup)
    {

        throw new NotImplementedException();
    }

}