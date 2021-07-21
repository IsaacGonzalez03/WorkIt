using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Job>> Create([FromBody] Job jobData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        jobData.CreatorId = userInfo.Id;
        var j = _js.CreateJob(jobData);
        return Ok(j);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}