using Microsoft.AspNetCore.Mvc;
using MVCAssignments.Models;

namespace MVCAssignments.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public IActionResult Index()
    {
        List<Product>? products = _productRepository.GetProducts()?.ToList() ?? new List<Product>();
        return View(products);
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _productRepository.AddProduct(product);
            return RedirectToAction("Index");
        }
        
        return View(product);
    }
}