using Dotnet.Homeworks.Patterns.Decorator.Abstractions;

namespace Dotnet.Homeworks.Patterns.Decorator.Subscriptions;

public class SubscriptionBase : Subscription
{
    public override string GetHelloMessage(string userName)
    {
        return base.GetHelloMessage(userName);
    }

    public override byte[] GetMusic(string id)
    {
        // достали музыку
        // вставили рекламу
        // вернули музыку с рекламой
        return [];
    }
}