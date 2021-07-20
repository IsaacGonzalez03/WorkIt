using WorkIt.Repositories;

namespace WorkIt.Services
{
  public class ContractorsService
  {
    private readonly ContractorsRepository _cr;

    public ContractorsService(ContractorsRepository cr)
    {
      _cr = cr;
    }
  }
}