using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
    }
}
