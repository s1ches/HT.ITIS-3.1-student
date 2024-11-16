namespace Dotnet.Homeworks.Patterns.Decorator.Abstractions;

public abstract class Subscription
{
    public virtual string GetHelloMessage(string userName) => $"Hello, {userName}";

    public abstract byte[] GetMusic(string id);
}