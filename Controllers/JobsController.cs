using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cregslist.models;
using cregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace cregslist.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _js;

    public JobsController(JobsService js)
    {
      _js = js;
    }


    [HttpGet]
    public ActionResult<List<Job>> GetAll()
    {
      try
      {
        List<Job> jobs = _js.GetAll();
        return Ok(jobs);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Job> Get(string id)
    {
      try
      {
        Job job = _js.Get(id);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job jobData)
    {
      try
      {
        Job newJob = _js.Create(jobData);
        return Ok(newJob);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Job> Edit(string id, [FromBody] Job jobUpdate)
    {
      try
      {
        Job job = _js.Edit(id, jobUpdate);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
        _js.Delete(id);
        return Ok("Deleted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}