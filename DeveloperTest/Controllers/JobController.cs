using System;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using Microsoft.AspNetCore.Mvc;
using DeveloperTest.Service.Interface;


namespace DeveloperTest.Controllers
{
    [ApiController, Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            this._jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _jobService.GetJobs());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var job = await _jobService.GetJob(id);

            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Job job)
        {
            if (job.When.Date < DateTime.Now.Date)
            {
                return BadRequest("Date cannot be in the past");
            }

            var createdJob = await _jobService.CreateJob(job);

             return Created($"Job/{createdJob.JobId}", job);
        }
    }
}