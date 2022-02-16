namespace Services
{
    public class GreetingService : IGreetingService
    {
        private readonly IOutput _output;

        public GreetingService(IOutput output)
        {
            _output = output;
        }

        public string SayHello(string name)
        {
            var message = $"Hello {name}!";
            _output.WriteLine(message);
            return message;
        }
    }
}