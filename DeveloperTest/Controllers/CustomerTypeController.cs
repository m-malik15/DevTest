using System.Threading.Tasks;
using DeveloperTest.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTest.Controllers
{
    [ApiController, Route("[controller]")]
    public class CustomerTypeController : ControllerBase
    {
        private readonly ICustomerTypeService _customerTypeService;
        public CustomerTypeController(ICustomerTypeService customerTypeService)
        {
            _customerTypeService = customerTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _customerTypeService.GetCustomerTypes());
        }
    }
}