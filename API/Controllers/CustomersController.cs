﻿using API.Models;
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

        //customers/GetCustomerById/1
        [HttpGet("GetCustomerById/{idCustomer}")]
        public IActionResult GetCustomer(int idCustomer)
        {
            if (idCustomer<1)
            {
                return BadRequest();
            }
            var customerResponse = _customerService.GetCustomerById(idCustomer);
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

        [HttpPost("search-customers")]
        public IActionResult SearchCustomers(SearchVm search)
        {
            var customersList = _customerService.SearchCustomer(search.Id, search.Query);

            return customersList == null
                ? StatusCode(500)
                : (IActionResult) Ok(customersList);
        }

        //products/get-customer-history-by-tenant/3
        [HttpGet("get-customer-history-by-tenant/{idTenant}")]
        public IActionResult GetCustomerHistoryBytenant(int idTenant)
        {
            var customerResponse = _customerService.GetCustomerHistoryByTenant(idTenant);

            return customerResponse == null
                ? StatusCode(500)
                : (IActionResult) Ok(customerResponse);
        }

        //customers/update-customer
        [HttpPost("update-customer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            var customerResponse = _customerService.UpdateCustomer(customer);

            return !customerResponse
                ? StatusCode(500)
                : Ok();
        }
    }
}
