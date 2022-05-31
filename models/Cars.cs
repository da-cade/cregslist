using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cregslist.models
{
  public class Car
  {
    public string Id { get; set; }

    // [Required]
    // [MinLength(3)]
    // [MaxLength(30)]

    public string? Color { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? ImgUrl { get; set; }
    public string? Owner { get; set; }

    public Car(int year, string? make, string? model, string? imgUrl, string? color, string? owner)
    {
      Id = Guid.NewGuid().ToString();

      Make = make;
      Model = model;
      Year = year;
      ImgUrl = imgUrl;
      Color = color;
      Owner = owner;
    }
  }
}