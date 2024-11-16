using Dotnet.Homeworks.Patterns.Decorator.Abstractions;

namespace Dotnet.Homeworks.Patterns.Decorator.Subscriptions;

public class SubscriptionPro : Subscription
{
    public override string GetHelloMessage(string userName)
    {
        return $"Hello, {userName}! How are you?:)";
    }

    public override byte[] GetMusic(string id)
    {
        // доставли
        // вернули
        return [];
    }
}