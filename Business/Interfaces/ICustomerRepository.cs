using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ICustomerRepository
    {
        Customer AddCustomer(Customer customer);
        Customer GetCustomer(int idCustomer);
        List<Customer> GetCustomerList();
        List<Customer> GetCustomerListByTenant(int idTenant);
    }
}
