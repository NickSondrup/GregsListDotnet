using System;
using System.Collections.Generic;
using GregsListDotnet.Models;

namespace GregsListDotnet.Data
{
  public class FakeDb
  {
    private Random _random = new Random();
    public List<Car> Cars = new List<Car>();
    public List<House> Houses = new List<House>();

    public int GenerateId()
    {
      return _random.Next(100000, 10000000);
    }
  }
}