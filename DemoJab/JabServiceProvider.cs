using Jab;
using Services;

namespace DemoJab;

[ServiceProvider]
[Singleton(typeof(Program))]
[Transient(typeof(IGreetingService), typeof(GreetingService))]
[Transient(typeof(IOutput), typeof(ConsoleOutput))]
public partial class JabServiceProvider { }