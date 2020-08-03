using System.Threading.Tasks;
using DeveloperTest.Data.Models;
using DeveloperTest.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTest.Controllers
{
    [ApiController, Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _customerService.GetAllCustomers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customer = await _customerService.GetCustomerById(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer model)
        {
           var customer = await _customerService.AddCustomer(model);

            return Created($"model/{customer.CustomerId}", customer);
        }
    }
}