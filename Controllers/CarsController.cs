using System.Collections.Generic;
using GregsListDotnet.Models;
using GregsListDotnet.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsListDotnet.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;

    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public ActionResult<List<Car>> GetCars() {
      try
      {
        var cars = _cs.Get();
        return Ok(cars);
      }
      catch (System.Exception error)
      {
          return BadRequest(error.Message);
      }
    }

    [HttpGet("{carId}")]
    public ActionResult<Car> GetCarById(int carId)
    {
      try
      {
        var car = _cs.Get(carId);
        return Ok(car);
      }
      catch (System.Exception e)
      {
        return BadRequest (e.Message);
      }
    }

    public ActionResult<Car> CreateCar([FromBody] Car carData)
    {
      try
      {
        var car = _cs.CreateCar(carData);
        return Ok(car);
      }
      catch (System.Exception e)
      {
        return BadRequest (e.Message);
      }
    }

    [HttpDelete("{carId}")]
    public ActionResult<Car> DeleteCar(int carId)
    {
      try
      {
        var car = _cs.Delete(carId);
        return Ok(car);
      }
      catch (System.Exception e)
      {
        return BadRequest (e.Message);
      }
    }
  }

}