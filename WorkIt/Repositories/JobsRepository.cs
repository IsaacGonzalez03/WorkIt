using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using WorkIt.Models;

namespace WorkIt.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }
    public List<Job> GetAllJobs()
    {
      string sql = @"
      SELECT * 
      FROM jobs;
      ";
      return _db.Query<Job>(sql).ToList();
    }
  }
}
