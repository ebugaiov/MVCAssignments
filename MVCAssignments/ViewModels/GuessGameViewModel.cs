using MVCAssignments.Models;

namespace MVCAssignments.ViewModels;

public class GuessGameViewModel(GuessGame guessGame, int counter)
{
    public GuessGame GuessGame { get; } = guessGame;

    public int Counter { get; } = counter;
}