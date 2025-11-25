namespace CustomLogger;

class Program
{
    private static int _logCounter;
    static void SendMessage(string message)
    {
        Console.WriteLine($"{_logCounter++}: {message}");
    }
    static void Main(string[] args)
    {

        ILogger logger = new LoggerBuilder(new ConsoleLogger())
            .WithFile("log.txt")
            .WithFile("file.txt")
            .Build();
        
        Calculator calculator = new Calculator();
        calculator.OnLog = logger.Log;
        calculator.OnLog += SendMessage;
        calculator.OnLog -= logger.Log;

        calculator.Add(5, 8);
        calculator.Divide(36, 8);
        calculator.Multiply(5, 8);
        calculator.Subtract(17, 8);
    }
}