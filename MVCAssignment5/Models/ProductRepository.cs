using MVCAssignment5.Data;

namespace MVCAssignment5.Models;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public void Create(Product product)
    {
        var existingProduct = GetByName(product.Name);

        if (existingProduct != null)
        {
            existingProduct.Stock++;
            existingProduct.Price = product.Price;
        }
        else
        {
            product.Stock = 1;
            _context.Add(product);
        }
        
        _context.SaveChanges();
    }

    public Product? GetByName(string name)
    {
        return _context.Products.FirstOrDefault(x => x.Name == name) ?? null;
    }
}