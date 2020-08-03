using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using DeveloperTest.Data.Repositories.Interface;
using DeveloperTest.Service.Interface;

namespace DeveloperTest.Service
{
    public class CustomerTypeService: ICustomerTypeService
    {
        private readonly ICustomerTypeRepository _customerTypeRepository;

        public CustomerTypeService(ICustomerTypeRepository customerTypeRepository)
        {
            _customerTypeRepository = customerTypeRepository;
        }

        public async Task<List<CustomerType>> GetCustomerTypes()
        {
            return await _customerTypeRepository.GetAll();
        }
    }
}
