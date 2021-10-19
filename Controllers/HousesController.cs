
using GregsListDotnet.Models;
using GregsListDotnet.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsListDotnet.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _hs;

    public HousesController(HousesService hs)
    {
      _hs = hs;
    }

    [HttpPost]
    public ActionResult<House> CreateHouse([FromBody] House houseData)
    {
      try
      {
        var house = _hs.CreateHouse(houseData);
        return Ok(house);
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
  }
}