using Group4API.Models;
using Group4API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Group4API.Controllers;

// Made by Matthew
[Route("api/[controller]")]
public class JobController: ControllerBase
{
    private readonly IJobRepo _jobs;

    public JobController (IJobRepo jobs)
    {
        _jobs = jobs;
    }

    [HttpGet]
    public IEnumerable<Job> GetAllJobs()
    {
        return _jobs.GetAllJobs();
    }

    [HttpGet("{id}")]
    public ActionResult<Job> GetJobById(int id)
    {
        Job job = _jobs.GetJobById(id);
        if (job != null)
        {
            return job;
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult<Job> Post([FromBody] Job job)
    {
        Job addJob = _jobs.AddJob(job);

        return CreatedAtAction("GetJobById", new { id = addJob.JobId }, addJob);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteJobById(int id)
    {
        Job job = _jobs.GetJobById(id);

        if (job == null)
        {
            return NotFound();
        }

        _jobs.DeleteJobById(id);

        return NoContent();
    }
}
