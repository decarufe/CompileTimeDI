// See https://aka.ms/new-console-template for more information

using DemoThunderbolt;
using Services;
using ThunderboltIoc;

ThunderboltActivator.Attach<MyThunderboltRegistration>();

var greeter = ThunderboltActivator.Container.Get<IGreetingService>();
greeter.SayHello(args.FirstOrDefault() ?? "World");
