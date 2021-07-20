using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkIt.Models;
using WorkIt.Services;

namespace WorkIt.Controllers
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
    public ActionResult<List<Job>> GetAllJobs()
    {
      try
      {
        return Ok(_js.GetAllJobs());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}