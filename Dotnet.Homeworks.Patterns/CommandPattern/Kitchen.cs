using System.Collections.Concurrent;
using Dotnet.Homeworks.Patterns.CommandPattern.Receivers;
using Dotnet.Homeworks.Patterns.CommandPattern.Requests;

namespace Dotnet.Homeworks.Patterns.CommandPattern;

public class Kitchen(ConcurrentBag<CookReceiver> cookReceivers)
{
    private readonly ConcurrentQueue<string> _dishes = [];
    
    private readonly object _locker = new ();

    public async Task PrepareDishesAsync(CreateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        foreach (var dish in request.DishesNames)
            _dishes.Enqueue(dish);

        var tasks = new List<Task>();

        for (var i = 0; i < _dishes.Count; i++)
        {
            _dishes.TryDequeue(out var dish);

            if (dish is null)
                return;

            var cook = await GetEnableCookReceiverAsync(cancellationToken);
            
            lock (_locker)
            {
                cook.IsEnable = false;
            }
            
            tasks.Add(Task.Run(() => cook.PrepareDishAsync(dish, cancellationToken), cancellationToken));
        }

        await Task.WhenAll(tasks);

        lock (_locker)
        {
            foreach (var cookReceiver in cookReceivers)
                cookReceiver.IsEnable = true;
        }
    }

    private async Task<CookReceiver> GetEnableCookReceiverAsync(CancellationToken cancellationToken)
    {
        var cook = cookReceivers.FirstOrDefault(x => x.IsEnable);
        while (cook is null)
        {
            await Task.Delay(500, cancellationToken);
            cook = cookReceivers.FirstOrDefault(x => x.IsEnable);
        }

        return cook;
    }
}