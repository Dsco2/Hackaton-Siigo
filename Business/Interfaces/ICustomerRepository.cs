using Business.Entities;

namespace Business.Interfaces
{
    public interface ICustomerRepository
    {
        Customer AddCustomer(Customer customer);
        Customer GetCustomer(int idCustomer);
        Customer UpdateCustomer(Customer customer);
    }
}
