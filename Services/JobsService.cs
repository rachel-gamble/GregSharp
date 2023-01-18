using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GregSharp.Services;

public class JobsService
{
    private readonly JobsRepository _repo;

    public JobsService(JobsRepository repo)
    {
        _repo = repo;
    }

    internal List<Job> Get()
    {
        List<Job> jobs = _repo.Get();
        return jobs;
    }

    internal Job Create(Job jobData)
    {
        Job job = _repo.Create(jobData);
        return job;
    }
}
