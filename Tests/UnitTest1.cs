using System.Threading.Tasks;
using DemoStrongInject;
using DemoThunderbolt;
using FluentAssertions;
using Moq;
using Services;
using ThunderboltIoc;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            ThunderboltActivator.Attach<MyThunderboltRegistration>();
        }

        [Fact]
        public void TestJab()
        {
            var serviceProvider = new DemoJab.JabServiceProvider();
            IGreetingService greeter = serviceProvider.GetService<IGreetingService>();
            var result = greeter.SayHello("World");
            result.Should().Be("Hello World!");
        }

        [Fact]
        public async Task TestStrongInject()
        {
            await using var container = new StrongInjectContainer();
            await container.RunAsync(x =>
            {
                var result = x.Run("World"); 
                result.Should().Be("Hello World!");
            });
        }

        [Fact]
        public void TestThunderbolt()
        {
            var greeter = ThunderboltActivator.Container.Get<IGreetingService>();
            var result = greeter.SayHello("World");
            result.Should().Be("Hello World!");
        }
    }
}