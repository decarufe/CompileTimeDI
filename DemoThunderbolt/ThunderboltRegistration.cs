using Services;
using ThunderboltIoc;

namespace DemoThunderbolt;

public partial class MyThunderboltRegistration : ThunderboltRegistration
{
    protected override void Register(IThunderboltRegistrar reg)
    {
        reg.AddTransient<IGreetingService, GreetingService>();
        reg.AddTransient<IOutput, ConsoleOutput>();
    }
}