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
    public Job CreateJob(Job jobData)
    {
      var sql = @"
            INSERT INTO jobs(name, description, creatorId)
            VALUES(@Name, @Description, @CreatorId);
            SELECT LAST_INSERT_ID();
            ";
      var id = _db.ExecuteScalar<int>(sql, jobData);
      jobData.Id = id;
      return jobData;
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
