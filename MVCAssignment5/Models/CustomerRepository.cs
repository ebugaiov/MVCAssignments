using MVCAssignment5.Data;

namespace MVCAssignment5.Models;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;

    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Customer> GetAll()
    {
        return _context.Customers.ToList();
    }

    public void Create(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
    }
}
