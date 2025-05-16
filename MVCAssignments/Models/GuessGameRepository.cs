namespace MVCAssignments.Models;

public class GuessGameRepository : IGuessGameRepository
{
    private ISession? _session;
    private const string SessionKey = "GuessGame";
    private const string SessionKeyCounter = "Counter";
    
    public GuessGameRepository(IServiceProvider services)
    {
        _session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
    }
    
    public int GetCounter()
    {
        return (int)(_session?.GetInt32(SessionKeyCounter) ?? 0);
    }
    
    public void IncCounter()
    {
        int counter = GetCounter();
        _session?.SetInt32(SessionKeyCounter, counter + 1);
    }
    
    public int GetRandomNumber()
    {
        return (int)(_session?.GetInt32(SessionKey) ?? 0);
    }
    
    public void SetRandomNumber()
    {
        int rndNum = new Random().Next(1, 100);
        _session?.SetInt32(SessionKey, rndNum);
    }
}