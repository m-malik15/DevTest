using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;

namespace DeveloperTest.Data.Repositories
{
    public class CustomerTypeRepository : Repository<CustomerType>,ICustomerTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerTypeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
