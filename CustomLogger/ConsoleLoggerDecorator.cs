namespace CustomLogger;

public class ConsoleLoggerDecorator: LoggerDecorator
{
    private ConsoleLogger _consoleLogger;

    public ConsoleLoggerDecorator(ILogger logger) : base(logger)
    {
        _consoleLogger = new ConsoleLogger();
    }

    public override void Log(string message)
    {
       _consoleLogger.Log(message);
       _logger.Log(message);
    }
}