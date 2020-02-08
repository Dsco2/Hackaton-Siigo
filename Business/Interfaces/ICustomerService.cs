using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomer(int idCustomer);
        Customer CreateCustomer(Customer customer);
        List<Customer> GetCustomersList();
        List<Customer> GetCustomerListByTenant(int idTenant);
        List<Customer> SearchCustomer(int searchId, string searchQuery);
    }
}
