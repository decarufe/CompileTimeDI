using JetBrains.Annotations;
using Services;

new DemoJab.JabServiceProvider().GetService<Program>().Run(args);

[UsedImplicitly]
internal partial class Program
{
    private readonly IGreetingService _greeter;

    public Program(IGreetingService greeter)
    {
        _greeter = greeter;
    }

    private void Run(string[] args)
    {
        _greeter.SayHello("World");
    }
}