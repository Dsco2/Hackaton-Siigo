using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;
using Business.Models;

namespace Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MainContext _context;

        public CustomerRepository(MainContext context)
        {
            _context = context;
        }


        public Customer AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();

            return customer;
        }

        public Customer GetCustomerById(int idCustomer)
        {
            return _context.Customers
                .FirstOrDefault(x => x.IdCustomer == idCustomer);
        }

        public List<Customer> GetCustomerList()
        {
            return _context.Customers.ToList();
        }

        public List<CustomerVm> GetCustomerListByTenant(int idTenant)
        {
            return _context.Customers
                .Where(x => x.IdTenant == idTenant)
                .Select(x => new CustomerVm
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    IdCustomer = x.IdCustomer,
                    AmountOfSearch = _context.SearchCustomerHistories.Where(y => y.IdCustomer == x.IdCustomer).Select(w => w.AmountOfSearch).FirstOrDefault()
                })
                .ToList();
        }

        public SearchCustomerHistory GetCustomerHistory(int idCustomer)
        {
            return _context.SearchCustomerHistories.FirstOrDefault(x => x.IdCustomer == idCustomer);
        }

        public bool UpdateSearchCustomerHistory(SearchCustomerHistory searchCustomerHistory)
        {
            _context.SearchCustomerHistories.Update(searchCustomerHistory);

            return _context.SaveChanges()>0;
        }

        public bool CreateSearchCustomerHistory(SearchCustomerHistory newHistory)
        {
            _context.SearchCustomerHistories.Add(newHistory);
            return _context.SaveChanges() > 0;
        }

        public List<CustomerVm> GetProductByTenant(int idTenant)
        {
            return _context.SearchCustomerHistories
                .Where(x => x.Customer.IdTenant == idTenant)
                .Select(x => new CustomerVm
                {
                    FirstName = x.Customer.FirstName,
                    LastName = x.Customer.LastName,
                    IdCustomer = x.IdCustomer,
                    AmountOfSearch = x.AmountOfSearch
                }).ToList();
        }

        public bool UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            return _context.SaveChanges()>0;
        }
    }
}
