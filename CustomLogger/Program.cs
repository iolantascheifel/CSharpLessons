namespace CustomLogger;

class Program
{
    static void Main(string[] args)
    {

        ILogger logger = new LoggerBuilder(new ConsoleLogger())
            .WithFile("log.txt")
            .WithFile("file.txt")
            .Build();
        
        Calculator calculator = new Calculator(logger);

        calculator.Add(5, 8);
        calculator.Divide(36, 8);
        calculator.Multiply(5, 8);
        calculator.Subtract(17, 8);
        
      

    }
}