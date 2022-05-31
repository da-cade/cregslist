using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cregslist.FakeDB;
using cregslist.models;

namespace cregslist.Services
{
  public class HousesService
  {
    internal List<House> GetAll()
    {
      List<House> houses = Database.Houses;
      return houses;
    }
    internal House Get(string id)
    {
      House house = Database.Houses.Find(h => h.Id == id);
      if (house == null) // you'll need to use this.
      {
        throw new Exception("invalid id");
      }
      return house;
    }
    internal House Create(House houseData)
    {
      Database.Houses.Add(houseData);
      return houseData;
    }

    internal House Edit(string id, House houseData)
    {
      House original = Get(id);

      original.Year = houseData.Year;
      original.Bedrooms = houseData.Bedrooms;
      original.Bathrooms = houseData.Bathrooms;
      original.ImgUrl = houseData.ImgUrl ?? original.ImgUrl;
      original.Levels = houseData.Levels;
      original.Price = houseData.Price;
      original.Description = houseData.Description ?? original.Description;

      return original;
    }

    internal void Delete(string id)
    {
      House house = Get(id);
      Database.Houses.Remove(house);
    }
  }
}