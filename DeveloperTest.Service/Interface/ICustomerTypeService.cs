using System.Collections.Generic;
using System.Threading.Tasks;
using DeveloperTest.Data.Models;

namespace DeveloperTest.Service.Interface
{
    public interface ICustomerTypeService
    {
       Task<List<CustomerType>> GetCustomerTypes();
    }
}
