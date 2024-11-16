namespace Dotnet.Homeworks.Patterns.CommandPattern.Abstractions;

public interface ICommand
{
    Task ExecuteAsync(CancellationToken cancellationToken);
}