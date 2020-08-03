using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;
using DeveloperTest.Service.Interface;

namespace DeveloperTest.Service
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _customerRepository.GetAll();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerRepository.Get(id) ;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            return await _customerRepository.Add(customer);
        }
    }
}
