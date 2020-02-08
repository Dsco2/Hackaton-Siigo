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

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }

        public Customer GetCustomer(int idCustomer)
        {
            return _customerRepository.GetCustomer(idCustomer);
        }
    }
}
