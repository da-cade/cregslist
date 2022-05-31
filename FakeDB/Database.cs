using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cregslist.models;

namespace cregslist.FakeDB
{
  public class Database
  {
    public static List<Car> Cars { get; set; } = new List<Car>()
    {
      new Car(1993, "Chevrolet", "Chevelle", "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "red", "chuck"),
      new Car(1993, "Chevrolet", "Chevelle", "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "red", "chuck"),
      new Car(1993, "Chevrolet", "Chevelle", "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "red", "chuck"),
      new Car(1993, "Chevrolet", "Chevelle", "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "red", "chuck"),
      new Car(1993, "Chevrolet", "Chevelle", "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "red", "chuck")
    };
    public static List<House> Houses { get; set; } = new List<House>()
    {
      new House(1970, 3, 2, "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "uggy", 1, 30000),
      new House(1970, 3, 2, "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "uggy", 1, 30000),
      new House(1970, 3, 2, "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "uggy", 1, 30000),
      new House(1970, 3, 2, "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "uggy", 1, 30000),
      new House(1970, 3, 2, "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "uggy", 1, 30000),
      new House(1970, 3, 2, "https://i.pinimg.com/550x/84/f9/d0/84f9d0e28b6feb59581dfdf77c50ebc5.jpg", "uggy", 1, 30000),
    };
    public static List<Job> Jobs { get; set; } = new List<Job>()
    {
      new Job("22/04/2010", "Bad for you and everyone else", "NegaCorp", "Mumbai", "An honest days work for some"),
      new Job("22/04/2010", "Bad for you and everyone else", "NegaCorp", "Mumbai", "An honest days work for some"),
      new Job("22/04/2010", "Bad for you and everyone else", "NegaCorp", "Mumbai", "An honest days work for some"),
      new Job("22/04/2010", "Bad for you and everyone else", "NegaCorp", "Mumbai", "An honest days work for some"),
      new Job("22/04/2010", "Bad for you and everyone else", "NegaCorp", "Mumbai", "An honest days work for some")
    };
  }
}