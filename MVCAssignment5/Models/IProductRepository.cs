using MVCAssignment5.Data;

namespace MVCAssignment5.Models;

public interface IProductRepository
{
    public IEnumerable<Product> GetAll();
    void Create(Product product);
    public Product? GetByName(string name);
}