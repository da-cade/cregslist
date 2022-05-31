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
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;

    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    // 
    [HttpGet]
    public ActionResult<List<Car>> GetAll()
    {
      try
      {
        List<Car> cars = _cs.GetAll();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Car> Get(string id)
    {
      try
      {
        Car car = _cs.Get(id);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car carData)
    {
      try
      {
        Car newCar = _cs.Create(carData);
        return Ok(newCar);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Car> Edit(string id, [FromBody] Car carData)
    {
      try
      {
        Car updated = _cs.Edit(id, carData);
        return Ok(updated);
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
        _cs.Delete(id);
        return "Deleted";
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}