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

        //customers/GetCustomer/1
        [HttpGet("GetCustomer/{idCustomer}")]
        public IActionResult GetCustomer(int idCustomer)
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

        //customers/createCustomer
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

        //customers/GetCustomers
        [HttpGet("GetCustomers")]
        public IActionResult GetCustomers()
        {
            var customerResponse = _customerService.GetCustomersList();
            return customerResponse == null
                ?StatusCode(500)
                :(IActionResult)Ok(customerResponse);
        }

        //customers/getCustomerByTenant/1
        [HttpGet("getCustomerByTenant/{idTenant}")]
        public IActionResult CreateCustomerByTenant(int idTenant)
        {
            if (idTenant < 1)
            {
                return BadRequest();
            }

            var customerListResponse = _customerService.GetCustomerListByTenant(idTenant);

            return customerListResponse == null
                ? StatusCode(500)
                : (IActionResult)Ok(customerListResponse);
        }
    }
}
