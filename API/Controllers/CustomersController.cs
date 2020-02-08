using Business.Entities;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetCustomer/{idCustomer}")]
        public IActionResult Get(int idCustomer)
        {
            if (idCustomer<1)
            {
                return BadRequest();
            }
            var customerResponse = _customerService.GetCustomer(idCustomer);
            return customerResponse == null
                ?StatusCode(500)
                :(IActionResult)Ok(customerResponse);
        }

        [HttpPost("createCustomer")]
        public IActionResult CreateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            var customerResponse = _customerService.CreateCustomer(customer);

            return customerResponse == null
                   ? StatusCode(500)
                   : (IActionResult)Ok(customerResponse);
        }

        [HttpPost("updateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            var customerResponse = _customerService.UpdateCustomer(customer);

            return customerResponse == null
                ? StatusCode(500)
                : (IActionResult)Ok(customerResponse);
        }
    }
}
