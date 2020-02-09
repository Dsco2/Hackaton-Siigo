using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;
using Business.Models;
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

        public List<CustomerVm> GetCustomerListByTenant(int idTenant)
        {
            return _customerRepository.GetCustomerListByTenant(idTenant);
        }

        public Customer GetCustomerById(int idCustomer)
        {
            var customer = _customerRepository.GetCustomerById(idCustomer);
            UpdateCustomerHistory(idCustomer);
            return customer;
        }

        private void UpdateCustomerHistory(int idCustomer)
        {
            var searchCustomerHistory = _customerRepository.GetCustomerHistory(idCustomer);
            if (searchCustomerHistory != null)
            {
                searchCustomerHistory.AmountOfSearch++;
                _customerRepository.UpdateSearchCustomerHistory(searchCustomerHistory);
            }
            else
            {
                var newHistory = new SearchCustomerHistory
                {
                    AmountOfSearch = 1,
                    IdCustomer = idCustomer
                };

                _customerRepository.CreateSearchCustomerHistory(newHistory);
            }
        }

        public List<CustomerVm> SearchCustomer(int id, string query)
        {
            var customers = _customerRepository.GetCustomerListByTenant(id);

            var stringList = query.Split(' ').ToList();

            var customerList = new List<CustomerVm>();

            foreach(var queryString in stringList)
            {
                var result = customers.Where(x => x.FirstName.InsensitiveConvert().Contains(queryString.InsensitiveConvert()) 
                                                  || x.LastName.InsensitiveConvert().Contains(queryString.InsensitiveConvert()))
                    .ToList();

                if (!customerList.Any())
                {
                    customerList = result;    
                }

                customerList = customerList.Intersect(result).OrderByDescending(x => x.AmountOfSearch).ToList();
            }

            return customerList;
        }

        public List<CustomerVm> GetCustomerHistoryByTenant(int idTenant)
        {
            return _customerRepository.GetProductByTenant(idTenant);
        }
    }
}
