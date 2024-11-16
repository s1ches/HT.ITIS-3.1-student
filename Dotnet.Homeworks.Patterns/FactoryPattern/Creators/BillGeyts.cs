using Dotnet.Homeworks.Patterns.FactoryPattern.Abstractions;
using Dotnet.Homeworks.Patterns.FactoryPattern.Products;

namespace Dotnet.Homeworks.Patterns.FactoryPattern.Creators;

public class BillGeyts : Creator
{
    public override Product Create()
    {
        Console.WriteLine("Создан Windows");
        return new Windows();
    }
}