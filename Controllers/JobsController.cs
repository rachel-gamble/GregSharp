using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GregSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly JobsService _jobsService;

    public JobsController(JobsService jobsService)
    {
        _jobsService = jobsService;
    }

    [HttpGet]
    public ActionResult<List<Job>> Get()
    {
        try
        {
            List<Job> jobs = _jobsService.Get();
            return Ok(jobs);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job jobData)
    {
        try
        {
            Job job = _jobsService.Create(jobData);
            return Ok(job);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}")]
    public ActionResult<Job> Get(int id)
    {
        try
        {
            Job job = _jobsService.Get(id);
            return Ok(job);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id}")]

    public ActionResult<Job> Update([FromBody] Job jobUpdate, int id)
    {
        try
        {
            Job job = _jobsService.Update(jobUpdate, id);
            return Ok(job);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
            throw;
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Remove(int id)
    {
        try
        {
            string message = _jobsService.Remove(id);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
