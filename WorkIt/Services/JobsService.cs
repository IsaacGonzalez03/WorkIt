using System;
using System.Collections.Generic;
using WorkIt.Models;
using WorkIt.Repositories;

namespace WorkIt.Services
{
  public class JobsService
  {
    private readonly JobsRepository _jr;
    private readonly ContractorsRepository _cr;
    public JobsService(JobsRepository jr, ContractorsRepository cr)
    {
      _jr = jr;
      _cr = cr;
    }

    public List<Job> GetAllJobs()
    {
      return _jr.GetAllJobs();
    }

    public object CreateJob(Job jobData)
    {
      var job = _jr.CreateJob(jobData);
      _cr.CreateContractor(job.CreatorId, job.Id);
      return job;
    }
  }
}