using Group4API.DataAccessLayer;
using Group4API.Models;

namespace Group4API.Repositories;

// Made by Matthew
public class JobRepo : IJobRepo
{
    private readonly JobManagementDbContext _context;

    public JobRepo(JobManagementDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Job> GetAllJobs()
    {
        return _context.Jobs;
    }

    public Job GetJobById(int id)
    {
        return _context.Jobs.FirstOrDefault(j => j.JobId == id);
    }

    public Job AddJob(Job job)
    {
        _context.Jobs.Add(job);
        _context.SaveChanges();

        return job;
    }

    public void DeleteJobById(int id)
    {
        Job deletedJob = GetJobById(id);

        if (deletedJob != null)
        {
            _context.Jobs.Remove(deletedJob);
            _context.SaveChanges();
        }
    }
}
