using Microsoft.AspNetCore.Mvc;
using MVCAssignments.Models;
using MVCAssignments.ViewModels;

namespace MVCAssignments.Controllers;

public class GuessGameController : Controller
{
    private const string SessionKeyGuessNum = "_GuessNumber";
    private const string SessionKeyCounter = "_Counter";

    public int GetCounter()
    {
        return (int)(HttpContext.Session.GetInt32(SessionKeyCounter) ?? 0);
    }
    
    public void IncCounter()
    {
        int counter = GetCounter();
        HttpContext.Session.SetInt32(SessionKeyCounter, counter + 1);
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetInt32(SessionKeyGuessNum, new Random().Next(1, 100));
        GuessGame guessGame = new();
        int counter = GetCounter();
        return View(new GuessGameViewModel(guessGame, counter));
    }

    [HttpPost]
    public IActionResult Index(GuessGame guessGame)
    {
        int guessNumber = (int)HttpContext.Session.GetInt32(SessionKeyGuessNum)!;
        int inputValue = guessGame.Value;
        Console.WriteLine(guessNumber);
        if (inputValue == guessNumber)
        {
            IncCounter();
            guessGame.Message = "You win!";    
        }
        else if (guessGame.Value < guessNumber)
            guessGame.Message = "Try a higher number.";
        else
            guessGame.Message = "Try a lower number.";
        return View(new GuessGameViewModel(guessGame, GetCounter()));
    }
}
