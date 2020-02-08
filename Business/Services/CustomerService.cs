using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;
using Business.Utilities;

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

        public List<Customer> SearchCustomer(int id, string query)
        {
            var customers = _customerRepository.GetCustomerListByTenant(id);

            var stringList = query.Split(' ').ToList();

            var customerList = new List<Customer>();

            foreach(var queryString in stringList)
            {
                var result = customers.Where(x => x.FirstName.InsensitiveConvert().Contains(queryString.InsensitiveConvert()) 
                                                  || x.LastName.InsensitiveConvert().Contains(queryString.InsensitiveConvert()))
                    .ToList();

                if (!customerList.Any())
                {
                    customerList = result;    
                }

                customerList = customerList.Intersect(result).ToList();
            }

            return customerList;
        }
    }
}
