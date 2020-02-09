using System.Collections.Generic;
using Business.Entities;
using Business.Models;

namespace Business.Interfaces
{
    public interface ICustomerRepository
    {
        Customer AddCustomer(Customer customer);
        Customer GetCustomerById(int idCustomer);
        List<Customer> GetCustomerList();
        List<CustomerVm> GetCustomerListByTenant(int idTenant);
        SearchCustomerHistory GetCustomerHistory(int idCustomer);
        bool UpdateSearchCustomerHistory(SearchCustomerHistory searchCustomerHistory);
        bool CreateSearchCustomerHistory(SearchCustomerHistory newHistory);
        List<CustomerVm> GetProductByTenant(int idTenant);
        bool UpdateCustomer(Customer customer);
    }
}
