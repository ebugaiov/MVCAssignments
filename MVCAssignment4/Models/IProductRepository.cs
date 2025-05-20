namespace MVCAssignment4.Models;

public interface IProductRepository
{
    public List<Product>? GetProducts();
    
    public void AddProduct(Product product);
}