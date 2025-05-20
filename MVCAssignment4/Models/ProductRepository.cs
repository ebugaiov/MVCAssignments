using Newtonsoft.Json;

namespace MVCAssignment4.Models;

public class ProductRepository : IProductRepository
{
    private readonly ISession? _session;
    
    public ProductRepository(IServiceProvider services)
    {
        _session = services.GetRequiredService<IHttpContextAccessor>().HttpContext?.Session;
    }

    public List<Product>? GetProducts()
    {
        string productsRaw = _session?.GetString("Products") ?? string.Empty;
        List<Product>? products = JsonConvert.DeserializeObject<List<Product>>(productsRaw);
        return products;
    }

    public void AddProduct(Product product)
    {
        string productsRaw = _session?.GetString("Products") ?? string.Empty;
        List<Product> products = JsonConvert.DeserializeObject<List<Product>>(productsRaw) ?? new List<Product>();
        int newId = products.Any() ? products.Max(p => p.ProductId) + 1 : 1;
        product.ProductId = newId;
        products?.Add(product);
        string productsJson = JsonConvert.SerializeObject(products);
        _session?.SetString("Products", productsJson);
    }
}
