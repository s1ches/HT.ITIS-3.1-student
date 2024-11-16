using Dotnet.Homeworks.Patterns.CommandPattern;
using Dotnet.Homeworks.Patterns.CommandPattern.Commands;
using Dotnet.Homeworks.Patterns.CommandPattern.Invokers;
using Dotnet.Homeworks.Patterns.CommandPattern.Receivers;
using Dotnet.Homeworks.Patterns.CommandPattern.Requests;

# region Example Command Pattern
var cook = new CookReceiver("Вася");
var cook2 = new CookReceiver("Петя");
var cook3 = new CookReceiver("Ваня");

var kitchen = new Kitchen([cook, cook2, cook3]);
var invoker = new Waiter();
var invoker2 = new Waiter(); 

var request = new CreateOrderCommandRequest(["гречка", "котлетки"]);
var request2 = new CreateOrderCommandRequest(["макарошки", "сосисочки"]);
var request3 = new CreateOrderCommandRequest(["каша", "блинчики"]);

var command = new CreateOrderCommand(kitchen, request);
var command2 = new CreateOrderCommand(kitchen, request2);
var command3 = new CreateOrderCommand(kitchen, request3);

var ct = new CancellationToken();

var thread1 = new Thread(() =>
{
    invoker.SetCommand(command);
    invoker.InvokeAsync(ct);
});

var thread2 = new Thread(() =>
{
    invoker2.SetCommand(command2);
    invoker2.InvokeAsync(ct);
    
    invoker2.SetCommand(command3);
    invoker2.InvokeAsync(ct);
});

thread1.Start();
thread2.Start();

Thread.Sleep(20000);
#endregion


Console.WriteLine("");


