using System.Linq;
using Business.Entities;
using Business.Interfaces;

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

        public Customer GetCustomer(int idCustomer)
        {
            return _context.Customers
                .FirstOrDefault(x => x.IdCustomer == idCustomer);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            //todo
            return customer;
        }
    }
}
