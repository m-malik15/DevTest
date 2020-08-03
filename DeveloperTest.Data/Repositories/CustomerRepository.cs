using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace DeveloperTest.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override Task<List<Customer>> GetAll()
        {
            return _context.Customers.AsQueryable()
                .Include(x => x.CustomerType)
                .ToListAsync();

        }

        public override Task<Customer> Get(int id)
        {
            return _context.Customers.Where(x => x.CustomerId == id)
                .Include(x => x.CustomerType)
                .SingleAsync();
        }
    }
}
