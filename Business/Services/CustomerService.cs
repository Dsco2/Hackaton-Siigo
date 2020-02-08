using System.Collections.Generic;
using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class CustomerService : ICustomerService
    {
        public IEnumerable<Customer> GetCustomers()
        {
            var customerList = new List<Customer>();
            customerList.Add(new Customer{
                FirstName = "TEST"
            });

            return customerList;
        }
    }
}
