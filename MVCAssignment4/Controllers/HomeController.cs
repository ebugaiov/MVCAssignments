using Microsoft.AspNetCore.Mvc;
using MVCAssignment4.Models;

namespace MVCAssignment4.Controllers;

public class HomeController : Controller
{
    private readonly IProductRepository _productRepository;

    public HomeController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        return RedirectToAction("List");
    }

    public IActionResult List()
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
            return RedirectToAction("List");
        }
        
        return View(product);
    }
}