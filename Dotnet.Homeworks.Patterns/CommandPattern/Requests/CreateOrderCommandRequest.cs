namespace Dotnet.Homeworks.Patterns.CommandPattern.Requests;

public class CreateOrderCommandRequest(List<string> dishesNames)
{
    public List<string> DishesNames { get; set; } = dishesNames;
}