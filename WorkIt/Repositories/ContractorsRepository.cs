using System;
using System.Data;
using Dapper;
using WorkIt.Models;

namespace WorkIt.Repositories
{
  public class ContractorsRepository
  {
    private readonly IDbConnection _db;

    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }

    public void CreateContractor(string accountId, int job)
    {
      string sql = @"
            INSERT INTO 
            contractors(accountId, jobId)
            VALUES(@AccountId, @JobId);
            SELECT LAST_INSERT_ID();
            ";
      _db.Execute(sql);
    }
  }
}