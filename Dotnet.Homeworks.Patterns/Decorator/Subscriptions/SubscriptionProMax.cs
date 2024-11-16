using Dotnet.Homeworks.Patterns.Decorator.Abstractions;

namespace Dotnet.Homeworks.Patterns.Decorator.Subscriptions;

public class SubscriptionProMax : Subscription
{
    public override string GetHelloMessage(string userName)
    {
        return $"Hello, boss {userName}! How are you?:)))))";
    }

    public override byte[] GetMusic(string id)
    {
        // достали
        // подняли качество
        return [];
    }
}