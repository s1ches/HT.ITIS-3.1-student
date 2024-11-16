namespace Dotnet.Homeworks.Patterns.Mediator;

public class Manager : Abstractions.Mediator
{
    private readonly Random _rnd = new Random();
    
    private readonly List<Developer> _developers = [];
    
    public override string Send(string message)
    {
        // analyze
        var result = _developers[_rnd.Next(0, _developers.Count)].Do(message);
        // analyze
        return result;
    }
}