namespace MVCAssignments.Models;

public interface IProductRepository
{
    public List<Product>? GetProducts();
    
    public void AddProduct(Product product);
}