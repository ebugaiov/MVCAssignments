using System.ComponentModel.DataAnnotations;

namespace MVCAssignments.Models;

public class BodyTemperature : IFormInput
{
    [Required(ErrorMessage = "Please enter a temperature value")]
    [Range(30, 43, ErrorMessage = "Temperature must be between 30 and 43 degrees Celsius")]
    public double Value { get; set; }

    public string Message
    {
        get
        {
            if (Value != 0)
            {
                if (Value < 35)
                    return "Hypothermia";
                else if (Value >= 35 && Value < 37)
                    return "Normal";
                else if (Value >= 37 && Value < 39)
                    return "Fewer";
                else
                    return "Hyperthermia";
            }
            else
            {
                return "Incorrect value";
            }
        }
        set { }
    }
    
    
}