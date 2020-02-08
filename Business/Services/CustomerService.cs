using System.Collections.Generic;
using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer CreateCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public List<Customer> GetCustomersList()
        {
            return _customerRepository.GetCustomerList();
        }

        public List<Customer> GetCustomerListByTenant(int idTenant)
        {
            return _customerRepository.GetCustomerListByTenant(idTenant);
        }

        public Customer GetCustomer(int idCustomer)
        {
            return _customerRepository.GetCustomer(idCustomer);
        }
    }
}
