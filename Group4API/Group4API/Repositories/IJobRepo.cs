using Group4API.Models;

namespace Group4API.Repositories;

// Made by Matthew
public interface IJobRepo
{
    IEnumerable<Job> GetAllJobs();

    Job GetJobById(int id);

    Job AddJob(Job job);

    void DeleteJobById(int id);
}
