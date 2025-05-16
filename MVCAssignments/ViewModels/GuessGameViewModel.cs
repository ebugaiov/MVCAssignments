using MVCAssignments.Models;

namespace MVCAssignments.ViewModels;

public class GuessGameViewModel
{
    public GuessGame GuessGame { get; set; }

    public int Counter { get; set; }
    
    public GuessGameViewModel() { }
    
    public GuessGameViewModel(GuessGame guessGame, int counter)
    {
        GuessGame = guessGame;
        Counter = counter;
    }
}
