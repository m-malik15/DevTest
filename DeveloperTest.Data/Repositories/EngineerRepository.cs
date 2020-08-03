using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;

namespace DeveloperTest.Data.Repositories
{
    public class EngineerRepository : Repository<Engineer>, IEngineerRepository
    {
        private readonly ApplicationDbContext _context;

        public EngineerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
