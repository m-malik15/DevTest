using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace DeveloperTest.Data.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        private readonly ApplicationDbContext _context;

        public JobRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override Task<List<Job>> GetAll()
        {
            return _context.Jobs.AsQueryable()
                .Include(x => x.Engineer)
                .Include(x => x.Customer)
                .ToListAsync();
            
        }

        public override Task<Job> Get(int id)
        {
            return _context.Jobs.Where(x => x.JobId == id)
                .Include(x => x.Engineer)
                .Include(x => x.Customer)
                .ThenInclude(x=>x.CustomerType)
                .SingleAsync();
        }
    }
}
