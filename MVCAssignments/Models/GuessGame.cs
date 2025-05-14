using System.ComponentModel.DataAnnotations;

namespace MVCAssignments.Models;

public class GuessGame
{
    [Range(1, 99, ErrorMessage = "Please enter a number between 1 and 100.")]
    public int Value { get; set;}

    public string Message { get; set; } = string.Empty;
}