using DeveloperTest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DeveloperTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedEngineers(modelBuilder);
            SeedCustomerTypes(modelBuilder);
            SeedCustomer(modelBuilder);
        }

        public static void SeedEngineers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Engineer>().HasData(new Engineer
            {
                EngineerId = 1,
                Name = "Ashley"
            }, new Engineer
            {
                EngineerId = 2,
                Name = "Dave"
            }, new Engineer
            {
                EngineerId = 3,
                Name = "Kalina"
            });
        }

        public static void SeedCustomerTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerType>().HasData(new CustomerType
            {
                CustomerTypeId = 1,
                Description = "Large"
            }, new CustomerType()
            {
                CustomerTypeId = 2,
                Description = "Small"
            });
        }

        public static void SeedCustomer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1000,
                CustomerTypeId = 1,
                Name = "John Doe"
            }, new Customer()
            {
                CustomerId = 1001,
                CustomerTypeId = 2,
                Name = "Joe Public"
            });
        }


    }
}
