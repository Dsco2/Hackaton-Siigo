using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomer(int idCustomer);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
    }
}
