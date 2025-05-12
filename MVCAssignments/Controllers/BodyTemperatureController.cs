using Microsoft.AspNetCore.Mvc;
using MVCAssignments.Models;

namespace MVCAssignments.Controllers;

public class BodyTemperatureController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        BodyTemperature bodyTemp = new();
        return View(bodyTemp);
    }

    [HttpPost]
    public IActionResult Index(BodyTemperature obj)
    {
        return View(obj);
    }
}