namespace Dotnet.Homeworks.Patterns.Mediator;

public class Boss
{
    private readonly Manager _manager = new Manager();

    public void SendCommand(string message)
    {
        var result = _manager.Send(message);
    }
}