using Microsoft.AspNetCore.Mvc;
using MVCAssignments.Models;

namespace MVCAssignments.Controllers;

public class GuessGameController : Controller
{
    public IActionResult Index()
    {
        HttpContext.Session.SetInt32("_GuessNumber", new Random().Next(1, 100));
        GuessGame guessGame = new();
        return View(guessGame);
    }

    [HttpPost]
    public IActionResult Index(GuessGame guessGame)
    {
        double guessNumber = (double)HttpContext.Session.GetInt32("_GuessNumber")!;
        Console.WriteLine(guessNumber);
        if (guessGame.Value == guessNumber)
            guessGame.Message = "You win!";
        else if (guessGame.Value < guessNumber)
            guessGame.Message = "Try a higher number.";
        else
            guessGame.Message = "Try a lower number.";
        return View(guessGame);
    }
}
