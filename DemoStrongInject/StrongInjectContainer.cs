using Services;
using StrongInject;

namespace DemoStrongInject
{
    [Register(typeof(App), Scope.SingleInstance)]
    [Register(typeof(GreetingService), Scope.InstancePerResolution, typeof(IGreetingService))]
    [Register(typeof(ConsoleOutput), Scope.InstancePerResolution, typeof(IOutput))]
    public partial class StrongInjectContainer : IAsyncContainer<App> { }
}