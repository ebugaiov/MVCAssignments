namespace MVCAssignments.Models;

public class BodyTemperature : IFormInput
{
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