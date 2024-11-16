namespace Dotnet.Homeworks.Patterns.CommandPattern.Receivers;

public class CookReceiver(string cookName)
{
    public string CookName { get; } = cookName;

    public bool IsEnable { get; set; } = true;

    public async Task PrepareDishAsync(string dishName, CancellationToken cancellationToken)
    {
        Console.WriteLine($"{CookName}: start cooking {dishName}");
        await Task.Delay(300, cancellationToken);
        Console.WriteLine($"{CookName}: {dishName} is cooked");
    }
}