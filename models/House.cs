using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cregslist.models
{
  public class House
  {
    public string Id { get; set; }

    // [Required]
    // [MinLength(3)]
    // [MaxLength(30)]

    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Year { get; set; }
    public int Levels { get; set; }
    public string? ImgUrl { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public House(int year, int bedrooms, int bathrooms, string? imgUrl, string? description, int levels, int price)
    {
      Id = Guid.NewGuid().ToString();

      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Year = year;
      ImgUrl = imgUrl;
      Description = description;
      Price = price;
      Levels = levels;
    }
  }

}