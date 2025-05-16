using System.ComponentModel.DataAnnotations;

namespace MVCAssignments.Models;

public class GuessGame
{
    [Range(1, 99, ErrorMessage = "Please enter a number between 1 and 100.")]
    public int Value { get; set; }

    public string Message { get; set; } = string.Empty;

    public bool IsGuessed(int rndNum)
    {
        Console.WriteLine(rndNum);
        if (Value == rndNum)
        {
            Message = "Congratulations! You guessed the number!";
            return true;
        }
        else if (Value < rndNum)
        {
            Message = "Your guess is too low.";
        }
        else
        {
            Message = "Your guess is too high.";
        }
        return false;
    }
}