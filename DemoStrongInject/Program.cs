using Services;

namespace DemoStrongInject;

static class Program
{
    static async Task Main(string[] args)
    {
        await using var container = new StrongInjectContainer();
        await container.RunAsync(x => x.Run(args));
    }
}

public class App
{
    private readonly IGreetingService _greeter;

    public App(IGreetingService greeter)
    {
        _greeter = greeter;
    }

    public string Run(params string[] args)
    {
        return _greeter.SayHello(args.FirstOrDefault() ?? "World");
    }
}