using System.Collections.Generic;
using Business.Entities;
using Business.Models;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int idCustomer);
        Customer CreateCustomer(Customer customer);
        List<Customer> GetCustomersList();
        List<CustomerVm> GetCustomerListByTenant(int idTenant);
        List<CustomerVm> SearchCustomer(int searchId, string searchQuery);
        List<CustomerVm> GetCustomerHistoryByTenant(int idTenant);
        bool UpdateCustomer(Customer customer);
    }
}
