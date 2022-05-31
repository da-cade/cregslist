using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cregslist.FakeDB;
using cregslist.models;

namespace cregslist.Services
{
  public class CarsService
  {
    internal List<Car> GetAll()
    {
      return Database.Cars;
    }
    internal Car Get(string id)
    {
      Car car = Database.Cars.Find(c => c.Id == id);
      if (car == null) // you'll need to use this.
      {
        throw new Exception("invalid id");
      }
      return car;
    }
    internal Car Create(Car carData)
    {
      Database.Cars.Add(carData);
      return carData;
    }

    internal Car Edit(string id, Car carData)
    {
      Car original = Get(id);

      original.Year = carData.Year;
      original.Make = carData.Make ?? original.Make;
      original.Model = carData.Model ?? original.Model;
      original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
      original.Color = carData.Color ?? original.Color;
      original.Owner = carData.Owner ?? original.Owner;

      return original;
    }

    internal void Delete(string id)
    {
      Car found = Get(id);
      Database.Cars.Remove(found);
    }
  }
}