using Microsoft.AspNetCore.Mvc;
using MVCAssignments.Models;

namespace MVCAssignments.Controllers;

public class BodyTemperatureController : Controller
{
    [Route("CheckTemperature")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("CheckTemperature")]
    [HttpPost]
    public IActionResult Index(BodyTemperature obj)
    {
        return View(obj);
    }
}