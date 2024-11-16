using Dotnet.Homeworks.Patterns.FactoryPattern.Abstractions;
using Dotnet.Homeworks.Patterns.FactoryPattern.Products;

namespace Dotnet.Homeworks.Patterns.FactoryPattern.Creators;

public class TimCook : Creator
{
    public override Product Create()
    {
        Console.WriteLine("Создан MacOS");
        return new MacOs();
    }
}