using Microsoft.AspNetCore.Mvc;
using WorkIt.Services;

namespace WorkIt.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _cs;

    public ContractorsController(ContractorsService cs)
    {
      _cs = cs;
    }
  }
}