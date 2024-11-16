using Dotnet.Homeworks.Patterns.CommandPattern.Requests;
using ICommand = Dotnet.Homeworks.Patterns.CommandPattern.Abstractions.ICommand;

namespace Dotnet.Homeworks.Patterns.CommandPattern.Commands;

public class CreateOrderCommand(Kitchen kitchen, CreateOrderCommandRequest request) : ICommand
{
    public async Task ExecuteAsync(CancellationToken cancellationToken) => await kitchen.PrepareDishesAsync(request, cancellationToken);
}