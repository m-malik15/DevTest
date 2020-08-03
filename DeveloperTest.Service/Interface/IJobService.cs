using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;


namespace DeveloperTest.Service.Interface
{
    public interface IJobService
    {
        Task<List<Job>> GetJobs();

        Task<Job> GetJob(int jobId);

        Task<Job> CreateJob(Job model);
    }
}
