using MVCAssignment5.Data;

namespace MVCAssignment5.Models;

public interface ICustomerRepository
{
    public IEnumerable<Customer> GetAll();
    void Create(Customer customer);
}