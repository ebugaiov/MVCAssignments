using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using MVCAssignment5.Data;
using MVCAssignment5.Models;

namespace MVCAssignment5.Controllers;

public class AssignmentController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly ICustomerRepository _customerRepository;

    public AssignmentController(IProductRepository productRepository, ICustomerRepository customerRepository)
    {
        _productRepository = productRepository;
        _customerRepository = customerRepository;
    }
    
    public IActionResult List()
    {
        var products = _productRepository.GetAll();
        var custormers = _customerRepository.GetAll();
        return View(new AssignmentViewModel(products, custormers));
    }

    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            _productRepository.Create(product);
            return RedirectToAction("List");
        }
        
        return View(product);
    }

    public IActionResult CreateCustomer()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateCustomer(Customer customer)
    {
        if (ModelState.IsValid)
        {
            _customerRepository.Create(customer);
            return RedirectToAction("List");
        }
        
        return View(customer);
    }
}

