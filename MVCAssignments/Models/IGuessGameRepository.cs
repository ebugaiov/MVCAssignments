namespace MVCAssignments.Models;

public interface IGuessGameRepository
{
    public int GetCounter();
    
    public void IncCounter();

    public int GetRandomNumber();
    
    public void SetRandomNumber();
}