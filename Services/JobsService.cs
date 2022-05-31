using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cregslist.FakeDB;
using cregslist.models;

namespace cregslist.Services
{
  public class JobsService
  {
    internal List<Job> GetAll()
    {
      return Database.Jobs;
    }
    internal Job Get(string id)
    {
      Job found = Database.Jobs.Find(j => j.Id == id);
      if (found == null)
      {
        throw new Exception("invalid id");
      }
      return found;
    }
    internal Job Create(Job jobData)
    {
      Database.Jobs.Add(jobData);
      return jobData;
    }

    internal Job Edit(string id, Job jobData)
    {
      Job original = Get(id);

      original.StartsAt = jobData.StartsAt ?? original.StartsAt;
      original.Title = jobData.Title ?? original.Title;
      original.Description = jobData.Description ?? original.Description;
      original.Location = jobData.Location ?? original.Location;
      original.Company = jobData.Company ?? original.Company;


      return original;
    }

    internal void Delete(string id)
    {
      Job found = Get(id);
      Database.Jobs.Remove(found);
    }
  }
}