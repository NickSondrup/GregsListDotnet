using GregsListDotnet.Data;
using GregsListDotnet.Models;

namespace GregsListDotnet.Services
{
  public class HousesService
  {

    private readonly FakeDb _db;

    public HousesService(FakeDb db)
    {
      _db = db;
    }

    public House CreateHouse(House houseData)
    {
      houseData.Id = _db.GenerateId();
      _db.Houses.Add(houseData);
      return houseData;
    }
  }
}