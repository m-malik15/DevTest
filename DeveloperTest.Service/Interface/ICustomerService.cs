using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;

namespace DeveloperTest.Service.Interface
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> AddCustomer(Customer customer);
    }
}
