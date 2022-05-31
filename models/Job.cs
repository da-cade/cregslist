using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cregslist.models
{
  public class Job
  {
    public string Id { get; set; }

    // [Required]
    // [MinLength(3)]
    // [MaxLength(30)]

    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Company { get; set; }
    public string? StartsAt { get; set; }
    public string? Location { get; set; }

    public Job(string? startsAt, string? description, string? company, string? location, string? title)
    {
      Id = Guid.NewGuid().ToString();
      Description = description;
      Company = company;
      StartsAt = startsAt;
      Location = location;
      Title = title;
    }
  }
}