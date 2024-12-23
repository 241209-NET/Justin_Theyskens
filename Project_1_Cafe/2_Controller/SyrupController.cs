using Microsoft.AspNetCore.Mvc;
using Cafe.API.Items;
using Cafe.API.Service;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Cafe.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class SyrupController
{

    private readonly ISyrupService _SyrupService;
    public SyrupController(ISyrupService syrupService)
    {
        _SyrupService = syrupService;
    }

    [HttpGet]
    public IActionResult GetAllSyrups()
    {
        //var syrups = _SyrupService.GetAllSyrups():
        throw new NotImplementedException();
    }

    [HttpPost]
    public Syrup GetNewSyrup(Syrup syrup)
    {


        //var newSyrup = _SyrupServices.GetNewSyrup(syrup);
        throw new NotImplementedException();
    }

    [HttpDelete]
    public Syrup DeleteSyrup(Syrup syrup)
    {

        throw new NotImplementedException();
    }

}