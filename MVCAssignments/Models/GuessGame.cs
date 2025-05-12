using System.ComponentModel.DataAnnotations;

namespace MVCAssignments.Models;

public class GuessGame : IFormInput
{
    [Range(1, 99, ErrorMessage = "Please enter a number between 1 and 100.")]
    public double Value { get; set;}

    public string Message { get; set; } = string.Empty;
}