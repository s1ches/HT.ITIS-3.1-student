using Dotnet.Homeworks.Patterns.CommandPattern.Abstractions;

namespace Dotnet.Homeworks.Patterns.CommandPattern.Invokers;

public class Waiter
{
    protected ICommand Command { get; set; }

    public virtual void SetCommand(ICommand command) => Command = command; 

    public virtual Task InvokeAsync(CancellationToken cancellationToken) => Command.ExecuteAsync(cancellationToken);
}