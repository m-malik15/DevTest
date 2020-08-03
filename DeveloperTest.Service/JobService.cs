using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;
using DeveloperTest.Service.Interface;


namespace DeveloperTest.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        
        }

        public async Task<List<Job>> GetJobs()
        {
            return await _jobRepository.GetAll();
          
        }

        public async Task<Job> GetJob(int jobId)
        {
            return await _jobRepository.Get(jobId);
        }

        public async Task<Job> CreateJob(Job job)
        {
            return await _jobRepository.Add(job);
        }
    }
}
