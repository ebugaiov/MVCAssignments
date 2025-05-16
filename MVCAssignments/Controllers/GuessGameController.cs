using Microsoft.AspNetCore.Mvc;
using MVCAssignments.Models;
using MVCAssignments.ViewModels;

namespace MVCAssignments.Controllers;

public class GuessGameController : Controller
{
    private IGuessGameRepository _guessGameRepository;

    public GuessGameController(IGuessGameRepository guessGameRepository)
    {
        _guessGameRepository = guessGameRepository;
    }
    
    public IActionResult Index()
    {
        _guessGameRepository.SetRandomNumber();
        GuessGameViewModel viewModel = new()
        {
            GuessGame = new GuessGame(),
            Counter = _guessGameRepository.GetCounter()
        };
        
        string? message = Request.Query["message"];
        if (!string.IsNullOrEmpty(message))
        {
            viewModel.GuessGame.Message = message;
        }
        
        return View(viewModel);
    }
    
    [HttpPost]
    public IActionResult Index(GuessGame guessGame)
    {
        if (ModelState.IsValid)
        {
            if (guessGame.IsGuessed(_guessGameRepository.GetRandomNumber()))
            {
                _guessGameRepository.IncCounter();
                return RedirectToAction("Index", new { message = guessGame.Message });
            }
        }
        return View(new GuessGameViewModel(guessGame, _guessGameRepository.GetCounter()));
    }
}
