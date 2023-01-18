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

    internal Job Get(int id)
    {
        Job job = _repo.Get(id);
        if (job == null)
        {
            throw new Exception("no job by that id");
        }
        return job;
    }

    internal Job Create(Job jobData)
    {
        Job job = _repo.Create(jobData);
        return job;
    }

    internal Job Update(Job jobUpdate, int id)
    {
        Job original = Get(id);
        original.Company = jobUpdate.Company ?? original.Company;
        original.jobTitle = jobUpdate.jobTitle ?? original.jobTitle;
        original.Salary = jobUpdate.Salary ?? original.Salary;
        original.Hours = jobUpdate.Hours ?? original.Hours;
        original.Prerequisites = jobUpdate.Prerequisites ?? original.Prerequisites;
        original.imgUrl = jobUpdate.imgUrl ?? original.imgUrl;
        original.Description = jobUpdate.Description ?? original.Description;

        bool edited = _repo.Update(original);
        if (edited == false)
        {
            throw new Exception("Job was not edited");
        }
        return original;
    }
}
