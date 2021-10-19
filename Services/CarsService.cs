using System.Collections.Generic;
using System.Linq;
using GregsListDotnet.Data;
using GregsListDotnet.Models;

namespace GregsListDotnet.Services
{
  public class CarsService
  {
    private readonly FakeDb _db;

    public CarsService(FakeDb db)
    {
      _db = db;
    }

    public Car CreateCar(Car carData)
    {
      carData.Id = _db.GenerateId();
      _db.Cars.Add(carData);
      return carData;
    }

    public List<Car> Get()
    {
      return _db.Cars.ToList();
    }

    /// <summary>
    /// Finds and retuns a cat by its id
    /// </summary>
    /// <param name="carId"></param>
    /// <returns></returns>
    public Car Get(int carId)
    {
      var car = _db.Cars.Find(c => c.Id == carId);
      if(car == null)
      {
        throw new System.Exception("Invalid Car Id");
      }
      return car;
    }

    public Car Edit(int carId, Car carData)
    {
      var car = Get(carId);
      car.Make = carData.Make ?? car.Make;
      car.Model = carData.Model ?? car.Model;
      car.Price = carData.Price;
      return car;
    }

    public Car Delete(int carId)
    {
      var car = Get(carId);
      _db.Cars.Remove(car);
      return car;
    }
  }

}