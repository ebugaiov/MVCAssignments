using MVCAssignment5.Data;

namespace MVCAssignment5.Models;

public class AssignmentViewModel
{
    public IEnumerable<Product> Products { get; set; } = new List<Product>();
    public IEnumerable<Customer> Customers { get; set; } = new List<Customer>();

    public AssignmentViewModel() { }
    
    public AssignmentViewModel(IEnumerable<Product> products, IEnumerable<Customer> customers)
    {
        Products = products;
        Customers = customers;
    }
}